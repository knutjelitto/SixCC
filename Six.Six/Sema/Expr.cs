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

        public sealed record Binop(Builtin Builtin, Insn Insn, Concrete Arg1, Concrete Arg2)
            : Primitive(Builtin)
        {
            public override void Emit(Emitter emitter)
            {
                Arg1.Emit(emitter);
                Arg2.Emit(emitter);
                emitter.Add(Insn);
            }
        }

        public sealed record CallFunction(FunctionReference Function, List<Concrete> Arguments)
            : Primitive(Function.Type!)
        {
            public override void Emit(Emitter emitter)
            {
                foreach (var argument in Arguments)
                {
                    argument.Emit(emitter);
                }
                emitter.Add(Insn.CallStatic(Function.Decl.FullName()));
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

        public sealed record ParameterReference(Decl.Parameter Decl, Type Type) : Primitive(Type)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.Local.Get(Decl.Index));
            }
        }

        public sealed record LocalReference(Decl.Let Decl, Type Type)
            : Primitive(Type)
        {
            public override void Emit(Emitter emitter)
            {
                emitter.Add(Insn.Local.Get(42));
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
