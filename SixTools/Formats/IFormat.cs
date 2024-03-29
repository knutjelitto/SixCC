﻿using Six.Core;
using SixTools.Ast;

namespace SixTools.Formats
{
    public interface IFormat
    {
        void Format(Grammar grammar, Writer writer);
        string DebugExtension { get; }
        string FormatName { get; }
    }
}
