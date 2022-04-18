using Six.Runtime;
using Six.Six.Instructions;

namespace Six.Six.Wasms.Instructions
{
    public abstract class WiBlock : WaInstruction
    {
        protected WiBlock(IWithWriter withWriter)
            : base(withWriter)
        {
        }
    }
}
