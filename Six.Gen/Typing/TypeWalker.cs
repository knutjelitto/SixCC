using Six.Gen.Ebnf;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Gen.Typing
{
    public class TypeWalker : EbnfWalker
    {
        private const string SequenceBaseClass = "Sequence";
        private const string LoopBaseClass = "Loop";
        private const string StarBaseClass = "Star";
        private const string PlusBaseClass = "Plus";
        private const string StringBaseClass = "String";
        private const string OptionalBaseClass = "Optional";

        public TypeWalker(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }
        public bool Changed { get; set; }

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
                        SetClass(rule, rule);
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

        private void SetClass(CoreOp op, ClassType classType)
        {
            if (op.Class == null)
            {
                op.Class = classType;
                Changed = true;
            }
            else
            {
                Assert(op.Class.Name == classType.Name);
            }
        }

        private void SetClass(CoreOp op, RuleOp fromRule)
        {
            SetClass(op, new ClassType(fromRule.Name));
        }

        private void SetClass(CoreOp op, string className, CoreOp? genericArgument = null)
        {
            if (op.Class == null)
            {
                op.Class = new BaseType(className);
                Changed = true;
            }
            else
            {
                Assert(op.Class.Name == className);
            }
        }

        private void SetBase(string baseName)
        {
            if (CurrentRule != null)
            {
                CurrentRule.Class!.Base = new BaseType(baseName);
            }
        }

        private void SetBase(ClassType baseType)
        {
            if (CurrentRule != null)
            {
                CurrentRule.Class!.Base = baseType;
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
                Changed = true;
            }
            else
            {
                Assert(op.Interface.Name == fromRule.Name);
            }
        }

        private void AddInterface(CoreOp op, InterfaceType? iface)
        {
            if (iface != null && op.Interface != null)
            {
                if (op.Interface.Interfaces.Add(iface))
                {
                    Changed = true;
                }
            }
        }

        private void AddCurrentInterface(CoreOp op)
        {
            if (CurrentRule != null)
            {
                AddInterface(op, CurrentRule.Interface);
            }
        }

        private TypeCore? GetClassOrInterface(CoreOp coreOp)
        {
            if (coreOp is RefOp refOp)
            {
                return (TypeCore?)refOp.Rule.Class ?? refOp.Rule.Interface;
            }
            return (TypeCore?)coreOp.Class ?? coreOp.Interface;
        }

        private void WalkInnerArguments(CoreOp op)
        {
            var savedCurrentRule = CurrentRule;
            CurrentRule = null;
            WalkArguments(op);
            CurrentRule = savedCurrentRule;
        }

        protected override void Visit(RuleOp op)
        {
            CurrentRule = op;
            
            WalkArguments(op);
            
            CurrentRule = null;
        }

        protected override void Visit(RefOp op)
        {
            SetInterface(op, op.Rule);

            AddCurrentInterface(op.Rule);
        }

        protected override void Visit(SeqOp op)
        {
            WalkInnerArguments(op);

            if (op.IsLoop)
            {
                SetClass(op, LoopBaseClass);

                op.Class!.Generic = (TypeCore?)op.Arguments[0].Class ?? op.Arguments[0].Interface;
            }
            else
            {
                var realArguments = op.Arguments.Where(a => a is not NotOp).ToList();

                if (realArguments.Count == 1)
                {
                    SetClass(op, realArguments[0].Class!);
                }
                else
                {
                    SetClass(op, SequenceBaseClass);
                }
            }

            SetBase(op.Class!);
        }

        protected override void Visit(AltOp alt)
        {
            WalkInnerArguments(alt);

            if (CurrentRule != null)
            {
                SetInterface(alt, CurrentRule);
                
                foreach (var arg in alt.Arguments)
                {
                    AddCurrentInterface(arg);
                    AddInterface(arg, CurrentRule.Interface);
                }
            }
        }

        protected override void Visit(StarOp op)
        {
            SetClass(op, StarBaseClass);

            WalkInnerArguments(op);

            op.Class!.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;

            SetBase(op.Class!);
        }

        protected override void Visit(PlusOp op)
        {
            SetBase(PlusBaseClass);

            SetClass(op, PlusBaseClass);

            WalkInnerArguments(op);

            op.Class!.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;

            if (CurrentRule != null)
            {
                CurrentRule.Base.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;
            }
        }

        protected override void Visit(OptionalOp op)
        {
            WalkInnerArguments(op);

            SetClass(op, OptionalBaseClass);
            SetBase(op.Class!);

            if (CurrentRule == null)
            {
                op.Class!.Generic = (TypeCore?)op.Argument.Class ?? op.Argument.Interface;
            }
        }

        protected override void Visit(StringOp op)
        {
            SetClass(op, StringBaseClass);

            SetBase(op.Class!);
        }

        protected override void Visit(TokenOp op)
        {
            SetClass(op, StringBaseClass);

            SetBase(op.Class!);
        }
    }
}
