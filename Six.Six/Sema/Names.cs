using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public static class Names
    {
        public static class Core
        {
            public static readonly string SelfValue = "self";
            public static readonly string Float32 = "f32";
            public static readonly string Float64 = "f64";
            public static readonly string UInt64 = "u64";
            public static readonly string Int64 = "i64";
            public static readonly string UInt32 = "u32";
            public static readonly string Int32 = "i32";
            public static readonly string UInt16 = "u16";
            public static readonly string Int16 = "u16";
            public static readonly string UInt8 = "u8";
            public static readonly string Int8 = "i8";
            public static readonly string Basic = "Basic";
            public static readonly string Boolean = "Boolean";
            public static readonly string Bytes = "Bytes";
            public static readonly string String = "String";
            public static readonly string Null = "Null";
            public static readonly string Nothing = "Nothing";
            public static readonly string Anything = "Anything";
            public static readonly string Iterable = "Iterable";
            public static readonly string Callable = "Callable";
            public static readonly string Sequence = "Sequence";
            public static readonly string Sequential = "Sequential";
            public static readonly string Tuple = "Tuple";
            public static readonly string Empty = "Empty";
        }

        public static class Attr
        {
            public static readonly string Shared = "shared";
            public static readonly string Native = "native";
            public static readonly string Static = "static";
        }
    }
}
