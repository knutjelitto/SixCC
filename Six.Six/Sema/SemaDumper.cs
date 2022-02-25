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

        private void Walk(Entity member, bool complex)
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

        private string TypeProp(Type? type)
        {
            if (type == null) return string.Empty;

            switch (type)
            {
                case Type.Reference node:
                    return $"{Name(node.Decl)} ({node.GetType().Name}{Ref(node.Decl)})";
                case Type.Callable node:
                    return $"{Name(node.Decl)} ({node.GetType().Name}{Ref(node.Decl)})";
                default:
                    Assert(false);
                    return string.Empty;
            }
        }

        private string Head(string text)
        {
            const int nameWidth = -12;

            return $"{text, nameWidth}:";
        }

        private void TypeProp(string name, Type? type)
        {
            if (type == null) return;

            w($"{Head(name)}{TypeProp(type)}");
            var resolvedType = Resolver.ResolveType(type);
            if (resolvedType != null)
            {
                if (!ReferenceEquals(type.Decl, resolvedType.Decl))
                {
                    w($" =>{TypeProp(resolvedType) }");
                }
            }
            wl();

            switch (type)
            {
                case Type.Reference node:
                    break;
                case Type.Callable node:
                    indent(() =>
                    {
                        TypeProp("result", node.Result);
                        foreach (var parameter in node.Parameters)
                        {
                            TypeProp("param", parameter);
                        }
                    });
                    break;
                default:
                    Assert(false);
                    break;
            }
        }

        private void Visit(Decl decl, bool complex)
        {
            wl($"{decl.ADecl.GetType().Name}{Name(decl.ADecl)}");
            
            indent(() =>
            {
                TypeProp("result", decl.GetResult());
                TypeProp("type", decl.Type);
                TypeProp("extends", decl.GetExtends());

                if (!complex)
                {
                    return;
                }

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
                    if (content.Block.Members.Count > 0)
                    {
                        wl("content");
                        indent(() =>
                        {
                            WalkMany(content.Block.Members, true);
                        });
                    }
                }
            });
        }

        private void Visit(Stmt stmt, bool complex)
        {
            wl(Ref(stmt.AStmt));
        }

        private void Visit(Stmt.Return stmt, bool complex)
        {
            wl(Ref(stmt.AStmt));
            Assert(stmt.Expr != null);
            
            if (stmt.Expr is Expr.Delayed delayed)
            {
                if (delayed.Resolved != null)
                {
                    indent(() =>
                    {
                        Walk(delayed.Resolved, complex);
                    });
                }
                else
                {
                    Assert(false);
                }
            }
        }

        private void Visit(Type type, bool complex)
        {
            Assert(false);
        }

        private void Visit(Type.Callable type, bool complex)
        {
            wl($"{type.GetType().Name}");
            indent(() =>
            {
                w($"{Head("result")} ");  Walk(type.Result, false);
                for (var i = 0; i < type.Parameters.Length; ++i)
                {
                    w($"{Head($"param[{i}]")} "); Walk(type.Parameters[i], false);
                }
            });
        }
        private void Visit(Type.Reference type, bool complex)
        {
            wl($"{type.GetType().Name}");
            indent(() =>
            {
                Walk(type.Decl, false);
            });
        }

        private void Visit(Expr expr, bool complex)
        {
            Assert(false);
        }

        private void Visit(Expr.Delayed expr, bool complex)
        {
            if (expr.Resolved != null)
            {
                Walk(expr.Resolved, complex);
            }
            else
            {
                Assert(false);
            }
        }

        private void Visit(Expr.ParameterReference expr, bool complex)
        {
            w($"{Head("parameter")} "); Walk(expr.Decl, false);
        }

        private void Visit(Expr.Reference expr, bool complex)
        {
            wl($"<<reference>>");
        }

        private void Visit(Expr.Natural expr, bool complex)
        {
            wl($"{expr.value}");
        }

        private void Visit(Expr.CallMember expr, bool complex)
        {
            wl($"{expr.GetType().Name}");
            indent(() =>
            {
                Walk(expr.Make, false);
                Walk(expr.Callable, false);
                for (var i = 0; i < expr.Arguments.Length; ++i)
                {
                    w($"{Head($"argument[{i}]")} "); Walk(expr.Arguments[i], false);
                }
            });
        }

        private string Name(Decl decl)
        {
            return Name(decl.ADecl);
        }

        private string Name(A.TreeNode node)
        {
            return node is A.With.Name named ? $" {named.Name.Text}" : "";
        }


        private string Ref(Decl decl)
        {
            return Ref(decl.ADecl);
        }

        private string Ref(A.TreeNode node)
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
            return $"{prefix}{node.GetType().Name}{Name(node)}";
        }
    }
}
