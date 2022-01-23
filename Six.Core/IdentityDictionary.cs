﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Six.Core
{
    public class IdentityDictionary<TKey, TValue> : Dictionary<TKey, TValue>
        where TKey : class
    {
        public IdentityDictionary()
            : base(new IdentityEquality<TKey>())
        {
        }
    }
}
