using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaInstructionList : WaListOf<WaInstruction>
    {
        public WaInstructionList(IWithWriter withWriter)
            : base(withWriter)
        {
        }
    }
}
