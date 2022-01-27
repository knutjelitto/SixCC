﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Variable
    {
        public Variable(Identifier name, IExpression? value)
        {
            Name = name;
            Value = value;
        }

        public Identifier Name { get; }
        public IExpression? Value { get; }
    }
}
