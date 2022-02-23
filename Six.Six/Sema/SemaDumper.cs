using Six.Core;
using Six.Runtime;

using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class SemaDumper : WithWriter
    {
        public SemaDumper(Writer writer, Resolver resolver)
            : base(writer)
        {
            Resolver = resolver;
        }

        public Resolver Resolver { get; }

        public void DumpDeclaration(Decl decl)
        {
            Walk(decl, true);
        }

        private void Walk(Member member, bool complex)
        {
            Visit((dynamic)member, complex);
        }

        private void WalkMany(IEnumerable<Member> members, bool complex)
        {
            foreach (var member in members)
            {
                Walk(member, complex);
            }
        }

        private void Visit(Decl decl, bool complex)
        {
            wl(Name(decl.ADecl));
            if (!complex)
            {
                return;
            }

            indent(() =>
            {
                if (decl.Container is ContentScope content)
                {
                    if (content.Members.Count > 0)
                    {
                        wl("declarations");
                        indent(() =>
                        {
                            WalkMany(content.Members, false);
                        });
                    }
                    if (content.Content.Members.Count > 0)
                    {
                        wl("content");
                        indent(() =>
                        {
                            WalkMany(content.Content.Members, true);
                        });
                    }
                }
            });
        }

        private void Visit(Stmt stmt, bool complex)
        {
            wl(Name(stmt.AStmt));
        }

        private string Name(A.TreeNode node)
        {
            var prefix = "";
            if (node is A.Stmt)
            {
                prefix = "Stmt::";
            }
            else if (node is A.Decl)
            {
                prefix = "Decl::";
            }
            else if (node is A.Expression)
            {
                prefix = "Expr::";
            }
            else
            {
                Assert(false);
            }
            var name = node is A.With.Name named ? $" {named.Name.Text}" : "";
            return $"{prefix}{node.GetType().Name.ToLowerInvariant()}{name}";
        }
    }
}
