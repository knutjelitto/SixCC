﻿using SixCC.Runtime.Parsing;
using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Runtime.Structures
{
    public interface IStateItem
    {
        ParseAction Action { get; }
        int Number { get; }
        int Coded { get; }
    }
}
