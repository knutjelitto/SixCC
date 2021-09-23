using System;
using System.Collections.Generic;
using System.Data;

namespace Six
{
    public enum TokenCategory
    { 
        Normal,
        Keyword,
        ContextSensitiveKeyword,
        Special,
        Artificial,
    };

    public class TokenInfo
    {
        public TokenInfo(TokenKind kind, string? text, TokenCategory category = TokenCategory.Normal)
        {
            Kind = kind;
            Text = text;
            Category = category;
        }

        static TokenInfo()
        {
            Keywords = new Dictionary<string, TokenKind>();

            foreach (var info in Info.Values)
            {
                if (info.IsKeyword)
                {
                    Keywords.Add(info.Text!, info.Kind);
                }
            }
        }

        public TokenKind Kind { get; }
        public string? Text { get; }
        public TokenCategory Category { get; }
        public bool IsKeyword => Category == TokenCategory.Keyword || Category == TokenCategory.ContextSensitiveKeyword;

        public static Dictionary<string, TokenKind> Keywords;

        public static Dictionary<TokenKind, TokenInfo> Info = new()
        {
            [TokenKind.Colon] = new TokenInfo(TokenKind.Colon, ":"),
            [TokenKind.SemiColon] = new TokenInfo(TokenKind.SemiColon, ";"),
            [TokenKind.Comma] = new TokenInfo(TokenKind.Comma, "."),
            [TokenKind.Dot] = new TokenInfo(TokenKind.Dot, "."),
            [TokenKind.DotDot] = new TokenInfo(TokenKind.DotDot, ".."),
            [TokenKind.Elipsis] = new TokenInfo(TokenKind.Elipsis, "..."),
            [TokenKind.CurrentDir] = new TokenInfo(TokenKind.CurrentDir, "./"),
            [TokenKind.ParentDir] = new TokenInfo(TokenKind.ParentDir, "../"),
            [TokenKind.StringFile] = new TokenInfo(TokenKind.StringFile, "$"),
            [TokenKind.BinaryFile] = new TokenInfo(TokenKind.BinaryFile, "#"),
            [TokenKind.At] = new TokenInfo(TokenKind.At, "@"),
            [TokenKind.Cond] = new TokenInfo(TokenKind.Cond, "?"),

            [TokenKind.LeftParen] = new TokenInfo(TokenKind.LeftParen, "("),
            [TokenKind.RightParen] = new TokenInfo(TokenKind.RightParen, ")"),
            [TokenKind.LeftCurly] = new TokenInfo(TokenKind.LeftCurly, "{"),
            [TokenKind.RightCurly] = new TokenInfo(TokenKind.RightCurly, "}"),
            [TokenKind.LeftSquare] = new TokenInfo(TokenKind.LeftSquare, "["),
            [TokenKind.RightSquare] = new TokenInfo(TokenKind.RightSquare, "]"),

            [TokenKind.Add] = new TokenInfo(TokenKind.Add, "+"),
            [TokenKind.Sub] = new TokenInfo(TokenKind.Sub, "-"),
            [TokenKind.Mul] = new TokenInfo(TokenKind.Mul, "*"),
            [TokenKind.Div] = new TokenInfo(TokenKind.Div, "/"),
            [TokenKind.Mod] = new TokenInfo(TokenKind.Mod, "%"),
            [TokenKind.DivRem] = new TokenInfo(TokenKind.DivRem, "/%"),
            [TokenKind.Shl] = new TokenInfo(TokenKind.Shl, "<<"),
            [TokenKind.Shr] = new TokenInfo(TokenKind.Shr, ">>"),
            [TokenKind.UShr] = new TokenInfo(TokenKind.UShr, ">>>"),
            [TokenKind.BitAnd] = new TokenInfo(TokenKind.BitAnd, "&"),
            [TokenKind.BitOr] = new TokenInfo(TokenKind.BitOr, "|"),
            [TokenKind.BitXor] = new TokenInfo(TokenKind.BitXor, "^"),
            [TokenKind.BitNot] = new TokenInfo(TokenKind.BitNot, "~"),
            [TokenKind.Not] = new TokenInfo(TokenKind.Not, "!"),

            [TokenKind.CondAnd] = new TokenInfo(TokenKind.Assign, "&&"),
            [TokenKind.CondXor] = new TokenInfo(TokenKind.Assign, "^^"),
            [TokenKind.CondOr] = new TokenInfo(TokenKind.Assign, "||"),
            [TokenKind.CondElse] = new TokenInfo(TokenKind.Assign, "?:"),
            [TokenKind.Assign] = new TokenInfo(TokenKind.Assign, "="),

            [TokenKind.AddAssign] = new TokenInfo(TokenKind.AddAssign, "+="),
            [TokenKind.SubAssign] = new TokenInfo(TokenKind.SubAssign, "-="),
            [TokenKind.MulAssign] = new TokenInfo(TokenKind.MulAssign, "*="),
            [TokenKind.DivAssign] = new TokenInfo(TokenKind.DivAssign, "/="),
            [TokenKind.ModAssign] = new TokenInfo(TokenKind.ModAssign, "%="),
            [TokenKind.ShlAssign] = new TokenInfo(TokenKind.ShlAssign, "<<="),
            [TokenKind.ShrAssign] = new TokenInfo(TokenKind.ShrAssign, ">>="),
            [TokenKind.UShrAssign] = new TokenInfo(TokenKind.UShrAssign, ">>>="),
            [TokenKind.BitAndAssign] = new TokenInfo(TokenKind.BitAndAssign, "&="),
            [TokenKind.BitOrAssign] = new TokenInfo(TokenKind.BitOrAssign, "|="),
            [TokenKind.BitXorAssign] = new TokenInfo(TokenKind.BitXorAssign, "^="),
            [TokenKind.CondAndAssign] = new TokenInfo(TokenKind.CondAndAssign, "&&="),
            [TokenKind.CondOrAssign] = new TokenInfo(TokenKind.CondOrAssign, "||="),
            [TokenKind.CondAssign] = new TokenInfo(TokenKind.CondAssign, ":="),
            [TokenKind.CondNotNullAssign] = new TokenInfo(TokenKind.CondNotNullAssign, "?="),
            [TokenKind.CondElseAssign] = new TokenInfo(TokenKind.CondElseAssign, "?:="),

            [TokenKind.CompEQ] = new TokenInfo(TokenKind.CompEQ, "=="),
            [TokenKind.CompNE] = new TokenInfo(TokenKind.CompNE, "!="),
            [TokenKind.CompOrder] = new TokenInfo(TokenKind.CompOrder, "<=>"),
            [TokenKind.CompLT] = new TokenInfo(TokenKind.CompLT, "<"),
            [TokenKind.CompLE] = new TokenInfo(TokenKind.CompLE, "<="),
            [TokenKind.CompGT] = new TokenInfo(TokenKind.CompGT, ">"),
            [TokenKind.CompGE] = new TokenInfo(TokenKind.CompGE, ">="),
            [TokenKind.Inc] = new TokenInfo(TokenKind.CompGE, "++"),
            [TokenKind.Dec] = new TokenInfo(TokenKind.CompGE, "--"),
            [TokenKind.Lambda] = new TokenInfo(TokenKind.CompGE, "->"),
            [TokenKind.Any] = new TokenInfo(TokenKind.CompGE, "_"),

            [TokenKind.Allow] = new TokenInfo(TokenKind.Allow, "allow", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.As] = new TokenInfo(TokenKind.As, "as", category: TokenCategory.Keyword),
            [TokenKind.Assert] = new TokenInfo(TokenKind.Assert, "assert", category: TokenCategory.Keyword),
            [TokenKind.AssertRandom] = new TokenInfo(TokenKind.AssertRandom, "assert:rnd", category: TokenCategory.Keyword),
            [TokenKind.AssertArg] = new TokenInfo(TokenKind.AssertArg, "assert:arg", category: TokenCategory.Keyword),
            [TokenKind.AssertBounds] = new TokenInfo(TokenKind.AssertBounds, "assert:bounds", category: TokenCategory.Keyword),
            [TokenKind.AssertTodo] = new TokenInfo(TokenKind.AssertTodo, "assert:TODO", category: TokenCategory.Keyword),
            [TokenKind.AssertOnce] = new TokenInfo(TokenKind.AssertOnce, "assert:once", category: TokenCategory.Keyword),
            [TokenKind.AssertTest] = new TokenInfo(TokenKind.AssertTest, "assert:test", category: TokenCategory.Keyword),
            [TokenKind.AssertDebug] = new TokenInfo(TokenKind.AssertDebug, "assert:debug", category: TokenCategory.Keyword),
            [TokenKind.Avoid] = new TokenInfo(TokenKind.Conditional, "avoid", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Break] = new TokenInfo(TokenKind.Conditional, "break", category: TokenCategory.Keyword),
            [TokenKind.Case] = new TokenInfo(TokenKind.Conditional, "case", category: TokenCategory.Keyword),
            [TokenKind.Catch] = new TokenInfo(TokenKind.Conditional, "catch", category: TokenCategory.Keyword),
            [TokenKind.Class] = new TokenInfo(TokenKind.Conditional, "class", category: TokenCategory.Keyword),
            [TokenKind.Conditional] = new TokenInfo(TokenKind.Conditional, "conditional", category: TokenCategory.Keyword),
            [TokenKind.Const] = new TokenInfo(TokenKind.Const, "const", category: TokenCategory.Keyword),
            [TokenKind.Construct] = new TokenInfo(TokenKind.Construct, "construct", category: TokenCategory.Keyword),
            [TokenKind.Continue] = new TokenInfo(TokenKind.Continue, "continue", category: TokenCategory.Keyword),
            [TokenKind.Default] = new TokenInfo(TokenKind.Default, "default", category: TokenCategory.Keyword),
            [TokenKind.Delegates] = new TokenInfo(TokenKind.Delegates, "delegates", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Do] = new TokenInfo(TokenKind.Do, "do", category: TokenCategory.Keyword),
            [TokenKind.Else] = new TokenInfo(TokenKind.Else, "else", category: TokenCategory.Keyword),
            [TokenKind.Enum] = new TokenInfo(TokenKind.Enum, "enum", category: TokenCategory.Keyword),
            [TokenKind.Extends] = new TokenInfo(TokenKind.Extends, "extends", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Finally] = new TokenInfo(TokenKind.Finally, "finally", category: TokenCategory.Keyword),
            [TokenKind.For] = new TokenInfo(TokenKind.For, "for", category: TokenCategory.Keyword),
            [TokenKind.Function] = new TokenInfo(TokenKind.Function, "function", category: TokenCategory.Keyword),
            [TokenKind.If] = new TokenInfo(TokenKind.If, "if", category: TokenCategory.Keyword),
            [TokenKind.Immutable] = new TokenInfo(TokenKind.Immutable, "immutable", category: TokenCategory.Keyword),
            [TokenKind.Implements] = new TokenInfo(TokenKind.Implements, "implements", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Import] = new TokenInfo(TokenKind.Import, "import", category: TokenCategory.Keyword),
            [TokenKind.ImportEmbedded] = new TokenInfo(TokenKind.ImportEmbedded, "import:embedded", category: TokenCategory.Keyword),
            [TokenKind.ImportRequired] = new TokenInfo(TokenKind.ImportRequired, "import:required", category: TokenCategory.Keyword),
            [TokenKind.ImportDesired] = new TokenInfo(TokenKind.ImportDesired, "import:desired", category: TokenCategory.Keyword),
            [TokenKind.ImportOptional] = new TokenInfo(TokenKind.ImportOptional, "import:optional", category: TokenCategory.Keyword),
            [TokenKind.Incorporates] = new TokenInfo(TokenKind.Incorporates, "incorporates", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.In] = new TokenInfo(TokenKind.In, "in", category: TokenCategory.Keyword),
            [TokenKind.Interface] = new TokenInfo(TokenKind.Interface, "interface", category: TokenCategory.Keyword),
            [TokenKind.Into] = new TokenInfo(TokenKind.Into, "into", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Is] = new TokenInfo(TokenKind.Is, "is", category: TokenCategory.Keyword),
            [TokenKind.Mixin] = new TokenInfo(TokenKind.Mixin, "mixin", category: TokenCategory.Keyword),
            [TokenKind.Module] = new TokenInfo(TokenKind.Module, "module", category: TokenCategory.Keyword),
            [TokenKind.New] = new TokenInfo(TokenKind.New, "new", category: TokenCategory.Keyword),
            [TokenKind.Out] = new TokenInfo(TokenKind.Out, "out", category: TokenCategory.Keyword),
            [TokenKind.Outer] = new TokenInfo(TokenKind.Outer, "outer", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Package] = new TokenInfo(TokenKind.Package, "package", category: TokenCategory.Keyword),
            [TokenKind.Prefer] = new TokenInfo(TokenKind.Prefer, "prefer", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Private] = new TokenInfo(TokenKind.Private, "private", category: TokenCategory.Keyword),
            [TokenKind.Protected] = new TokenInfo(TokenKind.Protected, "protected", category: TokenCategory.Keyword),
            [TokenKind.Public] = new TokenInfo(TokenKind.Public, "public", category: TokenCategory.Keyword),
            [TokenKind.Return] = new TokenInfo(TokenKind.Return, "return", category: TokenCategory.Keyword),
            [TokenKind.Service] = new TokenInfo(TokenKind.Service, "service", category: TokenCategory.Keyword),
            [TokenKind.Static] = new TokenInfo(TokenKind.Static, "static", category: TokenCategory.Keyword),
            [TokenKind.Struct] = new TokenInfo(TokenKind.Struct, "struct", category: TokenCategory.Keyword),
            [TokenKind.Super] = new TokenInfo(TokenKind.Super, "super", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Switch] = new TokenInfo(TokenKind.Switch, "switch", category: TokenCategory.Keyword),
            [TokenKind.This] = new TokenInfo(TokenKind.This, "this", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisClass] = new TokenInfo(TokenKind.ThisClass, "this:class", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisModule] = new TokenInfo(TokenKind.ThisModule, "this:module", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisPrivate] = new TokenInfo(TokenKind.ThisPrivate, "this:private", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisProtected] = new TokenInfo(TokenKind.ThisProtected, "this:protected", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisPublic] = new TokenInfo(TokenKind.ThisPublic, "this:public", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisService] = new TokenInfo(TokenKind.ThisService, "this:service", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisStruct] = new TokenInfo(TokenKind.ThisStruct, "this:struct", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.ThisTarget] = new TokenInfo(TokenKind.ThisTarget, "this:target", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Throw] = new TokenInfo(TokenKind.Throw, "throw", category: TokenCategory.Keyword),
            [TokenKind.Todo] = new TokenInfo(TokenKind.Todo, "TODO", category: TokenCategory.Keyword),
            [TokenKind.Try] = new TokenInfo(TokenKind.Try, "try", category: TokenCategory.Keyword),
            [TokenKind.Typedef] = new TokenInfo(TokenKind.Typedef, "typedef", category: TokenCategory.Keyword),
            [TokenKind.Using] = new TokenInfo(TokenKind.Using, "using", category: TokenCategory.Keyword),
            [TokenKind.Val] = new TokenInfo(TokenKind.Val, "val", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Var] = new TokenInfo(TokenKind.Var, "var", category: TokenCategory.ContextSensitiveKeyword),
            [TokenKind.Void] = new TokenInfo(TokenKind.Void, "void", category: TokenCategory.Keyword),
            [TokenKind.While] = new TokenInfo(TokenKind.While, "while", category: TokenCategory.Keyword),

            [TokenKind.LIdentifier] = new TokenInfo(TokenKind.LIdentifier, string.Empty),
            [TokenKind.UIdentifier] = new TokenInfo(TokenKind.UIdentifier, string.Empty),
            [TokenKind.LineComment] = new TokenInfo(TokenKind.LineComment, string.Empty),
            [TokenKind.MultiComment] = new TokenInfo(TokenKind.MultiComment, string.Empty),
            [TokenKind.StringLiteral] = new TokenInfo(TokenKind.StringLiteral, string.Empty),
            [TokenKind.LitBit] = new TokenInfo(TokenKind.LitBit, string.Empty),
            [TokenKind.LitNibble] = new TokenInfo(TokenKind.LitNibble, string.Empty),
            [TokenKind.LitChar] = new TokenInfo(TokenKind.LitChar, string.Empty),
            [TokenKind.LitBinString] = new TokenInfo(TokenKind.LitBinString, string.Empty),
            [TokenKind.LitInt] = new TokenInfo(TokenKind.LitInt, string.Empty),

            [TokenKind.BOF] = new TokenInfo(TokenKind.BOF, "<bof>"),
            [TokenKind.EOF] = new TokenInfo(TokenKind.EOF, "<eof>"),
        };

