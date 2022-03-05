using Six.Core;
using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime
{
    public class RuntimeLocation : ILocation
    {
        public RuntimeLocation(Source source, int offset, int lenght)
        {
            Source = source;
            Offset = offset;
            Length = lenght;
        }

        public Source Source { get; }

        public int Offset { get; }

        public int Length { get; }

        public static ILocation From(IRNode node)
        {
            if (node is IRLocated token)
            {
                return new RuntimeLocation(token.Source, token.Core, token.End - token.Core);
            }

            Assert(node.Children.Length > 0);

            return From(node.Children[0]);
        }

        public string GetText()
        {
            return Source.GetText(Offset, Length);
        }

        public override string ToString()
        {
            return Source.NameLineColumn(Offset);
        }
    }
}
