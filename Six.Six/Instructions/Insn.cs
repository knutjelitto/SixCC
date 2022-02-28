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

        public static Simplest Return => new("return");

        public static class Local
        {
            public static LocalGet Get(uint index) => new(index);
        }

        public static class I32
        {
            public static Const Const(uint value) => new(new Value.ValueI32(value));
        }

        public static class I64
        {
            public static Const Const(ulong value) => new(new Value.ValueI64(value));
        }

        public static class F32
        {
            public static Const Const(float value) => new(new Value.ValueF32(value));
        }

        public static class F64
        {
            public static Const Const(double value) => new(new Value.ValueF64(value));
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

        public class ValueI32 : ValueT<uint>
        {
            public ValueI32(uint value) : base(new NumberType.I32(), value)
            {
            }
        }

        public class ValueI64 : ValueT<ulong>
        {
            public ValueI64(ulong value) : base(new NumberType.I64(), value)
            {
            }
        }

        public class ValueF32 : ValueT<float>
        {
            public ValueF32(float value) : base(new NumberType.F32(), value)
            {
            }
        }

        public class ValueF64 : ValueT<double>
        {
            public ValueF64(double value) : base(new NumberType.F64(), value)
            {
            }
        }

    }

    public abstract class ValueType
    {
        public override string ToString()
        {
            return GetType().Name.ToLowerInvariant();
        }
    }

    public class NumberType : ValueType
    {
        public class I32 : NumberType { }
        public class I64 : NumberType { }
        public class F32 : NumberType { }
        public class F64 : NumberType { }
    }
}
