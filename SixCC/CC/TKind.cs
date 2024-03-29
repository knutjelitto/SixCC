﻿namespace SixCC.CC
{
    internal enum TKind
    {
        EOF,
        Name,
        Literal,
        Epsilon,
        LeftParent,
        RightParent,
        LeftBracket,
        RightBracket,
        LeftCurly,
        RightCurly,
        LeftAngle,
        RightAngle,
        Colon,
        Semi,
        Comma,
        Alter,
        Option,
        Exclam,
        Star,
        Plus,
        Minus,
        Range,
        Any,
    }
}
