using Six.Core;
using Six.Six.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface Expr : Entity
    {
        void Emit(Writer writer);

        public sealed record Delayed : Expr
        {
            public Concrete? Resolved { get; set; } = null;

            public void Emit(Writer writer) 
            { 
                Resolved?.Emit(writer);
            }
        }

        public interface Concrete : Expr
        {
            Type? Type { get; }
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

            public Insn[] Insns { get; }

            public virtual void Emit(Writer writer)
            {
                foreach (var insn in Insns)
                {
                    writer.WriteLine($"{insn}");
                }
            }
        }

        public sealed record Natural(Type Type, ulong Value, Insn Insn) : ConcreteExpr(Type, Insn)
        { 
        }

        public record Reference(Decl Decl) : ConcreteExpr
        {
            public override Type? Type => Decl.Type;
        }

        public sealed record ParameterReference(Decl Decl) : Reference(Decl);

        public sealed record CallMember(Expr Make, Type.Callable Callable, params Expr[] Arguments)
            : ConcreteExpr
        {
            public override Type? Type => Callable.Result;

            public override void Emit(Writer writer)
            {
                Make.Emit(writer);
                foreach (var argument in Arguments)
                {
                    argument.Emit(writer); 
                }
                writer.WriteLine($"{Insn.ToDo("callable")}");
            }
        }
    }
}
