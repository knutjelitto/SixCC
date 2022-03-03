using Six.Core;
using Six.Runtime;
using Six.Six.Builtins;
using Six.Six.Instructions;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

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
            Walk(decl);
        }

        private void Walk(Entity? member)
        {
            if (member == null) return;

            Visit((dynamic)member);
        }

        private void WalkMany(IEnumerable<Member> members)
        {
            foreach (var member in members)
            {
                Walk(member);
            }
        }

        private void WalkMany(string header, IReadOnlyList<Entity> members)
        {
            if (members.Count > 0)
            {
                wl(header);
                indent(() =>
                {
                    foreach (var member in members)
                    {
                        Walk(member);
                    }
                });
            }
        }

        private string Head(string text)
        {
            const int nameWidth = -12;

            return $"{text, nameWidth}: ";
        }

        private string TypeOf(Type? type)
        {
            if (type == null) return "";

            if (type is Type.Declared declared)
            {
                if (Resolver.ResolveType(type) is Type.Declared resolved)
                {
                    if (!ReferenceEquals(declared.Decl, resolved.Decl))
                    {
                        type = resolved;
                    }
                }
            }

            switch (type)
            {
                case Type.Reference node:
                    return node.Decl.Name.Text;
                case Type.Callable node:
                    return $"{TypeOf(node.Result)}({string.Join(",", node.Parameters.Select(p => TypeOf(p)))})";
                case Type.Builtin node:
                    return node.ToString()!;
                default:
                    Assert(false);
                    return "<<TYPE-ERROR>>";
            }
        }

        private string ExprOf(Expr? entity)
        {
            if (entity == null) return "";

            switch (entity)
            {
                case Expr.Delayed expr:
                    return ExprOf(expr.Resolved);
                case Expr.Const expr:
                    return $"({expr.Insn})";
                case Expr.Binop expr:
                    return $"({expr.Insn} {ExprOf(expr.Arg1)} {ExprOf(expr.Arg2)})";
                default:
                    Assert(false);
                    return "<<EXPR-ERROR>>";
            }
        }

        private string DefaultOf(Expr? entity)
        {
            if (entity != null)
            {
                //return $" = {ExprOf(entity)}";
                return $" = ...";
            }
            return "";
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
                case Type.Builtin node:
                    return $"{node}";
                default:
                    Assert(false);
                    return string.Empty;
            }
        }

        private void TypeProp(string header, Type? type)
        {
            if (type == null) return;

            if (type is Type.Declared declared)
            {
                if (Resolver.ResolveType(type) is Type.Declared resolved)
                {
                    if (!ReferenceEquals(declared.Decl, resolved.Decl))
                    {
                        wl($"{Head(header)}{TypeProp(resolved)} (via {TypeProp(type)})");
                    }
                    else
                    {
                        wl($"{Head(header)}{TypeProp(type)}");
                    }
                }
                else
                {
                    wl($"{Head(header)}{TypeProp(type)}");
                }
            }
            else
            {
                wl($"{Head(header)}{TypeProp(type)}");
            }

            switch (type)
            {
                case Type.Reference:
                case Type.Builtin:
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

        private void Visit(Decl.Function decl)
        {
            wl($"{decl.GetType().Name} {Name(decl)} <{decl.Container.FullName}>");

            indent(() =>
            {
                WalkMany("parameters", decl.Parameters);
                WalkMany("result", new List<Entity> { decl.Result! });
                WalkMany("locals", decl.Locals);


                if (decl.Container is ContentScope content)
                {
                    if (content.Block.Members.Count > 0)
                    {
                        wl("content");
                    }
                }
            });
        }

        private void Visit(Decl.Parameter decl)
        {
            wl($"[{decl.Index}] {TypeOf(decl.Type)} {Name(decl)}{DefaultOf(decl.Default)}");
        }

        private void Visit(Decl.Let decl)
        {
            wl($"[{decl.Index}] {TypeOf(decl.Type)} {Name(decl)}{DefaultOf(decl.Value)}");
        }

        private void Visit(Decl decl)
        {
            wl($"{decl.GetType().Name} {Name(decl)} <{decl.Container.Parent.FullName}::{Name(decl)}>");
            
            indent(() =>
            {
                //TypeProp("result", decl.GetResult());
                TypeProp("type", decl.Type);
                //TypeProp("extends", decl.GetExtends());
            });
        }

        private void Visit(Stmt stmt)
        {
            Assert(false);
        }

        private void Visit(Type type)
        {
            Assert(false);
        }

        private void Visit(Type.Builtin type)
        {
            wl($"{type}");
        }

        private void Visit(Type.Callable type)
        {
            wl($"{type.GetType().Name}");
            indent(() =>
            {
                w(Head("result"));  Walk(type.Result);
                for (var i = 0; i < type.Parameters.Length; ++i)
                {
                    w(Head($"param[{i}]")); Walk(type.Parameters[i]);
                }
            });
        }
        private void Visit(Type.Reference type)
        {
            wl($"{type.GetType().Name}");
            indent(() =>
            {
                Walk(type.Decl);
            });
        }

        private void Visit(Expr expr)
        {
            Assert(false);
        }

        private void Visit(Expr.Delayed expr)
        {
            if (expr.Resolved != null)
            {
                Walk(expr.Resolved);
            }
            else
            {
                Assert(false);
            }
        }

        private void Visit(Expr.ParameterReference expr)
        {
            w($"{Head("parameter")}"); Walk(expr.Decl);
        }

        private void Visit(Expr.Reference expr)
        {
            wl($"<<reference>>");
        }

        private void Visit(Expr.ConstI32 expr)
        {
            wl($"{expr.Value}");
        }

        private void Visit(Expr.ConstI64 expr)
        {
            wl($"{expr.Value}");
        }

        private void Visit(Expr.ConstU64 expr)
        {
            wl($"{expr.Value}");
        }

        private void Visit(Expr.CallMember expr)
        {
            wl($"{expr.GetType().Name}");
            indent(() =>
            {
                Walk(expr.Make);
                Walk(expr.Callable);
                for (var i = 0; i < expr.Arguments.Length; ++i)
                {
                    w(Head($"argument[{i}]")); Walk(expr.Arguments[i]);
                }
            });
        }

        private string Name(Decl decl)
        {
            return decl.Name.Text;
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