        public static void Validate()
        {
            foreach (var kind in Enum.GetValues<TokenKind>())
            {
                if (!Info.ContainsKey(kind))
                {
                    throw new MissingMemberException($"missing info for {nameof(TokenKind)}.{kind}.");
                }
            }
        }
    }

    public enum TokenKind
    {
        Colon,                      // :
        SemiColon,                  // ;
        Comma,                      // ,
        Dot,                        // .
        DotDot,                     // ..
        Elipsis,                    // ...
        CurrentDir,                 // ./
        ParentDir,                  // ../
        StringFile,                 // $
        BinaryFile,                 // #
        At,                         // @
        Cond,                       // ?
        LeftParen,                  // (
        RightParen,                 // )
        LeftCurly,                  // {
        RightCurly,                 // }
        LeftSquare,                 // [
        RightSquare,                // ]
        Add,                        // +
        Sub,                        // -
        Mul,                        // *
        Div,                        // /
        Mod,                        // %
        DivRem,                     // /%
        Shl,                        // <<
        Shr,                        // >>
        UShr,                       // >>>
        BitAnd,                     // &
        BitOr,                      // |
        BitXor,                     // ^
        BitNot,                     // ~
        Not,                        // !

        CondAnd,                    // &&
        CondXor,                    // ^^
        CondOr,                     // ||
        CondElse,                   // :?
        Assign,                     // '='
        AddAssign,                  // '+='
        SubAssign,                  // '-='
        MulAssign,                  // '*='
        DivAssign,                  // '/='
        ModAssign,                  // '%='
        ShlAssign,                  // '<<='
        ShrAssign,                  // '>>='
        UShrAssign,                 // '>>>='
        BitAndAssign,               // '&='
        BitOrAssign,                // '|='
        BitXorAssign,               // '^='
        CondAndAssign,              // '&&='
        CondOrAssign,               // '||='
        CondAssign,                 // ':='
        CondNotNullAssign,          // '?='
        CondElseAssign,             // '?:='

