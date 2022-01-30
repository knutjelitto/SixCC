using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public record Unit(
        ImportList Imports1,
        Namespace Namespace,
        ImportList Imports2,
        DeclarationList Declarations);
}
