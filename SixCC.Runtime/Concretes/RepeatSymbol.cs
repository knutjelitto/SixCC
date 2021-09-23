using System;
using System.Collections.Generic;
using System.Text;

using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class RepeatSymbol : ISymbol
    {
        public static readonly RepeatSymbol Option = new RepeatSymbol(-1, "$?$");
        public static readonly RepeatSymbol Star = new RepeatSymbol(-1, "$*$");
        public static readonly RepeatSymbol Plus = new RepeatSymbol(-1, "$+$");

        private RepeatSymbol(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
