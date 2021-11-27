﻿namespace Six.Gen.Ebnf
{
    public class EbnfDumper
    {
        public EbnfDumper(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public void Dump(Writer writer)
        {
            writer.WriteLine($"grammar {Grammar.Name}");
            foreach (var rule in Grammar.Symbols)
            {
                writer.WriteLine();
                writer.WriteLine($"{rule.Name}");
                using (writer.Indent())
                {
                    rule.Argument.Dump(writer);
                }
            }
        }
    }
}
