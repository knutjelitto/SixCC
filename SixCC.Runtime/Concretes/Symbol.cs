﻿using System;

using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Concretes
{
    public class Symbol : ISymbol
    {
        public Symbol(int id, string name, bool visible)
        {
            Id = id;
            Name = name;
            Visible = visible;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Visible { get; }

        public override String ToString()
        {
            return Name;
        }
    }
}
