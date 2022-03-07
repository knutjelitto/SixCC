using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class Insn
    {
        public class Simplest : Insn
        {
            public Simplest(string text)
            {
                Text = text;
            }

            public string Text { get; }

            public override string ToString()
            {
                return Text;
            }
        }

        public class ToDoInsn : Simplest
        {
            public ToDoInsn(string text)
                : base(text)
            {
            }

            public override string ToString()
            {
                return $"TODO: {Text}";
            }
        }

        public static Insn ToDo(string text) => new ToDoInsn(text);

        public static Insn Return { get; } = new Simplest("return");

        public static Insn Drop { get; } = new Simplest("drop");

        public static Insn Call(string functionName) => new Simplest($"call ${functionName}");
        public static Insn CallIndirect(string tableName) => new Simplest($"call_indirect (table {tableName})");

        public static class Local
        {
            public static LocalGet Get(int index) => new(index);
            public static LocalSet Set(int index) => new(index);
        }

        public static class I32
        {
            public static Const Const(int value) => new(new Value.ValueI32(value));
            public static Insn Add => Binop.Add(ValueType.I32);
            public static Insn Sub => Binop.Sub(ValueType.I32);
            public static Insn Mul => Binop.Mul(ValueType.I32);
            public static Insn Div => Binop.DivS(ValueType.I32);
            public static Insn Rem => Binop.RemS(ValueType.I32);
        }

        public static class U32
        {
            public static Const Const(uint value) => new(new Value.ValueU32(value));
            public static Insn Add => Binop.Add(ValueType.I32);
            public static Insn Sub => Binop.Sub(ValueType.I32);
            public static Insn Mul => Binop.Mul(ValueType.I32);
            public static Insn Div => Binop.DivU(ValueType.I32);
            public static Insn Rem => Binop.RemU(ValueType.I32);
        }

        public static class I64
        {
            public static Const Const(long value) => new(new Value.ValueI64(value));
        }

        public static class U64
        {
            public static Const Const(ulong value) => new(new Value.ValueU64(value));
        }

        public static class F32
        {
            public static Const Const(float value) => new(new Value.ValueF32(value));

            public static Insn Neg => Unop.Neg(ValueType.F32);

            public static Insn Add => Binop.Add(ValueType.F32);
            public static Insn Sub => Binop.Sub(ValueType.F32);
            public static Insn Mul => Binop.Mul(ValueType.F32);
            public static Insn Div => Binop.Div(ValueType.F32);
        }

        public static class F64
        {
            public static Const Const(double value) => new(new Value.ValueF64(value));

            public static Insn Neg => Unop.Neg(ValueType.F64);

            public static Insn Add => Binop.Add(ValueType.F64);
            public static Insn Sub => Binop.Sub(ValueType.F64);
            public static Insn Mul => Binop.Mul(ValueType.F64);
            public static Insn Div => Binop.Div(ValueType.F64);
        }

        public class Unop : Insn
        {
            private Unop(ValueType type, string name, OpSign sign)
            {
                Type = type;
                Name = name;
                Sign = sign;
            }

            public ValueType Type { get; }
            public string Name { get; }
            public OpSign Sign { get; }

            public override string ToString()
            {
                return $"{Type}.{Name}{Sign}";
            }

            public static Insn Neg(ValueType type) => new Unop(type, "neg", OpSign.Neutral);
        }

        public class Binop : Insn
        {
            private Binop(ValueType type, string name, OpSign sign)
            {
                Type = type;
                Name = name;
                Sign = sign;
            }

            public ValueType Type { get; }
            public string Name { get; }
            public OpSign Sign { get; }

            public override string ToString()
            {
                return $"{Type}.{Name}{Sign}";
            }

            public static Insn Add(ValueType type) => new Binop(type, "add", OpSign.Neutral);
            public static Insn Sub(ValueType type) => new Binop(type, "sub", OpSign.Neutral);
            public static Insn Mul(ValueType type) => new Binop(type, "mul", OpSign.Neutral);
            public static Insn Div(ValueType type) => new Binop(type, "div", OpSign.Neutral);
            public static Insn DivS(ValueType type) => new Binop(type, "div", OpSign.Signed);
            public static Insn DivU(ValueType type) => new Binop(type, "div", OpSign.Unsigned);
            public static Insn RemS(ValueType type) => new Binop(type, "rem", OpSign.Signed);
            public static Insn RemU(ValueType type) => new Binop(type, "rem", OpSign.Unsigned);
        }

        public class Const : Insn
        {
            public Const(Value value)
            {
                Value = value;
            }

            public Value Value { get; }

            public override string ToString()
            {
                return $"{Value.Type}.const {Value}";
            }
        }

        public abstract class IndexRef : Insn
        {
            public IndexRef(int index)
            {
                Index = index;
            }

            public int Index { get; }
        }

        public class LocalGet : IndexRef
        {
            public LocalGet(int index)
                : base(index)
            {
            }

            public override string ToString()
            {
                return $"local.get {Index}";
            }
        }

        public class LocalSet : IndexRef
        {
            public LocalSet(int index)
                : base(index)
            {
            }

            public override string ToString()
            {
                return $"local.set {Index}";
            }
        }
    }

    public abstract class Value
    {
        public class ValueT<T> : Value
            where T : struct
        {
            public ValueT(ValueType type, T value) : base(type)
            {
                Value = value;
            }

            public T Value { get; }

            public override string ToString()
            {
                return Value.ToString()!;
            }
        }

        public Value(ValueType type)
        {
            Type = type;
        }

        public ValueType Type { get; }

        public class ValueI32 : ValueT<int>
        {
            public ValueI32(int value) : base(ValueType.I32, value)
            {
            }
        }

        public class ValueU32 : ValueT<uint>
        {
            public ValueU32(uint value) : base(ValueType.I32, value)
            {
            }
        }

        public class ValueI64 : ValueT<long>
        {
            public ValueI64(long value) : base(ValueType.I64, value)
            {
            }
        }

        public class ValueU64 : ValueT<ulong>
        {
            public ValueU64(ulong value) : base(ValueType.I64, value)
            {
            }
        }

        public class ValueF32 : ValueT<float>
        {
            public ValueF32(float value) : base(ValueType.F32, value)
            {
            }
        }

        public class ValueF64 : ValueT<double>
        {
            public ValueF64(double value) : base(ValueType.F64, value)
            {
            }
        }

    }

    public class OpSign
    {
        private OpSign(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public override string ToString()
        {
            return $"{Text}";
        }

        public static OpSign Neutral { get; } = new OpSign("");
        public static OpSign Signed { get; } = new OpSign("_s");
        public static OpSign Unsigned { get; } = new OpSign("_u");
    }

    public class ValueType
    {
        private ValueType(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return Name.ToLowerInvariant();
        }

        public static ValueType I32 { get; } = new ValueType("i32");
        public static ValueType I64 { get; } = new ValueType("i64");
        public static ValueType F32 { get; } = new ValueType("f32");
        public static ValueType F64 { get; } = new ValueType("f64");
    }
}
