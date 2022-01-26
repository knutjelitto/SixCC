using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Annotations
    {
        public Annotations(String? doc, IEnumerable<Annotation> annotations)
        {
            Doc = doc;
            Items = new AnnotationList(annotations);
        }

        public String? Doc { get; }
        public AnnotationList Items { get; }
    }
}
