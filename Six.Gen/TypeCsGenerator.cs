using Six.Gen.Ebnf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Six.Gen
{
    public class TypeCsGenerator : CsGenerator
    {
        public TypeCsGenerator(Writer writer, EbnfGrammar grammar) : base(writer)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public void Generate()
        {
            foreach (var rule in Grammar.CoreRules)
            {
                if (rule.Interface == null)
                {
                    continue;
                }
                var ifaces = string.Empty;
                if (rule.Interface.Interfaces.Count > 0)
                {
                    ifaces = $" : {rule.Interface.InterfaceNames}";
                }
                wl($"public interface {rule.Interface.TypeName}{ifaces} {{}}");
            }
            wl();
            foreach (var rule in Grammar.CoreRules)
            {
                if (rule.Class == null)
                {
                    continue;
                }
                var ifaces = string.Empty;
                if (rule.Class.Base != null || rule.Interface != null)
                {
                    ifaces = " : ";
                    if (rule.Class.Base != null)
                    {
                        ifaces = $"{ifaces}{rule.Class.BaseName}";
                        if (rule.Interface != null)
                        {
                            ifaces = $"{ifaces}, ";
                        }
                    }
                    if (rule.Interface != null)
                    {
                        ifaces = $"{ifaces}{rule.Interface.TypeName}";
                    }
                }
                wl($"public partial class {rule.Class.TypeName}{ifaces} {{}}");
            }
        }
    }
}
