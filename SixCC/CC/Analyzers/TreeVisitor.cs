using SixCC.CC.Tree;
using System;
using System.Collections.Generic;

namespace SixCC.CC.Analyzers
{
    internal class TreeVisitor
    {
        private readonly Dictionary<Node, object> values = new();

        protected void Set(Node key, object value)
        {
            values[key] = value;
        }

        protected T Get<T>(Node key)
        {
            return (T)values[key];
        }

        protected IEnumerable<T> GetMany<T>(Family familiy)
        {
            foreach (var child in familiy.Children)
            {
                yield return Get<T>(child);
            }
        }

        protected virtual void Visit(Grammar grammar)
        {
            Visit(grammar.Name);
            foreach (var rule in grammar.Rules)
            {
                Visit(rule);
            }
        }

        protected virtual void Visit(Alt expression)
        {
            foreach (var expr in expression.Children)
            {
                Visit(expr);
            }
        }

        protected virtual void Visit(Any expression)
        {
        }

        protected virtual void Visit(Difference expression)
        {
            Visit(expression.Left);
            Visit(expression.Right);
        }

        protected virtual void Visit(Literal expression)
        {
        }

        protected virtual void Visit(Name expression)
        {
        }

        protected virtual void Visit(OneOrMore expression)
        {
            Visit(expression.Expression);
        }

        protected virtual void Visit(Tree.Range expression)
        {
            Visit(expression.Left);
            Visit(expression.Right);
        }

        protected virtual void Visit(Nonterminal rule)
        {
            Visit(rule.Name);
            Visit(rule.Expression);
        }

        protected virtual void Visit(Reference expression)
        {
        }

        protected virtual void Visit(Cat expression)
        {
            foreach (var expr in expression.Children)
            {
                Visit(expr);
            }
        }

        protected virtual void Visit(ZeroOrMore expression)
        {
            Visit(expression.Expression);
        }

        protected virtual void Visit(ZeroOrOne expression)
        {
            Visit(expression.Expression);
        }

        protected virtual void Visit(Complement expression)
        {
            Visit(expression.Expression);
        }

        protected virtual void Visit(Epsilon expression)
        {
        }

        protected void Visit(Expression node)
        {
            switch (node)
            {
                case Alt expression:
                    Visit(expression);
                    break;
                case Any expression:
                    Visit(expression);
                    break;
                case Epsilon expression:
                    Visit(expression);
                    break;
                case Difference expression:
                    Visit(expression);
                    break;
                case Literal expression:
                    Visit(expression);
                    break;
                case Name expression:
                    Visit(expression);
                    break;
                case Tree.Range expression:
                    Visit(expression);
                    break;
                case Nonterminal expression:
                    Visit(expression);
                    break;
                case Reference expression:
                    Visit(expression);
                    break;
                case Cat expression:
                    Visit(expression);
                    break;
                case Complement expression:
                    Visit(expression);
                    break;
                case OneOrMore expression:
                    Visit(expression);
                    break;
                case ZeroOrMore expression:
                    Visit(expression);
                    break;
                case ZeroOrOne expression:
                    Visit(expression);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
