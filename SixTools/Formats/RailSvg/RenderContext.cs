﻿#pragma warning disable CA1822 // Mark members as static

namespace SixTools.Formats.RailSvg
{
    internal class RenderContext
    {
        public int x;
        public int y;
        public readonly SvgPath path = new();
        public string RefBase = string.Empty;

        public void Reset(string refBase = "")
        {
            x = 0;
            y = 0;
            path.Clear();
            RefBase = refBase;
        }

        public void AddH(int n)
        {
            path.AddH(x, y, n);
        }

        public void AddV(int n)
        {
            path.AddV(x, y, n);
        }

        public int Zwanzig => 20;
    }
}
