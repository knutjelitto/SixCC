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

        Colon,
        Assign,
        Semi,
        Drop,
        Lift,
        Alter,
        Option,
        Complement,
        Not,
        Star,
        Plus,
        Minus,
        Range,
        Any,
    }
}
