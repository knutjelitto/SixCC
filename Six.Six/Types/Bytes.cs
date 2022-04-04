﻿using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class Bytes : Builtin
    {
        public Bytes(Builtins builtins)
            : base(builtins, Names.Core.Bytes, W.WasmType.Addr)
        {
        }

        public override Insn Load(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        public override Insn Store(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }
    }
}
