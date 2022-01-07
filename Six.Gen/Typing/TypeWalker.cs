using Six.Gen.Ebnf;

namespace Six.Gen.Typing
{
    public class TypeWalker : EbnfWalker
    {
        private const string SequenceBaseClass = "Sequence";
        private const string LoopBaseClass = "Loop";
        private const string StarBaseClass = "Star";
        private const string PlusBaseClass = "Plus";

        public TypeWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }
        public bool Changed { get; set; }

        private RuleOp? CurrentRule { get; set; }

        public EbnfGrammar Walk()
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                foreach (var rule in Grammar.Rules.OfType<RuleOp>())
                {
                    if (rule.Name.StartsWith("%"))
                    {
                        continue;
                    }
                    Walk(rule);
                }
            }

            return Grammar;
        }

        private void SetClass(CoreOp op, RuleOp fromRule)
        {
            if (op.Class == null)
            {
                op.Class = new ClassType(fromRule.Name);
                Changed = true;
            }
            else
            {
                Assert(op.Class.Name == fromRule.Name);
            }
        }

        private void SetBase(CoreOp op, string baseName)
        {
            Assert(op.Class != null);
            //Assert(op.Class!.Base == null);
            op.Class!.Base = new BaseType(baseName);
        }

        private void SetInterface(CoreOp op, RuleOp fromRule)
        {
            if (op.Interface == null)
            {
                op.Interface = new InterfaceType(fromRule.Name);
                Changed = true;
            }
            else
            {
                Assert(op.Interface.Name == fromRule.Name);
            }
        }

        private InterfaceType? GetInterface(CoreOp coreOp)
        {
            if (coreOp is RefOp refOp)
            {
                return refOp.Rule.Interface;
            }
            return coreOp.Interface;
        }

        protected override void Visit(RuleOp op)
        {
            CurrentRule = op;
            SetInterface(op, CurrentRule);
            WalkArguments(op);
            CurrentRule = null;
        }

        protected override void Visit(RefOp op)
        {
            if (CurrentRule != null)
            {
                SetInterface(CurrentRule, CurrentRule);

                var inner = GetInterface(op.Rule);
                if (inner != null)
                {
                    CurrentRule.Interface!.Interfaces.Add(inner);
                }
            }
        }

        protected override void Visit(StringOp op)
        {
            if (CurrentRule != null)
            {
                //SetClass(op, CurrentRule);
            }
        }

        protected override void Visit(TokenOp op)
        {
            if (CurrentRule != null)
            {
                SetClass(CurrentRule, CurrentRule);
            }
        }

        protected override void Visit(SeqOp op)
        {
            if (CurrentRule != null)
            {
                SetClass(CurrentRule, CurrentRule);
                if (op.IsLoop)
                {
                    SetBase(CurrentRule, LoopBaseClass);

                    var inner = GetInterface(op.Arguments[0]);
                    if (inner != null)
                    {
                        CurrentRule.Base.Generics.Add(inner);
                    }
                }
                else
                {
                    SetBase(CurrentRule, SequenceBaseClass);
                }
            }
        }

        protected override void Visit(AltOp alt)
        {
            if (CurrentRule != null)
            {
                SetInterface(CurrentRule, CurrentRule);

                WalkArguments(alt);

                foreach (var arg in alt.Arguments)
                {
                    var inner = GetInterface(arg);

                    if (inner != null)
                    {
                        CurrentRule.Interface!.Interfaces.Add(inner);
                    }
                }
            }
        }

        protected override void Visit(StarOp op)
        {
            if (CurrentRule != null)
            {
                SetClass(CurrentRule, CurrentRule);
                SetBase(CurrentRule, StarBaseClass);

                var inner = GetInterface(op.Argument);
                if (inner != null)
                {
                    CurrentRule.Base.Generics.Add(inner);
                }
            }
        }

        protected override void Visit(PlusOp op)
        {
            if (CurrentRule != null)
            {
                SetClass(CurrentRule, CurrentRule);
                SetBase(CurrentRule, PlusBaseClass);

                var inner = GetInterface(op.Argument);
                if (inner != null)
                {
                    CurrentRule.Base.Generics.Add(inner);
                }
            }
        }
    }
}
