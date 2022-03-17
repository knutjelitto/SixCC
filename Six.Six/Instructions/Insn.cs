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

        public static Insn Return { get; } = new Simplest("return");
        public static Insn If { get; } = new Simplest("if");
        public static Insn Else { get; } = new Simplest("else");
        public static Insn End { get; } = new Simplest("end");

        public static Insn Drop { get; } = new Simplest("drop");

        public static Insn Call(string functionName) => new Simplest($"call ${functionName}");
        public static Insn CallIndirect(string tableName, string type) => new Simplest($"call_indirect (table {tableName}) {type}");

        public static class Local
        {
            public static LocalGet Get(int index) => new(index);
            public static LocalSet Set(int index) => new(index);
        }

        public static class Global
        {
            public static Insn Get(string name) => new Simplest($"global.get ${name}");
            public static Insn Set(string name) => new Simplest($"global.set ${name}");
        }

        public static class I32
        {
            public static Const Const(int value) => new(new Value.ValueI32(value));
            public static Insn Add => Binop.Add(ValueType.I32);
            public static Insn Sub => Binop.Sub(ValueType.I32);
            public static Insn Mul => Binop.Mul(ValueType.I32);
            public static Insn Div => Binop.DivS(ValueType.I32);
            public static Insn Rem => Binop.RemS(ValueType.I32);

            public static Insn And => Binop.And(ValueType.I32);
            public static Insn Or => Binop.Or(ValueType.I32);
            public static Insn Xor => Binop.Xor(ValueType.I32);

            public static Insn Lt => Binop.LtS(ValueType.I32);
            public static Insn Le => Binop.LeS(ValueType.I32);
            public static Insn Gt => Binop.GtS(ValueType.I32);
            public static Insn Ge => Binop.GeS(ValueType.I32);

            public static Insn Load(uint offset) => new Load(MemType.S32(), offset);
            public static Insn Store(uint offset) => new Store(MemType.U32(), offset);
        }

        public static class U32
        {
            public static Const Const(uint value) => new(new Value.ValueU32(value));

            public static Insn Add => Binop.Add(ValueType.I32);
            public static Insn Sub => Binop.Sub(ValueType.I32);
            public static Insn Mul => Binop.Mul(ValueType.I32);
            public static Insn Div => Binop.DivU(ValueType.I32);
            public static Insn Rem => Binop.RemU(ValueType.I32);

            public static Insn And => Binop.And(ValueType.I32);
            public static Insn Or => Binop.Or(ValueType.I32);
            public static Insn Xor => Binop.Xor(ValueType.I32);

            public static Insn Load(uint offset) => new Load(MemType.U32(), offset);
            public static Insn Store(uint offset) => new Store(MemType.U32(), offset);
        }

        public static class I64
        {
            public static Const Const(long value) => new(new Value.ValueI64(value));
            public static Insn Load(uint offset) => new Load(MemType.S64(), offset);
        }

        public static class U64
        {
            public static Const Const(ulong value) => new(new Value.ValueU64(value));
            public static Insn Load(uint offset) => new Load(MemType.U64(), offset);
            public static Insn Store(uint offset) => new Store(MemType.U64(), offset);
        }

        public static class F32
        {
            public static Const Const(float value) => new(new Value.ValueF32(value));

            public static Insn Neg => Unop.Neg(ValueType.F32);

            public static Insn Add => Binop.Add(ValueType.F32);
            public static Insn Sub => Binop.Sub(ValueType.F32);
            public static Insn Mul => Binop.Mul(ValueType.F32);
            public static Insn Div => Binop.Div(ValueType.F32);
            public static Insn Load(uint offset) => new Load(MemType.F32, offset);
            public static Insn Store(uint offset) => new Store(MemType.F32, offset);
        }

        public static class F64
        {
            public static Const Const(double value) => new(new Value.ValueF64(value));

            public static Insn Neg => Unop.Neg(ValueType.F64);

            public static Insn Add => Binop.Add(ValueType.F64);
            public static Insn Sub => Binop.Sub(ValueType.F64);
            public static Insn Mul => Binop.Mul(ValueType.F64);
            public static Insn Div => Binop.Div(ValueType.F64);

            public static Insn Load(uint offset) => new Load(MemType.F64, offset);
            public static Insn Store(uint offset) => new Store(MemType.F64, offset);
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

            public static Insn And(ValueType type) => new Binop(type, "and", OpSign.Neutral);
            public static Insn Or(ValueType type) => new Binop(type, "or", OpSign.Neutral);
            public static Insn Xor(ValueType type) => new Binop(type, "xor", OpSign.Neutral);

            public static Insn LtS(ValueType type) => new Binop(type, "lt", OpSign.Signed);
            public static Insn LtU(ValueType type) => new Binop(type, "lt", OpSign.Unsigned);
            public static Insn LeS(ValueType type) => new Binop(type, "le", OpSign.Signed);
            public static Insn LeU(ValueType type) => new Binop(type, "le", OpSign.Unsigned);
            public static Insn GtS(ValueType type) => new Binop(type, "gt", OpSign.Signed);
            public static Insn GtU(ValueType type) => new Binop(type, "gt", OpSign.Unsigned);
            public static Insn GeS(ValueType type) => new Binop(type, "ge", OpSign.Signed);
            public static Insn GeU(ValueType type) => new Binop(type, "ge", OpSign.Unsigned);
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

        public static MemType U32(int bytes = 4) => new MemType(ValueType.I32, bytes, OpSign.Unsigned);
        public static MemType S32(int bytes = 4) => new MemType(ValueType.I32, bytes, OpSign.Signed);
        public static MemType U64(int bytes = 8) => new MemType(ValueType.I64, bytes, OpSign.Unsigned);
        public static MemType S64(int bytes = 8) => new MemType(ValueType.I64, bytes, OpSign.Signed);

        public static MemType F32 { get; } = new MemType(ValueType.F32, ValueType.F32.Bytes, OpSign.Neutral);
        public static MemType F64 { get; } = new MemType(ValueType.F64, ValueType.F64.Bytes, OpSign.Neutral);
    }
}
