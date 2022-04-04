using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public static class EmitterExtensions
    {
        public static IEnumerable<Decl.Funcy> InnerFunctions(this Decl.Funcy function)
        {
            foreach (var funcy in function.Block.Members.OfType<Decl.Funcy>())
            {
                foreach (var inner in funcy.InnerFunctions())
                {
                    yield return inner;
                }

                yield return funcy;
            }
        }

        public static ClassLayout.DispatchSlot? Slot(this Decl.Classy classy, Decl.Funcy funcy)
        {
            return classy.Layout.Slots.Where(s => s.Funcy.Name == funcy.Name).SingleOrDefault();
        }
    }
}
