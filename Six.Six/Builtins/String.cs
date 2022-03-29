using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public sealed class String : BuiltinCore
    {
        public String(Builtins builtins)
            : base(builtins, Names.Core.String, WasmDef.Pointer)
        {
            infix.Add("+", Add);
        }

        public override Insn Load(uint offset)
        {
            Assert(false);
            throw new System.NotImplementedException();
        }

        public override Insn Store(uint offset)
        {
            Assert(false);
            throw new System.NotImplementedException();
        }

        public Primitive Add(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.ToDo(this, "string + string", left, right);
        }
    }
}
