using Six.Runtime;
using Six.Six.Instructions;

using static Six.Six.Wasms.WasmAlign;

namespace Six.Six.Wasms
{
    public class WaGlobal : WithWriter, Wamber
    {
        public WaGlobal(WaModule module, bool mutable, string name, WasmType type, WaInstructionList instructions)
            : base(module.Writer)
        {
            Module = module;
            Mutable = mutable;
            Name = name;
            Type = type;
            Instructions = instructions;
        }

        public WaModule Module { get; }
        public bool Mutable { get; }
        public string Name { get; }
        public WasmType Type { get; }
        public WaInstructionList Instructions { get; }

        public void Prepare()
        {
            Instructions.Prepare();
        }

        public void Emit()
        {
            var type = Mutable ? $"(mut {Type})" : $"{Type}";

            wl($"(global ${Name} (export \"{Name}\") {type}");
            indent(() =>
            {
                if (Name == Sema.Module.Data_Start)
                {
                    wl($"{Insn.U32.Const(Module.DataStart)}");
                }
                else if (Name == Sema.Module.Heap_Start)
                {
                    wl($"{Insn.U32.Const(Align16(Module.HeapStart))}");
                }
                else if (Name == Sema.Module.Heap_Current)
                {
                    wl($"{Insn.U32.Const(Align16(Module.HeapStart))}");
                }
                else
                {
                    Instructions.Emit();
                }
            });
            wl($")");
        }
    }
}
