using Six.Core;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class Prepper : EmitBase
    {
        public Prepper(Emitter emitter, Writer writer)
            : base(writer)
        {
            Emitter = emitter;
        }

        public Emitter Emitter { get; }

        public void Prep()
        {
            foreach (var ns in Emitter.Module.GetNamespaces())
            {
                Walk(ns);
            }
        }

        private void Walk(Entity entity)
        {
            Prep((dynamic)entity);
        }

        private void Walk(Expr? expr)
        {
            if (expr != null)
            {
                Walk((Entity)expr);
            }
        }

        private void Walk(Block block)
        {
            foreach (var member in block.Members)
            {
                Walk(member);
            }
        }

        private void Walk<T>(IEnumerable<T> entities)
            where T : Entity
        {
            foreach (var entity in entities)
            {
                Walk(entity);
            }
        }

        private void Prep(Entity entity)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Prep(Decl.Class decl)
        {
            Walk(decl.Block);

            decl.Layout.Run();
        }

        private void Prep(Decl.Object decl)
        {
            Walk(decl.Block);

            decl.Layout.Run();
        }

        private void Prep(Decl.Interface decl)
        {
            Walk(decl.Block);

            decl.Layout.Run();
        }

        private void Prep(Decl.Function decl)
        {
            Walk(decl.Block);
        }

        private void Prep(Decl.Constructor decl)
        {
            Walk(decl.Block);
        }

        private void Prep(Decl.Attribute decl)
        {
            Walk(decl.Block);
        }

        private void Prep(Decl.Global decl)
        {
            Walk(decl.Value);
        }

        private void Prep(Decl.LetVar decl)
        {
            Walk(decl.Value);
        }

        private void Prep(Decl.Field decl)
        {
            //--
        }

        private void Prep(Decl.SelfParameter decl)
        {
            //--
        }

        private void Prep(Decl.Parameter decl)
        {
            Walk(decl.Default);
        }

        private void Prep(Stmt.Return stmt)
        {
            Walk(stmt.Expr);
        }

        private void Prep(Stmt.Assign stmt)
        {
            Walk(stmt.Left);
            Walk(stmt.Right);
        }

        private void Prep(Expr.SelectField expr)
        {
            Walk(expr.Reference);
            Walk(expr.Field);
        }

        private void Prep(Expr.If expr)
        {
            Walk(expr.Condition);
            Walk(expr.Then);
            Walk(expr.Else);
        }

        private void Prep(Expr.CallFunction expr)
        {
            Walk(expr.Arguments);
        }

        private void Prep(Expr.CallConstructor expr)
        {
            Walk(expr.Arguments);
        }

        private void Prep(Expr.CallIndirect expr)
        {
            Walk(expr.Arguments);
        }

        private void Prep(Expr.CallPrefixMember expr)
        {
            Walk(expr.Arg);
        }

        private void Prep(Expr.CallInfixMember expr)
        {
            Walk(expr.Arg1);
            Walk(expr.Arg2);
        }

        private void Prep(Expr.ObjectReference expr)
        {
            //--
        }

        private void Prep(Expr.FunctionReference expr)
        {
            //--
        }

        private void Prep(Expr.AttributeReference expr)
        {
            //--
        }

        private void Prep(Expr.GlobalReference expr)
        {
            //--
        }

        private void Prep(Expr.LocalReference expr)
        {
            //--
        }

        private void Prep(Expr.ParameterReference expr)
        {
            //--
        }

        private void Prep(Expr.ConstI32 expr)
        {
            //--
        }

        private void Prep(Expr.ConstU32 expr)
        {
            //--
        }

        private void Prep(Expr.ConstString expr)
        {
            //--
        }
    }
}
