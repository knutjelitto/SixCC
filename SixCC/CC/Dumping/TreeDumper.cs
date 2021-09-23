using SixCC.CC.Tree;
using SixCC.Writing;
using System;

namespace SixCC.CC.Dumping
{
    internal static class TreeDumper
    {
        public static void Dump(Writer writer, Grammar grammar)
        {
            Print(grammar, false, Array.Empty<bool>());

            void Print(Node node, bool more, bool[] crossings)
            {
                for (int i = 0; i < crossings.Length - 1; i++)
                {
                    writer.Write(crossings[i] ? "| " : "  ");
                }
                if (crossings.Length > 0)
                {
                    if (more)
                    {
                        writer.Write("├─› ");
                    }
                    else
                    {
                        writer.Write("└─› ");
                    }
                }
                writer.WriteLine(node.Head);
                if (node is Family family)
                {
                    for (int i = 0; i < family.Count; i++)
                    {
                        bool[] childCrossings = new bool[crossings.Length + 1];
                        Array.Copy(crossings, childCrossings, crossings.Length);
                        childCrossings[^1] = i < family.Count - 1;
                        Print(family[i], i < family.Count - 1, childCrossings);
                    }
                }
            }
        }
    }
}
