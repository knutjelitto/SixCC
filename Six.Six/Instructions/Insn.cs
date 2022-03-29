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
                return $";; TODO: {Text}";
            }
        }

        public static Insn ToDo(string text) => new ToDoInsn(text);
        public static Insn Comment(string text) => new Simplest($";; {text}");

        public static Insn Return { get; } = new Simplest("return");
        public static Insn Unreachable { get; } = new Simplest("unreachable");
        public static Insn Drop { get; } = new Simplest("drop");
        public static Insn If { get; } = new Simplest("if");
        public static Insn Else { get; } = new Simplest("else");
        public static Insn End { get; } = new Simplest("end");

        public static Insn Call(string functionName) => new Simplest($"call ${functionName}");
        public static Insn CallIndirect(string tableName, string type) => new Simplest($"call_indirect (table ${tableName}) {type}");

        public static class Local
        {
            public static LocalGet Get(int index) => new(index);
            public static LocalSet Set(int index) => new(index);
            public static LocalTee Tee(int index) => new(index);
        }

        public static class Global
        {
            public static Insn Get(string name) => new Simplest($"global.get ${name}");
            public static Insn Set(string name) => new Simplest($"global.set ${name}");
        }

        public abstract class Xnn<TValue>
            where TValue : struct
        {
            protected Value.ValueT<TValue> Value(TValue value) => new Value.ValueT<TValue>(ValueType, value);
            protected abstract ValueType ValueType { get; }
            protected abstract MemType MemType { get; }
            protected abstract OpSign Signedness { get; }

            public Const Const(TValue value) => new(Value(value));

            public Insn Add => Binop.Add(ValueType);
            public Insn Sub => Binop.Sub(ValueType);
            public Insn Mul => Binop.Mul(ValueType);
            public Insn Div => Binop.Div(ValueType, Signedness);

            public Insn EQ => Binop.Eq(ValueType);
            public Insn NE => Binop.Ne(ValueType);
            public Insn LE => Binop.Le(ValueType, Signedness);
            public Insn LT => Binop.Lt(ValueType, Signedness);
            public Insn GT => Binop.Gt(ValueType, Signedness);
            public Insn GE => Binop.Ge(ValueType, Signedness);

            public Insn Load(uint offset) => new Load(MemType, offset);
            public Insn Store(uint offset) => new Store(MemType, offset);
        }

        public abstract class Inn<TValue> : Xnn<TValue>
            where TValue : struct
        {
            public Insn Rem => Binop.Rem(ValueType, Signedness);

            public Insn And => Binop.And(ValueType);
            public Insn Or => Binop.Or(ValueType);
            public Insn Xor => Binop.Xor(ValueType);
        }

        public class S32Impl : Inn<int>
        {
            protected override ValueType ValueType { get; } = ValueType.I32;
            protected override MemType MemType { get; } = MemType.S32();
            protected override OpSign Signedness => OpSign.Signed;
        }

        public class U32Impl : Inn<uint>
        {
            protected override ValueType ValueType { get; } = ValueType.I32;
            protected override MemType MemType { get; } = MemType.U32();
            protected override OpSign Signedness => OpSign.Unsigned;
        }

        public class S64Impl : Inn<long>
        {
            protected override ValueType ValueType { get; } = ValueType.I64;
            protected override MemType MemType { get; } = MemType.S64();
            protected override OpSign Signedness => OpSign.Signed;
        }

        public class U64Impl : Inn<ulong>
        {
            protected override ValueType ValueType { get; } = ValueType.I64;
            protected override MemType MemType { get; } = MemType.U64();
            protected override OpSign Signedness => OpSign.Unsigned;
        }

        public abstract class Fnn<TValue> : Xnn<TValue>
            where TValue : struct
        {
            public Insn Neg => Unop.Neg(ValueType);
        }

        public class F32Impl : Fnn<float>
        {
            protected override ValueType ValueType { get; } = ValueType.F32;
            protected override MemType MemType { get; } = MemType.F32;
            protected override OpSign Signedness => OpSign.Neutral;
        }

        public class F64Impl : Fnn<double>
        {
            protected override ValueType ValueType { get; } = ValueType.F64;
            protected override MemType MemType { get; } = MemType.F64;
            protected override OpSign Signedness => OpSign.Neutral;
        }

        public static readonly S32Impl S32 = new();
        public static readonly U32Impl U32 = new();
        public static readonly S64Impl S64 = new();
        public static readonly U64Impl U64 = new();

        public static readonly F32Impl F32 = new();
        public static readonly F64Impl F64 = new();

        public static readonly Pointer Ptr = new();

        public class Pointer
        {
            public Insn Push(Ptr ptr) => ptr.Insn;
            public Insn Add => U32.Add;
            public Insn Load(uint offset) => new Load(MemType.U32(), offset);
            public Insn Store(uint offset) => new Store(MemType.U32(), offset);
        }

        public static class Boolean
        {
            public static Insn False => S32.Const(0);
            public static Insn True => S32.Const(1);
            public static Insn And => S32.And;
            public static Insn Or => S32.Or;
            public static Insn Xor => S32.Xor;
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
            public static Insn Div(ValueType type, OpSign signedness) => new Binop(type, "div", signedness);
            public static Insn Rem(ValueType type, OpSign signedness) => new Binop(type, "rem", signedness);

            public static Insn And(ValueType type) => new Binop(type, "and", OpSign.Neutral);
            public static Insn Or(ValueType type) => new Binop(type, "or", OpSign.Neutral);
            public static Insn Xor(ValueType type) => new Binop(type, "xor", OpSign.Neutral);

            public static Insn Eq(ValueType type) => new Binop(type, "eq", OpSign.Neutral);
            public static Insn Ne(ValueType type) => new Binop(type, "ne", OpSign.Neutral);
            public static Insn Lt(ValueType type, OpSign signedness) => new Binop(type, "lt", signedness);
            public static Insn Le(ValueType type, OpSign signedness) => new Binop(type, "le", signedness);
            public static Insn Gt(ValueType type, OpSign signedness) => new Binop(type, "gt", signedness);
            public static Insn Ge(ValueType type, OpSign signedness) => new Binop(type, "ge", signedness);
        }

        public class Load : Insn
        {
            public Load(MemType memType, uint offset)
            {
                MemType = memType;
                Offset = offset;
            }

            public MemType MemType { get; }
            public uint Offset { get; }

            public override string ToString()
            {
                return MemType.Load(Offset);
            }
        }

        public class Store : Insn
        {
            public Store(MemType memType, uint offset)
            {
                MemType = memType;
                Offset = offset;
            }

            public MemType MemType { get; }
            public uint Offset { get; }

            public override string ToString()
            {
                return MemType.Store(Offset);
            }
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

        public class LocalTee : IndexRef
        {
            public LocalTee(int index)
                : base(index)
            {
            }

            public override string ToString()
            {
                return $"local.tee {Index}";
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
        private ValueType(string name, int bytes)
        {
            Name = name;
            Bytes = bytes;
        }

        public string Name { get; }
        public int Bytes { get; }

        public override string ToString()
        {
            return Name.ToLowerInvariant();
        }

        public static ValueType I32 { get; } = new ValueType("i32", 4);
        public static ValueType I64 { get; } = new ValueType("i64", 8);
        public static ValueType F32 { get; } = new ValueType("f32", 4);
        public static ValueType F64 { get; } = new ValueType("f64", 8);
    }

    public class MemType
    {
        private MemType(ValueType valueType, int bytes, OpSign opSign)
        {
            ValueType = valueType;
            Bytes = bytes;
            OpSign = opSign;
        }

        public ValueType ValueType { get; }
        public int Bytes { get; }
        public OpSign OpSign { get; }

        public string Load(uint offset)
        {
            return $"{ValueType}.load{Bits}{Sign} offset={offset}";
        }

        public string Store(uint offset)
        {
            return $"{ValueType}.store{Bits}{Sign} offset={offset}";
        }

        private string Bits => Bytes == ValueType.Bytes ? "" : $"{Bytes * 8}";
        private string Sign => Bytes == ValueType.Bytes ? "" : $"{OpSign}";

        public static MemType U32(int bytes = 4) => new(ValueType.I32, bytes, OpSign.Unsigned);
        public static MemType S32(int bytes = 4) => new(ValueType.I32, bytes, OpSign.Signed);
        public static MemType U64(int bytes = 8) => new(ValueType.I64, bytes, OpSign.Unsigned);
        public static MemType S64(int bytes = 8) => new(ValueType.I64, bytes, OpSign.Signed);

        public static MemType F32 { get; } = new MemType(ValueType.F32, ValueType.F32.Bytes, OpSign.Neutral);
        public static MemType F64 { get; } = new MemType(ValueType.F64, ValueType.F64.Bytes, OpSign.Neutral);
    }
}
