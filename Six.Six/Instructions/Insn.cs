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

        public static ToDoInsn ToDo(string text) => new(text);

        public static Simplest Return { get; } = new("return");

        public static Simplest CallStatic(string functionName) => new($"call {functionName}");

        public static class Local
        {
            public static LocalGet Get(uint index) => new(index);
        }

        public static class I32
        {
            public static Const Const(int value) => new(new Value.ValueI32(value));
            public static Binop Add() => Binop.Add(ValueType.I32);
            public static Binop Sub() => Binop.Sub(ValueType.I32);
            public static Binop Mul() => Binop.Mul(ValueType.I32);
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
        }

        public static class F64
        {
            public static Const Const(double value) => new(new Value.ValueF64(value));
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

            public static Binop Add(ValueType type) => new(type, "add", OpSign.Neutral);
            public static Binop Sub(ValueType type) => new(type, "sub", OpSign.Neutral);
            public static Binop Mul(ValueType type) => new(type, "mul", OpSign.Neutral);
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
            public IndexRef(uint index)
            {
                Index = index;
            }

            public uint Index { get; }
        }

        public class LocalGet : IndexRef
        {
            public LocalGet(uint index)
                : base(index)
            {
            }

            public override string ToString()
            {
                return $"local.get {Index}";
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
