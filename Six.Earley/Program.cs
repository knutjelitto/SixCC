using Earley;
using System;
using System.Linq;

namespace Six.Earley
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();

            Console.Write("any key ... ");
            Console.ReadKey(true);
        }

        void Run()
        {
            Console.WriteLine("Type an arithmetic expression. Type a blank line to quit.");

            var parser = CreateParser();

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();

                if (input == null || input.Length == 0)
                {
                    return;
                }

                var results = parser.Parse(input);

                if (results.Count == 0)
                {
                    Console.WriteLine("parse error");
                }
                else
                {
                    foreach (var (exp, i) in results.Cast<Exp>().Select((e, i) => (e, i)))
                    {
                        var result = exp.Eval();
                        Console.WriteLine("Result {0,2}: {1} => {2,4}", i + 1, exp.ToString(), result);
                    }
                }
            }
        }

        Parser CreateParser()
        {
            // Grammar:
            //
            // Digit   ::= [0-9]
            //
            // Literal ::= Digit
            //           | Literal Digit
            //
            // Exp     ::= Literal
            //           | ( Exp )
            //           | Exp + Exp
            //           | Exp - Exp
            //           | Exp * Exp
            //           | Exp / Exp
            //

            // characters that can appear in a literal
            var digit = new Terminal("0123456789");

            // this is how we refer to literals (which can be either one digit or
            // many digits long)
            var literal = new Nonterminal();

            // this is the base case for literals-- just one digit
            var literalBase = new Reduction(
                args => (int)args[0] - '0',
                digit);

            // this is the recursive case for literals-- a literal in front of
            // another digit
            var literalRec = new Reduction(
                args => 10 * (int)args[0] + (int)args[1] - '0',
                literal, digit);

            // add the actual rules that make up literal; we have to create literal
            // and *then* add to it because literalRec refers to literal, and
            // literal contains literalRec
            literal.Add(literalBase, literalRec);

            // exp is how we refer to any kind of expression (like literal above)
            var expression = new Nonterminal();

            // all the kinds of expressions

            var grouped = new Reduction(
                args => args[1],
                new Terminal('('), expression, new Terminal(')'));

            var add = new Reduction(
                args => new AddExp((Exp)args[0], (Exp)args[2]),
                expression, new Terminal('+'), expression);

            var sub = new Reduction(
                args => new SubExp((Exp)args[0], (Exp)args[2]),
                expression, new Terminal('-'), expression);

            var mul = new Reduction(
                args => new MulExp((Exp)args[0], (Exp)args[2]),
                expression, new Terminal('*'), expression);

            var div = new Reduction(
                args => new DivExp((Exp)args[0], (Exp)args[2]),
                expression, new Terminal('/'), expression);

            var lit = new Reduction(
                args => new LitExp((int)args[0]),
                literal);

            // add all of the kinds of expressions to exp
            expression.Add(grouped, lit, add, sub, mul, div);

            // we need a special start production that ends with Terminal.Eof; it
            // will just return the result of parsing one expression
            var start = new Reduction(
                args => args[0],
                expression, Terminal.Eof);

            // create and return the parser
            return new Parser(start);
        }

        public abstract class Exp
        {
            public abstract int Eval();
        }

        public abstract class BinExp : Exp
        {
            public BinExp(Exp left, Exp right)
            {
                Left = left;
                Right = right;
            }

            public Exp Left { get; }
            public Exp Right { get; }
        }

        public sealed class AddExp : BinExp
        {
            public AddExp(Exp left, Exp right) : base(left, right)
            {
            }

            public override int Eval()
            {
                return Left.Eval() + Right.Eval();
            }

            public override string ToString()
            {
                return string.Format("(+ {0} {1})", Left.ToString(), Right.ToString());
            }
        }

        public sealed class SubExp : BinExp
        {
            public SubExp(Exp left, Exp right) : base(left, right)
            {
            }

            public override int Eval()
            {
                return Left.Eval() - Right.Eval();
            }

            public override string ToString()
            {
                return string.Format("(- {0} {1})", Left.ToString(), Right.ToString());
            }
        }

        public sealed class MulExp : BinExp
        {
            public MulExp(Exp left, Exp right) : base(left, right)
            {
            }

            public override int Eval()
            {
                return Left.Eval() * Right.Eval();
            }

            public override string ToString()
            {
                return string.Format("(* {0} {1})", Left.ToString(), Right.ToString());
            }
        }

        public sealed class DivExp : BinExp
        {
            public DivExp(Exp left, Exp right) : base(left, right)
            {
            }

            public override int Eval()
            {
                return Left.Eval() / Right.Eval();
            }

            public override string ToString()
            {
                return string.Format("(/ {0} {1})", Left.ToString(), Right.ToString());
            }
        }

        public sealed class LitExp : Exp
        {
            public LitExp(int value)
            {
                Value = value;
            }

            public int Value { get; }

            public override int Eval()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
