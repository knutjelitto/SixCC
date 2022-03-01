using Six.Core;
using Six.Six.Builtins;
using Six.Six.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Emitting
    {
        void Emit(Emitter emitter);
    }

    public interface Expr : Entity
    {
        public sealed record Delayed : Expr
        {
            public Concrete? Resolved { get; set; } = null;
        }

        public interface Concrete : Expr, Emitting
        {
            Type? Type { get; set; }
            Type? FinalType { get; set; }
            Insn[] Insns { get; }
        }

        public abstract record ConcreteExpr : Concrete
        {
            public ConcreteExpr(params Insn[] insns)
            {
                Insns = insns;
            }

            public ConcreteExpr(Type? type, params Insn[] insns)
            {
                Type = type;
                Insns = insns;
            }

            public virtual Type? Type { get; set; }

            public virtual Type? FinalType { get; set; }

            public Insn[] Insns { get; }

            public abstract void Emit(Emitter emitter);
        }

        public abstract record Primitive : ConcreteExpr
        {
            public Primitive(Builtin Builtin) : base(new Type.BuiltinReference(Builtin))
            { }
            public Primitive(Type Type) : base(Type)
            { }
        }

        public sealed record ConstI32(Builtin Builtin, int Value) : Primitive(Builtin)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.I32.Const(Value));
            }
        }

        public sealed record ConstI64(Builtin Builtin, long Value)
            : Primitive(Builtin)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.I64.Const(Value));
            }
        }

        public sealed record ConstU64(Builtin Builtin, ulong Value)
            : Primitive(Builtin)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.U64.Const(Value));
            }
        }

        public sealed record Binop(Builtin Builtin, Insn Insn, Expr.Concrete Oper1, Expr.Concrete Oper2)
            : Primitive(Builtin)
        {
            public override void Emit(Emitter emitter)
            {
                Oper1.Emit(emitter);
                Oper2.Emit(emitter);
                emitter.Add(Insn);
            }
        }

        public sealed record ParameterReference(Decl.Parameter Decl, Type Type) : Primitive(Type)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.Local.Get(Decl.Index));
            }
        }

        public sealed record FunctionReference(Decl.Function Decl, Type Type)
            : Primitive(Type)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.CallStatic(Decl.FullName()));
            }
        }


        public record Reference(Decl Decl) : ConcreteExpr
        {
            public override Type? Type => Decl.Type;

            public override void Emit(Emitter emitter)
            {
                throw new NotImplementedException();
            }
        }

        public sealed record CallMember(Type.Callable Callable, Expr Make, params Expr[] Arguments)
            : ConcreteExpr
        {
            public override Type? Type => Callable.Result;

            public override void Emit(Emitter emitter)
            {
                throw new NotImplementedException();
            }
        }
    }
}
