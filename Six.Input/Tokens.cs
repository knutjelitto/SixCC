using System.Collections.Generic;

namespace Six.Input
{
    internal class Tokens
    {
        private readonly Lexer lexer;
        private readonly List<Token> buffer;

        public Tokens(Lexer lexer)
        {
            this.lexer = lexer;
            this.buffer = new List<Token>();
        }

        public Token this[int index] => Ensure(index);

        private Token Ensure(int index)
        {
            while (buffer.Count <= index)
            {
                buffer.Add(lexer.GetNext());
            }
            return buffer[index];
        }
    }
}
