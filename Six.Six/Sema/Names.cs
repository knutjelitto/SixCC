﻿namespace Six.Six.Sema
{
    public static class Names
    {
        public static class Core
        {
            public static string SelfValue => "self";
            public static string Float32 => "f32";
            public static string Float64 => "f64";
            public static string UInt64 => "u64";
            public static string Int64 => "i64";
            public static string UInt32 => "u32";
            public static string Int32 => "i32";
            public static string UInt16 => "u16";
            public static string Int16 => "u16";
            public static string UInt8 => "u8";
            public static string Int8 => "i8";
            public static string Basic => "Basic";
            public static string Boolean => "Boolean";
            public static string Bytes => "Bytes";
            public static string String => "String";
            public static string Null => "Null";
            public static string Nothing => "Nothing";
            public static string Anything => "Anything";
            public static string CoreAnything => $"{Module.CoreNamespace}.Anything";
            public static string Iterable => "Iterable";
            public static string Callable => "Callable";
            public static string Sequence => "Sequence";
            public static string Sequential => "Sequential";
            public static string Tuple => "Tuple";
            public static string Empty => "Empty";
        }

        public static class Attr
        {
            public static readonly string Shared = "shared";
            public static readonly string Native = "native";
            public static readonly string Static = "static";
            public static readonly string Abstract = "abstract";
        }
    }
}