        CompEQ,                     // ==
        CompNE,                     // !=
        CompOrder,                  // <=>
        CompLT,                     // <
        CompLE,                     // <=
        CompGT,                     // >
        CompGE,                     // >=
        Inc,                        // ++
        Dec,                        // --
        Lambda,                     // ->
        Any,                        // _

        Allow,
        As,
        Assert,
        AssertRandom,
        AssertArg,
        AssertBounds,
        AssertTodo,
        AssertOnce,
        AssertTest,
        AssertDebug,
        Avoid,
        Break,
        Case,
        Catch,
        Class,
        Conditional,
        Const,
        Construct,
        Continue,
        Default,
        Delegates,
        Do,
        Else,
        Enum,
        Extends,
        Finally,
        For,
        Function,
        If,
        Immutable,
        Implements,
        Import,
        ImportEmbedded,
        ImportRequired,
        ImportDesired,
        ImportOptional,
        Incorporates,
        In,
        Interface,
        Into,
        Is,
        Mixin,
        Module,
        New,
        Out,
        Outer,
        Package,
        Prefer,
        Private,
        Protected,
        Public,
        Return,
        Service,
        Static,
        Struct,
        Super,
        Switch,
        This,
        ThisClass,
        ThisModule,
        ThisPrivate,
        ThisProtected,
        ThisPublic,
        ThisService,
        ThisStruct,
        ThisTarget,
        Throw,
        Todo,
        Try,
        Typedef,
        Using,
        Val,
        Var,
        Void,
        While,

        LIdentifier,
        UIdentifier,
        LineComment,
        MultiComment,
        LitBit,
        LitNibble,
        LitChar,
        StringLiteral,
        LitBinString,
        LitInt,


        BOF,
        EOF,
    }
}
