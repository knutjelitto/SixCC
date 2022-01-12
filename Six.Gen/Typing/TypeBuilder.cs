using Six.Gen.Ebnf;

#pragma warning disable CA1822 // Mark members as static

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

        public TypeBuilder(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        private RuleOp? CurrentRule { get; set; }

        public EbnfGrammar Walk()
        {
            foreach (var rule in Grammar.CoreRules)
            {
                SetInterface(rule, rule);
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

            var loops = 4;
            while (loops-- > 0)
            {
                foreach (var rule in Grammar.CoreRules)
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
                SetClassOf(rule, new ClassType(rule.Name));
            }
            else
            {
                Assert(true);
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
                SetClassOf(op, new BaseType(className));
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

        private void SetInterfaceOf(CoreOp op, InterfaceType? iface)
        {
            if (op.Interface == null)
            {
                op.Interface = iface;
            }
            else
            {
                Assert(true);
            }
        }

        private void SetInterface(CoreOp op, RuleOp fromRule)
        {
            if (op.Interface == null)
            {
                if (fromRule.Interface != null)
                {
                    op.Interface = fromRule.Interface;
                }
                else
                {
                    op.Interface = new InterfaceType(fromRule.Name);
                }
            }
            else
            {
                Assert(op.Interface.Name == fromRule.Name);
            }
        }

        private void SetGenericArgument(CoreOp op)
        {
            if (op.Class != null)
            {
                op.Class.Generic = (TypeCore?)op.Arguments[0].Class ?? op.Arguments[0].Interface;
            }
        }

        private void AddInterfaceTo(CoreOp op, InterfaceType? iface)
        {
            if (iface != null && op.Interface != null)
            {
                if (op.Interface.Interfaces.Add(iface))
                {
                }
            }
        }

        private void AddInterfaceFromCurrentTo(CoreOp op)
        {
            if (CurrentRule != null)
            {
                AddInterfaceTo(op, CurrentRule.Interface);
            }
        }

        private bool IsSoleChildOfCurrent()
        {
            return CurrentRule != null && CurrentRule.Arguments.Where(a => a is not NotOp).Count() == 1;
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
                SetClassOf(op, LoopBaseClass);
                SetGenericArgument(op);
                SetBaseOfCurrent(op.Class);

                if (IsSoleChildOfCurrent())
                {
                    Assert(true);
                }
            }
            else
            {
                var notNotArguments = op.Arguments.Where(a => a is not NotOp).ToList();

                if (notNotArguments.Count == 1)
                {
                    SetClassOf(op, notNotArguments[0].Class);
                }
                else
                {
                    SetClassOf(op, SequenceBaseClass);
                }
                SetBaseOfCurrent(op.Class);

                if (IsSoleChildOfCurrent())
                {
                    Assert(true);

                    //op.Class = CurrentRule!.Class;
                    //op.Interface = CurrentRule!.Interface;
                }
            }

        }

        protected override void Visit(AltOp alt)
        {
            WalkInnerArguments(alt);

            if (CurrentRule != null)
            {
                SetInterface(alt, CurrentRule);
                
                foreach (var arg in alt.Arguments)
                {
                    AddInterfaceFromCurrentTo(arg);
                    AddInterfaceTo(arg, CurrentRule.Interface);
                }
            }
        }

        protected override void Visit(StarOp op)
        {
            WalkInnerArguments(op);

            SetClassOf(op, StarBaseClass);
            SetGenericArgument(op);

            SetBaseOfCurrent(op.Class);
        }

        protected override void Visit(PlusOp op)
        {
            SetClassOf(op, PlusBaseClass);

            WalkInnerArguments(op);

            op.Class!.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;

            SetBaseOfCurrent(op.Class);

            if (CurrentRule != null)
            {
                CurrentRule.Base.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;
            }
        }

        protected override void Visit(OptionalOp op)
        {
            WalkInnerArguments(op);

            SetClassOf(op, OptionalBaseClass);
            SetBaseOfCurrent(op.Class);

            if (CurrentRule == null)
            {
                op.Class!.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;
            }
        }

        protected override void Visit(StringOp op)
        {
            SetClassOf(op, StringBaseClass);

            SetBaseOfCurrent(op.Class);
        }

        protected override void Visit(TokenOp op)
        {
            SetClassOf(op, StringBaseClass);

            SetBaseOfCurrent(op.Class);
        }
    }
}
