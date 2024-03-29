﻿using System;

using Six.Runtime;
using Six.Six.Instructions;
using static Six.Six.Wasms.WasmAlign;

namespace Six.Six.Wasms
{
    public class WaRuntimeData : WithWriter
    {
        private List<WaRunType> runtimes = new();
        private Dictionary<string, WaRunType> index = new();

        public WaRuntimeData(WaModule module, string memoryName)
            : base(module.Writer)
        {
            Module = module;
            MemoryName = memoryName;
        }

        public WaModule Module { get; }
        public string MemoryName { get; }

        public uint BaseOffset { get; set; } = uint.MaxValue;
        public uint Size { get; private set; } = 0;

        public void Add(WaRunType runtime)
        {
            runtimes.Add(runtime);
            index.Add(runtime.Class.Name, runtime);
        }

        public WaRunType Get(string className)
        {
            return index[className];
        }

        public void Prepare()
        {
            Assert(BaseOffset < uint.MaxValue);
            Assert(BaseOffset == Align16(BaseOffset));

            var offset = BaseOffset;

            foreach (var runtime in runtimes)
            {
                Assert(offset == Align16(offset));

                runtime.StartAddress = WaPtr.Null.Offset(offset);

                offset = Align16(offset + runtime.Size);

                runtime.NextAddress = WaPtr.Null.Offset(offset);

                runtime.Prepare();

            }

            Assert(offset == Align16(offset));

            Size = offset - BaseOffset;
        }

        public void Emit()
        {
            Assert(BaseOffset < uint.MaxValue);

            wl($"(data (memory ${MemoryName}) (offset {Insn.U32.Const(BaseOffset)})");
            indent(() =>
            {
                foreach (var runtime in runtimes)
                {
                    runtime.Emit();
                }
                var next = BaseOffset + Size;
                wl($"(; {next} 0x{next:X4} -> {Align16(next)} 0x{Align16(next):X4} ;)");
            });
            wl(")");
        }
    }
}
