using SixCC.Runtime.Sources;
using SixCC.Runtime.Structures;
using SixCC.Writing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.CC.Errors
{
    public class SyntaxError : Error
    {
        public SyntaxError(ILocation location, string message)
        {
            Location = location;
            Message = message;
        }

        public ILocation Location { get; }
        public string Message { get; }

        public override void Report(Writer writer)
        {
            var (line, column) = Location.Source.GetLineAndColumn(Location.Offset);
            writer.WriteLine($"@({line},{column}): {Message}");
        }
    }
}
