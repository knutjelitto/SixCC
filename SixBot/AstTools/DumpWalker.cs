using Six.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class DumpWalker : Walker
    {
        private readonly Writer writer;

        public DumpWalker(Writer writer)
        {
            this.writer = writer;
        }

        protected override void Visit(Grammar grammar)
        {
            var more = false;
            foreach (var rule in grammar.Rules)
            {
                if (more)
                {
                    writer.WriteLine();
                }
                more = true;
                Walk(rule);
            }
        }

        protected override void Visit(Rule rule)
        {
            writer.Write($"{rule.Name}:");
            using (writer.Indent())
            {
                if (rule.Expression is Alt alt && alt.Expressions.Count >= 2)
                {
                    var more = false;
                    foreach (var sub in alt.Expressions)
                    {
                        writer.WriteLine();
                        if (more)
                        {
                            writer.Write("| ");
                        }
                        else
                        {
                            writer.Write("  ");
                            more = true;
                        }
                        Walk(sub);
                    }
                }
                else
                {
                    writer.WriteLine();
                    Walk(rule.Expression);
                }
            }
            writer.WriteLine();
        }

        protected override void Visit(Reference reference)
        {
            writer.Write($"{reference.Name}");
        }

        protected override void Visit(Seq seq)
        {
            var more = false;
            foreach (var expression in seq.Expressions)
            {
                if (more)
                {
                    writer.Write(" ");
                }
                more = true;
                Walk(expression);
            }
        }

        protected override void Visit(Nonterminal non)
        {
            writer.Write($"{non.Name}");
        }

        protected override void Visit(Terminal term)
        {
            if (term.Expression is Literal lit)
            {
                writer.Write($"{lit.Text.Esc()}");
            }
            else if (term.Expression is Range range)
            {
                writer.Write("(");
                Walk(range.Start);
                writer.Write(" .. ");
                Walk(range.End);
                writer.Write(")");
            }
            else if (term.Expression is Substract substract)
            {
                writer.Write("(");
                Walk(substract.Left);
                writer.Write(" - ");
                Walk(substract.Right);
                writer.Write(")");
            }
            else
            {
                writer.Write("< ");
                Walk(term.Expression);
                writer.Write(" >");
            }
        }

        protected override void Visit(Epsilon epsilon)
        {
            writer.Write("ε");
        }

        protected override void Visit(Undefined undefined)
        {
            writer.Write($"<--[undefined]-->");
        }
    }
}
