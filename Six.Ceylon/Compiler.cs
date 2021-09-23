using Antlr4.Runtime;
using Six.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using IO = System.IO;

namespace Six.Ceylon
{
    public class Compiler
    {
        private Dictionary<FileRef, Compilation> files = new();

        public Compiler()
        {
        }

        public int ErrorCount { get; set; }
        public bool ShouldAbort => ErrorCount >= 1;

        public Compilation Compile(FileRef file)
        {
            if (files.TryGetValue(file, out var compilation))
            {
                return compilation;
            }

            var statistics = new CompileStatistics(file);

            var grossWatch = new Stopwatch();
            grossWatch.Start();

            var stream = new AntlrFileStream(file.Path);
            var lexer = new CeylonLexer(stream);
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new LexerErrorListener());
            var tokens = new CommonTokenStream(lexer);
            var parser = new CeylonParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new SyntaxErrorListener());

            var parseWatch = new Stopwatch();
            parseWatch.Start();
            var context = parser.compilationUnit();
            parseWatch.Stop();

            var astWatch = new Stopwatch();
            astWatch.Start();
            var listener = new AstBuilder(file, tokens, stream);
            var unit = listener.Walk(context);
            astWatch.Stop();

            grossWatch.Stop();

            statistics.GrossTime = grossWatch.Elapsed;
            statistics.ParseTime = parseWatch.Elapsed;
            statistics.AstTime = parseWatch.Elapsed;
            statistics.Lines = context.Stop?.Line ?? 1;

            if (listener.missings > 0)
            {
                throw new Exception("have missings");
            }

            compilation = new Compilation(file, statistics, unit, context);
            files.Add(file, compilation);
            return compilation;
        }

        public class LexerErrorListener : IAntlrErrorListener<int>
        {
            public void SyntaxError(IO.TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new NotImplementedException();
            }
        }

        public class SyntaxErrorListener : BaseErrorListener
        {
            public override void SyntaxError(IO.TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                output.WriteLine();
                output.WriteLine($"{IO.Path.GetFileName(recognizer.InputStream.SourceName)}({line},{charPositionInLine+1}): {msg}");
                base.SyntaxError(output, recognizer, offendingSymbol, line, charPositionInLine, msg, e);
            }
        }
    }
}
