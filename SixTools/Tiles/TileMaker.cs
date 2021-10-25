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
                    tile.Dim.Width += dimmer.literal_padding;
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
                    tile.Dim.Width += dimmer.prose_padding;
                    break;
                case CommentRail comment:
                    tile = new CommentTile(comment.Text)
                    {
                        Dim = dimmer.SansSerif(comment.Text)
                    };
                    tile.Dim.Width += dimmer.comment_padding;
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
            tile.Dim.Width += dimmer.rule_padding;

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
            tile.Dim.Width += dimmer.rule_padding;

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

        private AnnotationTile MakeAnnotation(Tile node, string text)
        {
            var tile = new AnnotationTile(node, text);
            tile.Dim = new Dimension()
            {
                Width = tile.Node.Width,
                Ascender = tile.Node.Ascender,
                Descender = tile.Node.Descender + dimmer.annotation_height
            };
            var textdim = dimmer.SansSerif(tile.Text);
            tile.Dim.Width = Math.Max(tile.Dim.Width, textdim.Width);
            tile.Dim.Ascender += textdim.Ascender;
            tile.Dim.Descender += textdim.Descender;
            return tile;
        }

        private Tile MakeLoop(LoopRail loop, bool backwards)
        {
            var forward = new VItem(Make(loop.Forward, backwards), backwards ? VTileType.TLINE_H : VTileType.TLINE_h);
            var backward = new VItem(Make(loop.Backward, !backwards), VTileType.TLINE_E);

            var vlist = new VTile(0, forward, backward);

            vlist.Dim.Width = 6 + vlist.Items.Max(i => i.A.Width);
            vlist.Dim.Ascender = vlist.Items[0].A.Ascender;
            vlist.Dim.Descender = vlist.Items[0].A.Descender + vlist.Items[1].A.Height;

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

            tile.Dim.Width = 6 + tile.Items.Max(i => i.A.Width);

            tile.Dim.Ascender = 0;
            for (var i = 0; i < tile.Offset; i++)
            {
                tile.Dim.Ascender += tile.Items[i].A.Height;
                tile.Dim.Ascender += 1;
            }
            tile.Dim.Ascender += tile.Items[tile.Offset].A.Ascender;

            tile.Dim.Descender = 0;
            tile.Dim.Descender += tile.Items[tile.Offset].A.Descender;
            for (var i = tile.Offset + 1; i < tile.Count; i++)
            {
                tile.Dim.Descender += 1;
                tile.Dim.Descender += tile.Items[i].A.Height;
            }

            var count = tile.Count;
            Assert(count >= 2);

            for (var i = 0; i < count; i++)
            {
                VTileType z;

                var sameline = i == tile.Offset;
                var aboveline = i < tile.Offset;
                var belowline = i > tile.Offset;
                var firstalt = i == 0;
                var lastalt = i == count - 1;

                if (sameline && lastalt)
                {
                    z = backwards ? VTileType.TLINE_A : VTileType.TLINE_a;
                }
                else if (firstalt && aboveline)
                {
                    z = VTileType.TLINE_B;
                }
                else if (sameline && firstalt)
                {
                    z = backwards ? VTileType.TLINE_C : VTileType.TLINE_c;
                }
                else if (sameline)
                {
                    z = backwards ? VTileType.TLINE_D : VTileType.TLINE_d;
                }
                else if (belowline && i > 0 && lastalt)
                {
                    z = VTileType.TLINE_E;
                }
                else if (tile.Items[i].A is EllipsisTile)
                {
                    z = VTileType.TLINE_F;
                }
                else
                {
                    z = backwards ? VTileType.TLINE_G : VTileType.TLINE_g;
                }

                tile.Items[i].B = z;
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

            if (min == 1 && max == 0)
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
