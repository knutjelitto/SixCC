namespace Six.Gen.Ebnf
{
    public class EbnfDumper
    {
        public EbnfDumper(EbnfGrammar grammar)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public void Dump(Writer writer)
        {
            writer.WriteLine($"grammar {Grammar.Name}");
            foreach (var rule in Grammar.Rules)
            {
                writer.WriteLine();
                writer.WriteLine($"{rule.Name}{rule.Attributes}");
                using (writer.Indent())
                {
                    rule.Argument.Dump(writer);

                    if (rule.DFA != null)
                    {
                        writer.WriteLine();
                        writer.WriteLine("-- with DFA --");
                        writer.WriteLine();
                        new FaDfaDumper().Dump(writer, rule.DFA);
                    }
                }
            }
            writer.WriteLine();
            writer.WriteLine("keywords:");
            using (writer.Indent())
            {
                foreach (var keyword in Grammar.Keywords)
                {
                    writer.WriteLine($"{keyword}");
                }
            }
        }
    }
}
