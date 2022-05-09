using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Six.Core;
using Six.Runtime;

using Data = Six.Six.Wasms.WasmData;
using static Six.Six.Wasms.WaRunType;

namespace Six.Six.Wasms
{
    public abstract class WaObject : WithWriter, Wamber
    {
        public WaObject(WaModule module)
            : base(module.Writer)
        {
            Module = module;
            ObjectId = Module.NextObjectId++;
        }

        public WaModule Module { get; }
        public uint ObjectId { get; }
        public abstract WaClass Meta { get; }

        public WaPtr StartAddress { get; set; } = WaPtr.Invalid;
        public WaPtr ObjectAddress => StartAddress.Offset(WaRef.HeaderSize);
        public WaPtr NextAddress { get; set; } = WaPtr.Invalid;
        public abstract uint PayloadSize { get; }

        public virtual void Prepare()
        {
            Assert(StartAddress.IsValid);
            Assert(NextAddress.IsValid);
            Assert(NextAddress > StartAddress);
        }

        protected void EmitHeader()
        {
            wl($"(; {StartAddress} ;)");
            indent(() =>
            {
                wl($"(; heap           ;) {Data.EmitInt32(-1)}");
                wl($"(; object-id {ObjectId,4} ;) {Data.EmitUInt32(ObjectId)}");
                wl($"(; dispatch       ;) {Data.EmitInt32(Meta.Dispatches.Index)}");
                wl($"(; size           ;) {Data.EmitUInt32(PayloadSize)}");
            });
        }

        public abstract void Emit();
    }
}
