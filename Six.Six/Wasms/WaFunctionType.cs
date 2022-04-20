using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFunctionType : WithWriter, Wamber
    {
        public WaFunctionType(WaFunctionTypeList types, WaFuncSignature signature, uint index)
            : base(types.Writer)
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

        public void Prepare()
        {
        }

        public void Emit()
        {
            wl($"(type ${Name} {Signature})");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
