namespace Six.Ast
{
    public abstract class Grammar<T>
    {
        public Grammar(string name, Func<T, string> getKey)
        {
            Name = name;
            Symbols = new UniqueList<string, T>(getKey);
        }

        public void Add(IEnumerable<T> symbols)
        {
            Symbols.AddRange(symbols);
        }

        public void Add(params T[] symbols)
        {
            Symbols.AddRange(symbols);
        }

        public string Name { get; set; }
        public T this[string name] => Symbols[name];
        public UniqueList<string, T> Symbols { get; }
    }

    public class Grammar : Grammar<Symbol>
    {
        public Grammar(string name)
            : base(name, symbol => symbol.Name)
        {
        }
    }
}
