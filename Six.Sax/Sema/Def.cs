namespace Six.Sax.Sema
{
    public interface Def : It
    {
        public interface Parameter : Def { }
        public interface Type : Def { }
        public interface OpenType : Type { }
        public interface Callable : Def { }
        public interface Class : Def { }
        public interface TypeParameter : Def { }
    }
}
