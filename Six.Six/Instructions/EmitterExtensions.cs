﻿using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public static class EmitterExtensions
    {
        public static IEnumerable<Decl.Funcy> InnerFunctions(this Decl.Funcy funcy)
        {
            foreach (var function in funcy.Functions)
            {
                foreach (var inner in function.InnerFunctions())
                {
                    yield return inner;
                }

                yield return function;
            }
        }

        public static ClassLayout.Slot? Slot(this Decl.Classy classy, string name)
        {
            return classy.Layout.Slots.Where(s => s.Name == name).SingleOrDefault();
        }
    }
}
