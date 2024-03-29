﻿namespace Six.Runtime.Matchers
{
    public sealed class StartRule : Rule
    {
        public Cursor? Eof { get; private set; }

        public StartRule(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            var matcher = this[0];

            matcher.Match(context.Start, context.Success);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
