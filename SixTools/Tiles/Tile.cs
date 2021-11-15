#pragma warning disable CA1051 // Do not declare visible instance fields
#pragma warning disable CA1708 // Identifiers should differ by more than case
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable IDE1006 // Naming Styles

using Six.Core;
using SixTools.Formats.RailSvg;

namespace SixTools.Tiles
{
    public class Dimension
    {
        public pix Ascender { get; set; }

        public pix Descender { get; set; }

        public pix Width { get; set; }

        public pix Height => Ascender + Descender;
    }

    public enum VTileType
    {
        UNSET = 42,
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H, // skipable loop
    }

    public class Tile
    {
        public Dimension Dim = new();
        public pix Width => Dim.Width;
        public pix Height => Dim.Height;
        public pix Ascender => Dim.Ascender;
        public pix Descender => Dim.Descender;
    }

    public class VItem
    {
        public VItem(Tile a, VTileType b)
        {
            A = a;
            B = b;
        }

        public VItem(Tile a)
            : this(a, VTileType.UNSET)
        {
        }

        public Tile A { get; }
        public VTileType B { get; set; }
    }

    public class VTile : Tile
    {
        private readonly List<VItem> items;
        public VTile(int offset, params VItem[] items)
        {
            Offset = offset;
            this.items = items.ToList();
        }

        public int Offset { get; }

        public IReadOnlyList<VItem> Items => items;
        public int Count => items.Count;
        public VItem this[int index] => Items[index];

        public void Add(Tile a, VTileType b)
        {
            items.Add(new VItem(a, b));
        }

        public void Add(Tile a)
        {
            items.Add(new VItem(a));
        }

        public void AddRange(IEnumerable<Tile> tiles)
        {
            foreach (var tile in tiles)
            {
                Add(tile);
            }
        }

        public void Measure(pix unit, pix vGap)
        {
            Dim.Width = (6 * unit) + Items.Max(i => i.A.Width);

            Dim.Ascender = pix.zero;
            for (var i = 0; i < Offset; i++)
            {
                Dim.Ascender += this[i].A.Height;
                Dim.Ascender += vGap;
            }
            Dim.Ascender += this[Offset].A.Ascender;

            Dim.Descender = pix.zero;
            Dim.Descender += this[Offset].A.Descender;
            for (var i = Offset + 1; i < Count; i++)
            {
                Dim.Descender += vGap;
                Dim.Descender += this[i].A.Height;
            }
        }
    }

    public class HTile : Tile
    {
        private readonly List<Tile> nodes;

        public HTile(IEnumerable<Tile> nodes)
        {
            this.nodes = nodes.ToList();
        }

        public HTile()
            : this(Enumerable.Empty<Tile>())
        {
        }

        public IReadOnlyList<Tile> Nodes => nodes;

    }

    public class PlainTile : Tile
    {
    }

    public class NotTile : Tile
    {
        public NotTile(Tile inner, bool backward)
        {
            Inner = inner;
            Backward = backward;
        }

        public Tile Inner { get; }
        public bool Backward { get; }
    }

    public class AnyTile : Tile
    {
    }

    public class RangeTile : Tile
    {
        public RangeTile(Codepoint start, Codepoint stop)
        {
            Start = start;
            Stop = stop;
        }

        public RangeTile(string start, string stop)
            : this(From(start), From(stop))
        {
        }

        public Codepoint Start { get; }
        public Codepoint Stop { get; }

        private static Codepoint From(string chars)
        {
            if (chars.Length == 1)
            {
                Assert(!char.IsSurrogate(chars[0]));
                return new Codepoint(chars[0]);
            }
            else if (chars.Length == 2 && char.IsSurrogatePair(chars, 0))
            {
                return new Codepoint(char.ConvertToUtf32(chars, 0));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

    public abstract class TextTile : Tile
    {
        public TextTile(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }

    public class TokenTile : TextTile
    {
        public TokenTile(string text)
            : base(text)
        {
        }
    }

    public class ReferenceTile : TextTile
    {
        public ReferenceTile(string text)
            : base(text)
        {
        }
    }

    public class CommentTile : TextTile
    {
        public CommentTile(string text)
            : base(text)
        {
        }
    }

    public class ProseTile : TextTile
    {
        public ProseTile(string text)
            : base(text)
        {
        }
    }

    public class LiteralTile : TextTile
    {
        public LiteralTile(string text)
            : base(text)
        {
        }
    }

    public class AnnotatedTile : Tile
    {
        public AnnotatedTile(Tile node, string text)
        {
            Node = node;
            Text = text;
        }

        public Tile Node { get; }
        public string Text { get; }
    }

    public abstract class ArrowTile : Tile
    {
    }

    public class ToRightArrowTile : ArrowTile
    {
    }

    public class ToLeftArrowTile : ArrowTile
    {
    }
}
