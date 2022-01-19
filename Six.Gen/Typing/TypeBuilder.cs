using Six.Gen.Ebnf;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0057 // Use range operator

namespace Six.Gen.Typing
{
    public class TypeBuilder : EbnfWalker
    {
        private const string SequenceBaseClass = "Sequence";
        private const string LoopBaseClass = "Loop";
        private const string StarBaseClass = "Star";
        private const string PlusBaseClass = "Plus";
        private const string OptionalBaseClass = "Optional";
        private const string StringBaseClass = "String";
        private const string TokenBaseClass = "String";
        private const string EofBaseClass = "Eof";
        private const string NotBaseClass = "Not";

        public TypeBuilder(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        private RuleOp? CurrentRule { get; set; }

        public EbnfGrammar Walk()
        {
            foreach (var rule in Grammar.Rules)
            {
                InitInterface(rule);
                switch (rule.Argument)
                {
                    case AltOp:
                    case RefOp:
                        break;
                    default:
                        InitClass(rule);
                        break;
                }
            }

            var loops = 5;
            while (loops-- > 0)
            {
                foreach (var rule in Grammar.Rules)
                {
                    Walk(rule);
                }
            }

            return Grammar;
        }

        private void InitClass(RuleOp rule)
        {
            if (rule.Class == null)
            {
                if (rule.IsSpecial)
                {
                    rule.Class = new ClassType("x-" + rule.Name.Substring(1));
                }
                else
                {
                    rule.Class = new ClassType(rule.Name);
                }
            }
            else
            {
                Assert(false);
            }
        }


        private void InitInterface(RuleOp rule)
        {
            if (rule.Interface == null)
            {
                if (rule.IsSpecial)
                {
                    rule.Interface = new InterfaceType("x-" + rule.Name.Substring(1));
                }
                else
                {
                    rule.Interface = new InterfaceType(rule.Name);
                }
            }
            else
            {
                Assert(false);
            }
        }

        private void SetClassOf(CoreOp op, ClassType? classType)
        {
            if (op.Class == null)
            {
                op.Class = classType;
            }
            else
            {
                Assert(true);
            }
        }

        private void SetClassOf(CoreOp op, string className)
        {
            if (op.Class == null)
            {
                SetClassOf(op, new RuntimeType(className));
            }
            else
            {
                Assert(true);
            }
        }

        private void SetGenericClassOf(CoreOp op, string className)
        {
            if (op.Class == null)
            {
                SetClassOf(op, new RuntimeType(className));
                op.Class!.Generic = (TypeCore?)op.Arguments[0].Class ?? op.Arguments[0].Interface;
            }
            else
            {
                Assert(true);
            }
        }

        private void SetBaseOfCurrent(ClassType? baseType)
        {
            if (CurrentRule != null && CurrentRule.Class != null)
            {
                CurrentRule.Class.Base = baseType;
            }
        }

        private void SetInterfaceOf(CoreOp op, InterfaceType? @interface)
        {
            if (op.Interface == null)
            {
                op.Interface = @interface;
            }
            else
            {
                Assert(true);
            }
        }

        private void SetInterfaceFromCurrentTo(CoreOp op)
        {
            if (op.Interface == null && CurrentRule != null)
            {
                Assert(CurrentRule.Interface != null);

                op.Interface = CurrentRule.Interface;
            }
            else
            {
                Assert(true);
            }
        }

        private void AddInterfaceTo(CoreOp op, InterfaceType? @interface)
        {
            if (@interface != null && op.Interface != null)
            {
                op.Interface.Interfaces.Add(@interface);
            }
        }

        private void AddInterfaceFromCurrentTo(CoreOp op)
        {
            if (CurrentRule != null)
            {
                AddInterfaceTo(op, CurrentRule.Interface);
            }
        }

        private void SetOuterFromCurrent(CoreOp op)
        {
            if (CurrentRule != null)
            {
                CurrentRule.WithInner = true;
                op.Outer = CurrentRule.Class;
            }
        }

        private void WalkInnerArguments(CoreOp op)
        {
            var savedCurrentRule = CurrentRule;
            CurrentRule = null;
            WalkArguments(op);
            CurrentRule = savedCurrentRule;
        }

        protected override void Visit(RuleOp rule)
        {
            CurrentRule = rule;            
            WalkArguments(rule);            
            CurrentRule = null;
        }

        protected override void Visit(RefOp op)
        {
            SetInterfaceOf(op, op.Rule.Interface);
            SetClassOf(op, op.Rule.Class);

            AddInterfaceFromCurrentTo(op.Rule);
        }

        protected override void Visit(SeqOp op)
        {
            WalkInnerArguments(op);

            if (op.IsLoop)
            {
                SetGenericClassOf(op, LoopBaseClass);
            }
            else
            {
                SetClassOf(op, SequenceBaseClass);
            }
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(AltOp alt)
        {
            WalkInnerArguments(alt);

            SetInterfaceFromCurrentTo(alt);

            if (alt.Arguments.All(a => a.Class != null && a.Class!.Name == StringBaseClass))
            {
                if (CurrentRule != null)
                {
                    if (CurrentRule.Class == null)
                    {
                        Assert(CurrentRule.Interface != null);

                        CurrentRule.Class = new ClassType(CurrentRule.Interface!.Name)
                        {
                            Base = new RuntimeType(StringBaseClass)
                        };
                    }
                    else
                    {
                        Assert(CurrentRule.Interface != null);

                        Assert(CurrentRule.Class.Name == CurrentRule.Interface!.Name);
                    }
                }
            }

            foreach (var arg in alt.Arguments)
            {
                AddInterfaceFromCurrentTo(arg);
            }
        }

        protected override void Visit(StarOp op)
        {
            WalkInnerArguments(op);

            SetGenericClassOf(op, StarBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(PlusOp op)
        {
            WalkInnerArguments(op);

            SetGenericClassOf(op, PlusBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(OptionalOp op)
        {
            WalkInnerArguments(op);

            SetGenericClassOf(op, OptionalBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(NotOp op)
        {
            WalkInnerArguments(op);

            SetGenericClassOf(op, NotBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(StringOp op)
        {
            SetClassOf(op, StringBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(TokenOp op)
        {
            SetClassOf(op, TokenBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }

        protected override void Visit(EofOp op)
        {
            SetClassOf(op, EofBaseClass);
            SetBaseOfCurrent(op.Class);
            SetOuterFromCurrent(op);
        }
    }
}
