﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public abstract class I32 : Integral
    {
        public override string AsWasm => $"i32";
    }
}
