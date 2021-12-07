﻿namespace Six.Runtime.Matchers
{
    public record Optional(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            Matchers[0].Match(context.Start,
                success =>
                {
                    // bail out nullables
                    if (success > context.Start)
                    {
                        context.Success(success);
                    }
                });

            context.Success(context.Start);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
