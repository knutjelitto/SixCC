using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime
{
    public class CursorSet : SortedSet<Cursor>
    {
        public override string ToString()
        {
            return string.Join(',', this.Select(x => x.Offset));
        }
    }
}
