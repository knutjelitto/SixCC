﻿using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class Builtins
    {
        private readonly Dictionary<string, Builtin> buildins = new();

        public Builtins(Module module)
        {
            Module = module;

            Add(new S32(this));
            TableIndex = Add(new U32(this));
            Add(new F32(this));
            Add(new F64(this));
            Add(new Anything(this));
            Boolean = Add(new Boolean(this));
            Bytes = Add(new Bytes(this));
        }
        public Builtin TableIndex { get; }
        public Builtin Boolean { get; }
        public Builtin Bytes { get; }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;

        private Builtin Add(Builtin builtin)
        {
            buildins.Add(builtin.Name, builtin);
            return builtin;
        }

        public Builtin Resolve(Decl named)
        {
            return Resolve(named.Name.Text);
        }

        public Builtin Resolve(string name)
        {
            if (buildins.TryGetValue(name, out var builtin))
            {
                return builtin;
            }
            throw new ArgumentOutOfRangeException(nameof(name), name);
        }
    }
}
