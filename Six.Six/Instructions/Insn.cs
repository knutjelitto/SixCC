﻿namespace Six.Six.Instructions
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

        public static Insn ToDo(string text) => new Simplest($";; TODO: {text}");
        public static Insn Comment(string text) => new Simplest($";; {text}");

        public static Insn Return { get; } = new Simple.Return();
        public static Insn Nop { get; } = new Simple.Nop();
        public static Insn Unreachable { get; } = new Simple.Unreachable();
        public static Insn Drop { get; } = new Simple.Drop();
        public static Insn If { get; } = new Simple.If();
        public static Insn Else { get; } = new Simple.Else();
        public static Insn End { get; } = new Simple.End();
        public static Insn Block { get; } = new Simple.Block();
        public static Insn Loop { get; } = new Simple.Loop();

        public static Insn Call(string functionName) => new Simplest($"call ${functionName}");
        public static Insn CallIndirect(string tableName, string type) => new Simplest($"call_indirect ${tableName} {type}");

        public static Insn BrIf(string label) => new Simplest($"br_if ${label}");
        public static Insn Br(string label) => new Simplest($"br ${label}");

        public static class Simple
        {
            public class Return : Simplest { public Return() : base("return") { } }
            public class Nop : Simplest { public Nop() : base("nop") { } }
            public class Unreachable : Simplest { public Unreachable() : base("unreachable") { } }
            public class Drop : Simplest { public Drop() : base("dtop") { } }
            public class If : Simplest { public If() : base("if") { } }
            public class Else : Simplest { public Else() : base("else") { } }
            public class End : Simplest { public End() : base("end") { } }
            public class Block : Simplest { public Block() : base("block") { } }
            public class Loop : Simplest { public Loop() : base("loop") { } }
        }

        public static class Local
        {
            public static LocalGet Get(int index) => new(index);
            public static LocalSet Set(int index) => new(index);
            public static LocalTee Tee(int index) => new(index);

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

                public override string ToString() => $"local.get {Index}";
            }

            public class LocalSet : IndexRef
            {
                public LocalSet(int index) : base(index)
                {
                }

                public override string ToString() => $"local.set {Index}";
            }

            public class LocalTee : IndexRef
            {
                public LocalTee(int index) : base(index)
                {
                }

                public override string ToString() => $"local.tee {Index}";
            }

        }

        public static class Global
        {
            public static Insn Get(string name) => new Simplest($"global.get ${name}");
            public static Insn Set(string name) => new Simplest($"global.set ${name}");
        }

        public static class Num
        {
            public abstract class Xnn<TValue>
                where TValue : struct
            {
                protected Value.ValueT<TValue> Value(TValue value) => new Value.ValueT<TValue>(ValueType, value);
                public abstract ValueType ValueType { get; }
                public abstract MemType MemType { get; }
                public abstract OpSign Signedness { get; }

                public Const Const(TValue value) => new(Value(value));

                public Insn Add => Binop.Add(ValueType);
                public Insn Sub => Binop.Sub(ValueType);
                public Insn Mul => Binop.Mul(ValueType);
                public Insn Div => Binop.Div(ValueType, Signedness);

                public Insn EQZ => Unop.EqZ(ValueType);
                public Insn EQ => Binop.Eq(ValueType);
                public Insn NE => Binop.Ne(ValueType);
                public Insn LE => Binop.Le(ValueType, Signedness);
                public Insn LT => Binop.Lt(ValueType, Signedness);
                public Insn GT => Binop.Gt(ValueType, Signedness);
                public Insn GE => Binop.Ge(ValueType, Signedness);

                public Insn Nop => Insn.Nop;

                public Insn Load(uint offset) => new Load(MemType, offset);
                public Insn Store(uint offset) => new Store(MemType, offset);
            }

            public abstract class Inn<TValue> : Xnn<TValue>
                where TValue : struct
            {
                public Insn Rem => Binop.Rem(ValueType, Signedness);
                public Insn Shl => Binop.Shl(ValueType);
                public Insn Shr => Binop.Shr(ValueType, Signedness);

                public Insn And => Binop.And(ValueType);
                public Insn Or => Binop.Or(ValueType);
                public Insn Xor => Binop.Xor(ValueType);
            }

            public class S8Impl : Inn<sbyte>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.S8;
                public override OpSign Signedness => OpSign.Signed;
            }

            public class S16Impl : Inn<short>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.S16;
                public override OpSign Signedness => OpSign.Signed;
            }

            public class S32Impl : Inn<int>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.S32;
                public override OpSign Signedness => OpSign.Signed;
            }

            public class S64Impl : Inn<long>
            {
                public override ValueType ValueType { get; } = ValueType.I64;
                public override MemType MemType { get; } = MemType.S64;
                public override OpSign Signedness => OpSign.Signed;
            }

            public class U8Impl : Inn<byte>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.U8;
                public override OpSign Signedness => OpSign.Unsigned;
            }

            public class U16Impl : Inn<ushort>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.U16;
                public override OpSign Signedness => OpSign.Unsigned;
            }

            public class U32Impl : Inn<uint>
            {
                public override ValueType ValueType { get; } = ValueType.I32;
                public override MemType MemType { get; } = MemType.U32;
                public override OpSign Signedness => OpSign.Unsigned;
            }

            public class U64Impl : Inn<ulong>
            {
                public override ValueType ValueType { get; } = ValueType.I64;
                public override MemType MemType { get; } = MemType.U64;
                public override OpSign Signedness => OpSign.Unsigned;
            }

            public abstract class Fnn<TValue> : Xnn<TValue>
                where TValue : struct
            {
                public Insn Neg => Unop.Neg(ValueType);
            }

            public class F32Impl : Fnn<float>
            {
                public override ValueType ValueType { get; } = ValueType.F32;
                public override MemType MemType { get; } = MemType.F32;
                public override OpSign Signedness => OpSign.Neutral;
            }

            public class F64Impl : Fnn<double>
            {
                public override ValueType ValueType { get; } = ValueType.F64;
                public override MemType MemType { get; } = MemType.F64;
                public override OpSign Signedness => OpSign.Neutral;
            }
        }

        public static readonly Num.S8Impl S8 = new();
        public static readonly Num.S16Impl S16 = new();
        public static readonly Num.S32Impl S32 = new();
        public static readonly Num.S64Impl S64 = new();
        public static readonly Num.U8Impl U8 = new();
        public static readonly Num.U16Impl U16 = new();
        public static readonly Num.U32Impl U32 = new();
        public static readonly Num.U64Impl U64 = new();

        public static readonly Num.F32Impl F32 = new();
        public static readonly Num.F64Impl F64 = new();

        public static readonly Pointer Address = new();

        public class Pointer
        {
            public Insn Load(uint offset) => new Load(MemType.U32, offset);
            public Insn Store(uint offset) => new Store(MemType.U32, offset);
        }

        public static class Boolean
        {
            public static Const False => S32.Const(0);
            public static Const True => S32.Const(1);
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
            public static Insn Clz(ValueType type) => new Unop(type, "clz", OpSign.Neutral);
            public static Insn Ctz(ValueType type) => new Unop(type, "ctz", OpSign.Neutral);
            public static Insn Popcnt(ValueType type) => new Unop(type, "popcnt", OpSign.Neutral);
            public static Insn EqZ(ValueType type) => new Unop(type, "eqz", OpSign.Neutral);
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

            public static Insn Shl(ValueType type) => new Binop(type, "shl", OpSign.Neutral);
            public static Insn Shr(ValueType type, OpSign signedness) => new Binop(type, "shr", signedness);
            public static Insn Rotl(ValueType type) => new Binop(type, "rotl", OpSign.Neutral);
            public static Insn Rotr(ValueType type) => new Binop(type, "rotr", OpSign.Neutral);

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
        private ValueType(string name, uint bytes)
        {
            Name = name;
            Bytes = bytes;
        }

        public string Name { get; }
        public uint Bytes { get; }

        public override string ToString()
        {
            return Name.ToLowerInvariant();
        }

        public static ValueType I32 { get; } = new ValueType("i32", 4);
        public static ValueType I64 { get; } = new ValueType("i64", 8);
        public static ValueType F32 { get; } = new ValueType("f32", 4);
        public static ValueType F64 { get; } = new ValueType("f64", 8);
        public static ValueType V128 { get; } = new ValueType("v128", 16);
    }

    public class MemType
    {
        private MemType(ValueType valueType, uint bytes, OpSign opSign)
        {
            ValueType = valueType;
            Bytes = bytes;
            OpSign = opSign;
        }

        public ValueType ValueType { get; }
        public uint Bytes { get; }
        public OpSign OpSign { get; }

        public string Load(uint offset)
        {
            return $"{ValueType}.load{Bits}{Sign} offset={offset}";
        }

        public string Store(uint offset)
        {
            return $"{ValueType}.store{Bits} offset={offset}";
        }

        private string Bits => Bytes == ValueType.Bytes ? "" : $"{Bytes * 8}";
        private string Sign => Bytes == ValueType.Bytes ? "" : $"{OpSign}";

        public static MemType S8 { get; } = new(ValueType.I32, 1, OpSign.Signed);
        public static MemType S16 { get; } = new(ValueType.I32, 2, OpSign.Signed);
        public static MemType S32 { get; } = new(ValueType.I32, 4, OpSign.Signed);
        public static MemType S64 { get; } = new(ValueType.I64, 8, OpSign.Signed);
        public static MemType U8 { get; } = new(ValueType.I32, 1, OpSign.Unsigned);
        public static MemType U16 { get; } = new(ValueType.I32, 2, OpSign.Unsigned);
        public static MemType U32 { get; } = new(ValueType.I32, 4, OpSign.Unsigned);
        public static MemType U64 { get; } = new(ValueType.I64, 8, OpSign.Unsigned);

        public static MemType F32 { get; } = new MemType(ValueType.F32, ValueType.F32.Bytes, OpSign.Neutral);
        public static MemType F64 { get; } = new MemType(ValueType.F64, ValueType.F64.Bytes, OpSign.Neutral);
    }
}
