using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Declaration : Entity
    {
        A.Declaration Ast { get; }
        Container Content { get; }

        public bool IsShared => this.IsShared();
        public bool IsNative => this.IsNative();

        public static Declaration New(A.Declaration declaration, Container content)
        {
            return new Impl(declaration, content);
        }

        private sealed record Impl(A.Declaration Ast, Container Content) : Declaration;
    }
}
