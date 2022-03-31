namespace Six.Six.Wasms
{
    public class WaDispatch : Wamber
    {
        public WaDispatch(WaClass clazz, WaFunction function)
        {
            Clazz = clazz;
            Function = function;
        }

        public WaClass Clazz { get; }
        public WaFunction Function { get; }
        public int Index { get; set; } = -1;

        public void Prepare()
        {
            Assert(Index >= 0);
        }

        public void Emit()
        {
        }
    }
}
