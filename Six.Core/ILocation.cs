using System;
using System.Collections.Generic;
using System.Text;

namespace Six.Core
{
    public interface ILocation
    {
        ISource Source { get; }
        int Offset { get; }
        int Length { get; }

        string GetText();
    }
}
