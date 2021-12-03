using System;

using SixCC.Sdk.Grammars;
using SixCC.Sdk.LR;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Dumping
{
    public class SetDumper
    {
        public SetDumper(Grammar grammar)
        {
            Grammar = grammar;
        }

        public Grammar Grammar { get; }

        public void Dump(IWriter writer)
        {
            DumpLR1Sets(writer);
        }

        private void DumpLR1Sets(IWriter writer)
        {
            var namesLength = 0;
            var bodyLength = 0;
            var actionLeft = 0;
            var actionRight = (int)Math.Log10(Grammar.LR1Sets.Count) + 1;
            var productions = (int)Math.Log10(Grammar.Productions.Count) + 1;

            foreach (var set in Grammar.LR1Sets)
            {
                for (var i = 0; i < set.Count; ++i)
                {
                    namesLength = Math.Max(namesLength, set[i].Core.LHStoString().Length);
                    bodyLength = Math.Max(bodyLength, set[i].Core.RHStoString().Length);

                    if (!set[i].IsComplete)
                    {
                        actionLeft = Math.Max(actionLeft, set[i].PostDot.ToString().Length);
                    }
                }
            }

            var namesFormat = $"{{0,-{namesLength}}}";
            var bodyFormat = $"{{0,-{bodyLength}}}";
            var aleftFormat = $"{{0,-{actionLeft}}}";
            var arightFormat = $"i{{0,-{actionRight}}}";
            var prodFormat = $"{{0}}";

            foreach (var set in Grammar.LR1Sets)
            {
                writer.WriteLine($"{set}");

                for (var i = 0; i < set.Count; ++i)
                {
                    var name = string.Format(namesFormat, set[i].Core.LHStoString());
                    var body = string.Format(bodyFormat, set[i].Core.RHStoString());
                    var kernel = set[i].InKernel ? "k" : " ";
                    writer.WriteLine($"    [{name} -> {body} ]{kernel}  {Action(set[i])} {set[i].Lookahead}");
                }
            }

            string Action(LR1 item)
            {
                if (item.IsComplete)
                {
                    var idlength = (int)Math.Log10(item.Core.Production.Id == 0 ? 1 : item.Core.Production.Id) + 1;
                    var spaces = Math.Max(0, actionLeft + actionRight - 4 - idlength);
                    var id = string.Format(prodFormat, item.Core.Production.Id);
                    return $"(reduce«{id}»{new string(' ', spaces)})";
                }
                else
                {
                    var left = string.Format(aleftFormat, item.PostDot);
                    var right = string.Format(arightFormat, item.ToState);
                    return $"({left} , {right})";
                }
            }
        }

    }
}
