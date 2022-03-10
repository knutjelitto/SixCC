﻿using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public abstract class I32 : Integral
    {
        protected I32(string name) : base(name) { }

        public override string AsWasm => $"i32";
    }
}
