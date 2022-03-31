namespace Six.Six.Wasms
{
    public class WaFunctionType
    {
        public WaFunctionType(WaFunctionTypeList types, WaFuncSignature signature, uint index)
        {
            Types = types;
            Signature = signature;
            Index = index;
            Name = $"funcType{Index}";
        }

        public WaFunctionTypeList Types { get; }
        public WaFuncSignature Signature { get; }
        public uint Index { get; }
        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
