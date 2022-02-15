using A = Six.Sax.Ast;

namespace Six.Sax.Sema
{
    public interface Entity
    {
        public bool IsShared => this.IsShared();
        public bool IsNative => this.IsNative();

        A.TreeNode Ast { get; }
        Container Container { get; }
        //public string Name => (Ast is A.With.Name named) ? named.Name.Text : "--no-name--";
    }
}
