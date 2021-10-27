using SixTools.Rails;

#pragma warning disable IDE0045 // Convert to conditional expression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace SixTools.Tiles
{
    public class TileMaker
    {
        private readonly Dimmer dimmer;

        private TileMaker(Dimmer dimmer)
        {
            this.dimmer = dimmer;
        }
        public static Tile Make(Railroad rail, Dimmer dimmer)
        {
            return new TileMaker(dimmer).Make(rail, false);
        }

        private Tile Make(Railroad node, bool backwards)
        {
            Tile? tile = null;

            switch (node)
            {
                case PlainRail:
                    tile = backwards
                        ? new ToLeftArrowTile()
                        : new ToRightArrowTile();
                    tile.Dim.Width = 2;
                    tile.Dim.Ascender = 1;
                    tile.Dim.Descender = 1;
                    break;
                case LiteralRail literal:
                    tile = new LiteralTile(literal.Text)
                    {
                        Dim = dimmer.Monospace(literal.Text)
                    };
                    break;
                case TokenRail token:
                    tile = MakeToken(token);
                    break;
                case ReferenceRail reference:
                    tile = MakeReference(reference);
                    break;
                case ProseRail prose:
                    tile = new ProseTile(prose.Text)
                    {
                        Dim = dimmer.SansSerif(prose.Text)
                    };
                    break;
                case CommentRail comment:
                    tile = new CommentTile(comment.Text)
                    {
                        Dim = dimmer.SansSerif(comment.Text)
                    };
                    break;
                case RangeRail range:
                    tile = MakeRange(range, backwards);
                    break;
                case ChoiceRail alt:
                    Assert(alt.Nodes.Count >= 2);
                    tile = MakeVTile(alt, backwards);
                    break;
                case SequenceRail seq:
                    Assert(seq.Nodes.Count >= 2);
                    tile = MakeHTile(seq, backwards);
                    break;
                case LoopRail loop:
                    tile = MakeLoop(loop, backwards);
                    break;
                case NotRail not:
                    tile = MakeNot(not, backwards);
                    break;
                case AnyRail any:
                    tile = MakeAny(any, backwards);
                    break;
                default:
                    break;
            }

            if (tile != null)
            {
                return tile;
            }

            throw new InvalidOperationException();
        }

        private TokenTile MakeToken(string text)
        {
            var tile = new TokenTile(text)
            {
                Dim = dimmer.SansSerif(text)
            };

            return tile;
        }

        private TokenTile MakeToken(TokenRail token)
        {
            return MakeToken(token.Text);
        }

        private ReferenceTile MakeReference(ReferenceRail reference)
        {
            var tile = new ReferenceTile(reference.Text)
            {
                Dim = dimmer.SansSerif(reference.Text)
            };

            return tile;
        }

        private HTile MakeNot(NotRail not, bool backwards)
        {
            var list = new List<Tile>
            {
                MakeToken(backwards ? "⌐" : "¬"),
                Make(not.Node, backwards)
            };

            return MakeHTile(backwards, list);
        }

        private Tile MakeAny(AnyRail any, bool backwards)
        {
            return MakeToken("🞄");
        }

        private Tile MakeRange(RangeRail range, bool backwards)
        {
            var tile = new RangeTile(range.Start, range.Stop);
            tile.Dim = dimmer.SansSerif($"[{char.ConvertFromUtf32(tile.Start)}-{char.ConvertFromUtf32(tile.Stop)}]");
            return tile;
        }

        private AnnotatedTile MakeAnnotation(Tile node, string text)
        {
            var tile = new AnnotatedTile(node, text)
            {
                Dim = new Dimension()
                {
                    Width = node.Width,
                    Ascender = node.Ascender,
                    Descender = node.Descender + dimmer.annotation_height
                }
            };


            var textdim = dimmer.SansSerif(tile.Text);
            tile.Dim.Width = Math.Max(tile.Dim.Width, textdim.Width);
            tile.Dim.Ascender += textdim.Ascender;
            tile.Dim.Descender += textdim.Descender;
            return tile;
        }

        private Tile MakeLoop(LoopRail loop, bool backwards)
        {
            VTile vlist;

            if (loop.Skip)
            {
                var skip = new VItem(Make(new PlainRail(), backwards), VTileType.B);
                var forward = new VItem(Make(loop.Forward, backwards), VTileType.H);
                var backward = new VItem(Make(loop.Backward, !backwards), VTileType.E);
                vlist = new VTile(1, skip, forward, backward);
            }
            else
            {
                var forward = new VItem(Make(loop.Forward, backwards), VTileType.G);
                var backward = new VItem(Make(loop.Backward, !backwards), VTileType.E);
                vlist = new VTile(0, forward, backward);
            }

            vlist.Measure();

            var label = LoopLabel(loop.Min, loop.Max);
            if (label.Length > 0)
            {
                return MakeAnnotation(vlist, label);
            }
            return vlist;
        }

        private HTile MakeHTile(SequenceRail seq, bool backwards)
        {
            return MakeHTile(backwards, seq.Nodes.Select(n => Make(n, backwards)));
        }

        private HTile MakeHTile(bool backwards, IEnumerable<Tile> tiles)
        {
            var list = new HTile(backwards ? tiles.Reverse() : tiles);

            list.Dim.Width = -2 + list.Nodes.Sum(n => n.Width + 2);
            list.Dim.Ascender = list.Nodes.Max(n => n.Ascender);
            list.Dim.Descender = list.Nodes.Max(n => n.Descender);

            return list;
        }

        private VTile MakeVTile(ChoiceRail alt, bool backwards)
        {
            return MakeVTile(alt.Offset, backwards, alt.Nodes.Select(n => Make(n, backwards)));
        }

        private VTile MakeVTile(int offset, bool backwards, IEnumerable<Tile> tiles)
        {
            var tile = new VTile(offset);

            tile.AddRange(tiles);

            tile.Measure();

            var count = tile.Count;
            Assert(count >= 2);

            for (var i = 0; i < count; i++)
            {
                VTileType z;

                var at_offset = i == tile.Offset;
                var above_offset = i < tile.Offset;
                var below_offset = i > tile.Offset;
                var first_alt = i == 0;
                var last_alt = i == count - 1;

                if (at_offset && last_alt)
                {
                    //       |         |
                    //       |         |
                    // => ---A-- ... --A---
                    //
                    z = VTileType.A;
                }
                else if (above_offset && first_alt)
                {
                    z = VTileType.B;
                }
                else if (at_offset && first_alt)
                {
                    z = VTileType.C;
                }
                else if (at_offset)
                {
                    z = VTileType.D;
                }
                else if (below_offset && last_alt)
                {
                    z = VTileType.E;
                }
                else
                {
                    z = VTileType.F;
                }

                tile[i].B = z;
            }

            foreach (var vtile in tile.Items)
            {
                Assert(vtile.B != VTileType.UNSET);
            }

            return tile;
        }

        private string LoopLabel(int min, int max)
        {
            Assert(max == 0 || max >= min);

            if ((min == 0 || min == 1) && max == 0)
            {
                return string.Empty;
            }

            if (max == min)
            {
                var h = Times(max);
                if (h != null)
                {
                    return $"({h} only)";
                }
                return $"({max} times)";
            }
            if (min == 0)
            {
                var h = Times(max);
                if (h != null)
                {
                    return $"({h} at most)";
                }
                return $"({max} times at most)";
            }
            if (max == 0)
            {
                var h = Times(min);
                if (h != null)
                {
                    return $"(at least {h})";
                }
                return $"(at least {min} times)";
            }
            return $"({min}-{max} times)";

            static string? Times(int n)
            {
                if (n >= timesprose.Length)
                {
                    return null;
                }
                return timesprose[n];
            }
        }

        private static readonly string[] timesprose = new[]
        {
            "never",
            "once", "twice", "three times",
            "four times", "five times", "six times",
            "seven times", "eight times", "nine times",
            "ten times", "eleven times", "twelve times"
        };
    }
}
