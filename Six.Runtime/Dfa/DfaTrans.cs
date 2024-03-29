﻿namespace Six.Runtime.Dfa
{
    public struct DfaTrans
    {
        public readonly DfaState Target;
        public readonly DfaSet Set;

        public DfaTrans(DfaState target, DfaSet set)
        {
            Target = target;
            Set = set;
        }

        public DfaTrans(DfaState target, params DfaInterval[] intervals)
        {
            Target = target;
            Set = new DfaSet(intervals);
        }

        public override string ToString()
        {
            return $"{Set}->{Target.Id}";
        }
    }
}
