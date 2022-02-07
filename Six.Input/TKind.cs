using System.ComponentModel;

namespace Six.Input
{
    internal enum TKind
    {
        [Description("<eof>")] EOF,

        [Description("name")] Name,
        [Description("literal")] Literal,
        [Description("epsilon")] Epsilon,
        [Description("..")] Range,

        [Description("(")] LeftParent,
        [Description(")")] RightParent,
        [Description("[")] LeftBracket,
        [Description("]")] RightBracket,
        [Description("{")] LeftCurly,
        [Description("}")] RightCurly,
        [Description("<")] LeftAngle,
        [Description(">")] RightAngle,

        [Description(":")] Colon,
        [Description("::")] DefColon,
        [Description("=")] Assign,
        [Description(";")] Semi,
        [Description("|")] Alter,
        [Description("?")] Option,
        [Description("~")] Complement,
        [Description("!")] Not,
        [Description("*")] Star,
        [Description("+")] Plus,
        [Description("-")] Minus,
        [Description(".")] Any,
    }
}
