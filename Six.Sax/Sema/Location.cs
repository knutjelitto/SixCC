﻿using Six.Core;
using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Sema
{
    public class Location : ILocation
    {
        private Location(RToken token)
        {
            Token = token;
        }

        public RToken Token { get; }

        public Source Source => Token.Source;

        public int Offset => Token.Core;

        public int Length => Token.End - Token.Core;

        public static Location From(IRNode node)
        {
            if (node is RToken token)
            {
                return new Location(token);
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
            return Token.Source.NameLineColumn(Token.Core);
        }
    }
}
