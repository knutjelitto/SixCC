using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using System;

namespace Six.Six.Instructions
{
    public class Dumper : WithWriter
    {
        public Dumper(Writer writer)
            : base(writer)
        {
        }

        public void Dump(Decl.Classy classy)
        {
            comment(() =>
            {
                Walker(classy);
            });
        }

        private void comment(Action action)
        {
            indent("(;", ";)", action);
        }

        private void WalkExpr(Expr expr)
        {
            Expr((dynamic)expr);
        }

        private void Walker(Entity decl)
        {
            Walk((dynamic)decl);
        }

        private void Walk(Entity decl)
        {
            Assert(false);
        }

        private void WalkMembers(Decl.WithMembers decl)
        {
            indent(() =>
            {
                foreach (var member in decl.Members)
                {
                    Walker(member);
                }
            });
        }

        private string Extends(Decl.Classy decl)
        {
            if (decl.Extends != null)
            {
                return $" : {decl.Extends}";
            }
            return "";
        }

        private void Walk(Decl.Classy decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Class decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Object decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}{Extends(decl)}");
            WalkMembers(decl);
        }

        private void Walk(Decl.Attribute decl)
        {
            wl($"attribute {decl.FullName}");
        }

        private void Walk(Decl.Funcy decl)
        {
            wl($"{decl.GetType().Name.ToLowerInvariant()} {decl.FullName}");
            WalkMembers(decl);
        }

        private void Walk(Stmt.Assign stmt)
        {
            WalkExpr(stmt.Left);
            w(" = ");
            WalkExpr(stmt.Right);
            wl(";");
        }


        private void Walk(Stmt.Return stmt)
        {
            w("return");
            if (stmt.Expr != null)
            {
                w(" ");
                WalkExpr(stmt.Expr);
            }
            wl(";");
        }

        private void Expr(Expr expr)
        {
            Assert(false);
            w(":::");
        }

        private void Expr(Expr.Reference expr)
        {
            w($"{expr.Decl.Name}");
        }

        private void Expr(Expr.SelectAttribute expr)
        {
            w($"{expr.Reference.Decl.Name}");
            w(".");
            w($"{expr.Attribute.Name}");
        }

        private void Expr(Expr.CallConstructor expr)
        {
            w($"{expr.Class.Name}.{expr.Ctor.Name}(");
            var more = false;
            foreach (var arg in expr.Arguments)
            {
                if (more)
                {
                    w(",");
                }
                WalkExpr(arg);
            }
            w(")");
        }

        private void Expr(Expr.Binop expr)
        {
            Assert(false);
            w(":::");
        }



    }
}