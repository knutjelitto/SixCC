﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public record Namespace(Annotations Annotations, Identifiers Names) : AstNode;
}
