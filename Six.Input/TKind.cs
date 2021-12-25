﻿namespace Six.Input
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
        Define,
        Colon,
        Semi,
        Comma,
        Alter,
        Option,
        Not,
        And,
        Star,
        Plus,
        Minus,
        Range,
        Any,
    }
}
