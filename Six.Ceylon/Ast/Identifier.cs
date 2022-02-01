﻿using Six.Runtime.Types;
using System;

namespace Six.Ceylon.Ast
{
    public interface Identifier : AstNode
    {
        string Text { get; }
        RToken Token { get; }

        public abstract class Core : Identifier, IComparable<Core>
        {
            public Core(RToken token, string text)
            {
                Token = token;
                Text = text;
            }

            public RToken Token { get; }
            public string Text { get; }

            public int CompareTo(Core? other) => Text.CompareTo(other!.Text ?? string.Empty);
            public override bool Equals(object? obj) => obj is Core that && Text == that.Text;
            public override int GetHashCode() => Text.GetHashCode();
            public override string ToString() => Text;
        }

        public sealed class Any : Core
        {
            public Any(RToken token)
                : base(token, token.Text)
            {
            }
        }

        public sealed class Lower : Core
        {
            public Lower(RToken token, string? text = null)
                : base(token, text ?? GetText(token))
            {
            }

            private static string GetText(RToken token)
            {
                var text = token.Text;

                if (text.StartsWith("\\i"))
                    return text[2..];
                return text;
            }
        }

        public sealed class Upper : Core
        {
            public Upper(RToken token)
                : base(token, GetText(token))
            {
            }

            private static string GetText(RToken token)
            {
                var text = token.Text;

                if (text.StartsWith("\\I"))
                    return text[2..];
                return text;
            }
        }

        public abstract record List(IEnumerable<Identifier> Items) : ReadOnlyList<Identifier>(Items);
    }


    public sealed record Identifiers(IEnumerable<Identifier> Items) : Identifier.List(Items);
}
