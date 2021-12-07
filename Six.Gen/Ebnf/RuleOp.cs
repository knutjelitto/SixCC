﻿using Six.Rex;

namespace Six.Gen.Ebnf
{
    public class RuleOp : CoreOp
    {
        public RuleOp(string name, ILocation location, CoreOp argument)
            : base(location, argument)
        {
            Name = name;
        }

        public RuleOp(string name, ILocation location)
            : base(location)
        {
            Name = name;
        }

        public void Set(ILocation location, CoreOp argument)
        {
            Patch(location);
            Patch(argument);
        }

        public string Name { get; }
        public FA? DFA { get; set; }

        protected override string DumpHead => Name;
    }
}
