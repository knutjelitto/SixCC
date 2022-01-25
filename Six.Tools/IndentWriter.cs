﻿using Six.Core;
using System;

namespace Six.Tools
{
    public class IndentWriter : IWriter
    {
        private const string defaultIndent = "    ";
        private readonly string indent = "    ";
        private string currentIndent = string.Empty;
        private bool pending = false;

        public IndentWriter(IBaseWriter writer, string? indent = null)
        {
            Writer = writer;
            this.indent = indent ?? defaultIndent;
        }

        public IBaseWriter Writer { get; }

        public IDisposable Indent(Action? before = null, Action? after = null)
        {
            before?.Invoke();
            var savedIndend = currentIndent;
            currentIndent += indent;
            return new Disposable(() =>
            {
                currentIndent = savedIndend;
                after?.Invoke();
            });
        }

        public void Indent(Action action)
        {
            using (Indent())
            {
                action();
            }
        }

        public IDisposable IndentWith(string with)
        {
            var savedIndend = currentIndent;
            currentIndent += with;
            return new Disposable(() =>
            {
                currentIndent = savedIndend;
            });
        }

        public void Write(string text)
        {
            Prefix();
            Writer.Write(text);
        }

        public void WriteLine(string text)
        {
            Prefix();
            Writer.Write(text);
            Writer.WriteLine();
            pending = true;
        }

        public void WriteLine()
        {
            Writer.WriteLine();
            pending = true;
        }

        private void Prefix()
        {
            if (pending)
            {
                Writer.Write(currentIndent);
                pending = false;
            }
        }
    }
}
