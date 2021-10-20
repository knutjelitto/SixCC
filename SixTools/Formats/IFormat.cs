using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTools.Formats
{
    public interface IFormat
    {
        void Format();
        string PreferedExtension { get; }
    }
}
