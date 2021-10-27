#pragma warning disable CA1051 // Do not declare visible instance fields
#pragma warning disable CA1708 // Identifiers should differ by more than case
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable IDE1006 // Naming Styles

namespace SixTools.Tiles
{
    public abstract class Dimmer
    {
        public Dimmer()
        {
        }
        public abstract Dimension Monospace(string text);
        public abstract Dimension SansSerif(string text);

        public int annotation_height;
    }

    public class Dimension
    {
        private int ascender = -1;
        private int descender = -1;
        private int width = -1;

        public int Ascender
        {
            get
            {
                Assert(ascender >= 0);
                return ascender;
            }
            set
            {
                Assert(value >= 0);
                ascender = value;
            }
        }

        public int Descender
        {
            get
            {
                Assert(descender >= 0);
                return descender;
            }
            set
            {
                Assert(value >= 0);
                descender = value;
            }
        }
        public int Width
        {
            get
            {
                Assert(width >= 0);
                return width;
            }
            set
            {
                Assert(value >= 0);
                width = value;
            }
        }

        public int Height => Ascender + Descender;
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
        public int Width => Dim.Width;
        public int Height => Dim.Height;
        public int Ascender => Dim.Ascender;
        public int Descender => Dim.Descender;
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

        public void Measure()
        {
            Dim.Width = 6 + Items.Max(i => i.A.Width);

            Dim.Ascender = 0;
            for (var i = 0; i < Offset; i++)
            {
                Dim.Ascender += this[i].A.Height;
                Dim.Ascender += 1;
            }
            Dim.Ascender += this[Offset].A.Ascender;

            Dim.Descender = 0;
            Dim.Descender += this[Offset].A.Descender;
            for (var i = Offset + 1; i < Count; i++)
            {
                Dim.Descender += 1;
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

    public class RangeTile : Tile
    {
        public RangeTile(int start, int stop)
        {
            Start = start;
            Stop = stop;
        }

        public RangeTile(string start, string stop)
            : this(From(start), From(stop))
        {
        }

        public int Start { get; }
        public int Stop { get; }

        private static int From(string chars)
        {
            if (chars.Length == 1)
            {
                Assert(!char.IsSurrogate(chars[0]));
                return chars[0];
            }
            else if (chars.Length == 2 && char.IsSurrogatePair(chars, 0))
            {
                return char.ConvertToUtf32(chars, 0);
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
