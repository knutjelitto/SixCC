using Hime.Redist;
using SixCc.Hime;
using SixCC.Sdk.Grammars;
using SixCC.Sdk.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SixCC.Hime
{
    public class LinguVisitor : LinguParser.Visitor
    {
        private Dictionary<ASTNode, object> values = new();
        private RawGrammar? grammar;

        private void Set(ASTNode node, object value)
        {
            values[node] = value;
        }

        private T Get<T>(ASTNode node)
        {
            return (T)values[node];
        }

        private List<T> GetList<T>(ASTNode node)
        {
            return node.Children.Select(node => Get<T>(node)).ToList();
        }

        private void Lift(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 1);
            Set(node, Get<object>(node.Children[0]));
        }

        public RawGrammar Visit(ParseResult result)
        {
            grammar = null;
            LinguParser.Visit(result, this);
            return grammar!;
        }

        public override void OnVariableGrammarOptions(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 4);
            Set(node, GetList<Option>(node.Children[2]));
        }
        public override void OnVariableOption(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 4);
            Set(node, new Option(node.Children[0].Value, node.Children[2].Value));
        }

        public override void OnTerminalBlockComment(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalInteger(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalLiteralAny(ASTNode node)
        {
            Debug.Assert(node.SymbolType == SymbolType.Terminal);
            Set(node, new Any());
        }

        public override void OnTerminalLiteralText(ASTNode node)
        {
            Debug.Assert(node.SymbolType == SymbolType.Terminal);
            Set(node, new Sdk.Tree.String(node.Value));
        }

        public override void OnTerminalName(ASTNode node)
        {
            Set(node, new Name(node.Value));
        }

        public override void OnTerminalSpace(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalUnicodeBlock(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalUnicodeCategory(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalUnicodeCodepoint(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableCfGrammar(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 5);
            var name = Get<Name>(node.Children[1]).Text;
            var items = GetList<IEnumerable<Sdk.Grammars.Symbol>>(node.Children[3]);
            var grammar = new RawGrammar(name);
            foreach (var item in items)
            {
                grammar.Add(item);
            }
            Set(node, grammar);
        }

        public override void OnVariableCharacter(ASTNode node)
        {
            Lift(node);
        }

        public override void OnVariableFile(ASTNode node)
        {
            grammar = Get<RawGrammar>(node.Children[0]);
        }

        public override void OnVariableGrammarItem(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 1);
            Lift(node);
        }

        public override void OnVariableGrammarRules(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 4);
            Set(node, GetList<NonterminalRule>(node.Children[2]));
        }


        public override void OnVariableRange(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 3);
            Set(node, new Sdk.Tree.Range(Get<IExpression>(node.Children[0]), Get<IExpression>(node.Children[2])));
        }

        public override void OnVariableReference(ASTNode node)
        {
            Lift(node);
        }

        public override void OnVariableRule(ASTNode node)
        {
            Debug.Assert(node.Children.Count == 4);
            Set(node, NonterminalRule.From(Get<Name>(node.Children[0]).Text, Get<IExpression>(node.Children[2])));
        }

        public override void OnVariableRuleAlternative(ASTNode node)
        {
            if (node.Children.Count == 1)
            {
                Lift(node);
            }
            else
            {
                Debug.Assert(node.Children.Count == 3);
                Set(node, new Difference(Get<IExpression>(node.Children[0]), Get<IExpression>(node.Children[2])));
            }
        }

        public override void OnVariableRuleAtom(ASTNode node)
        {
            Lift(node);
        }

        public override void OnVariableRuleElement(ASTNode node)
        {
            if (node.Children.Count == 1)
            {
                Lift(node);
            }
            else
            {
                Debug.Assert(node.Children.Count == 3);
                Set(node, Get<IExpression>(node.Children[1]));
            }
        }

        public override void OnVariableRuleExpression(ASTNode node)
        {
            if (node.Children.Count == 1)
            {
                Lift(node);
            }
            else
            {
                Debug.Assert(node.Children.Count % 2 == 1);
                var accu = new List<IExpression>();
                for (var i = 0; i < node.Children.Count; i += 2)
                {
                    accu.Add(Get<IExpression>(node.Children[i]));
                }
                Set(node, new Alternates(accu));
            }
        }

        public override void OnVariableRuleRepetition(ASTNode node)
        {
            if (node.Children.Count == 1)
            {
                Lift(node);
            }
            else
            {
                Debug.Assert(node.Children.Count == 2);
                var expression = Get<IExpression>(node.Children[0]);
                switch (node.Children[1].Value)
                {
                    case "?":
                        Set(node, Repeat.Optional(expression));
                        break;
                    case "*":
                        Set(node, Repeat.Star(expression));
                        break;
                    case "+":
                        Set(node, Repeat.Plus(expression));
                        break;
                }
            }
        }

        public override void OnVariableRuleSequence(ASTNode node)
        {
            if (node.Children.Count == 1)
            {
                Lift(node);
            }
            else
            {
                Set(node, new Sequence(GetList<IExpression>(node)));
            }
        }

        public override void OnVariableRuleSub(ASTNode node)
        {
            Debug.Assert(false);
        }


        public override void OnVariableRuleNot(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableString(ASTNode node)
        {
            Lift(node);
        }
    }
}
