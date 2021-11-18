﻿using Six.Core;

namespace Six.Input.Errors
{
    public abstract class Diagnostic
    {
        public Diagnostic(Level level)
        {
            Level = level;
        }

        public Level Level { get; }

        public abstract void Report(Writer writer);
    }
}
