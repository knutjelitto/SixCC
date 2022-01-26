using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class AnnotationList : ReadOnlyList<Annotation>
    {
        public AnnotationList(IEnumerable<Annotation> items) : base(items)
        {
        }
    }
}
