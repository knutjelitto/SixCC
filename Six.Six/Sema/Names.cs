namespace Six.Six.Sema
{
    public static class Names
    {
        public static class Core
        {
            public static string S8 => "s8";
            public static string S16 => "s16";
            public static string S32 => "s32";
            public static string S64 => "s64";

            public static string U8 => "u8";
            public static string U16 => "u16";
            public static string U32 => "u32";
            public static string U64 => "u64";

            public static string F32 => "f32";
            public static string F64 => "f64";

            public static string Char => "char";
            public static string Boolean => "Boolean";

            public static string SelfValue => "self";
            public static string Basic => "Basic";
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
            public static readonly string Virtual = "virtual";
            public static readonly string Override = "override";
            public static readonly string Sealed = "sealed";
            public static readonly string Prefinal = "prefinal";
        }

        public static class Nomes
        {
            public static readonly string Interface = "interface";
        }
    }
}
