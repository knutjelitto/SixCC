using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public class FloatNumber : Expr
    {
        //TODO

        public FloatNumber(RToken token)
        {
            Token = token;
        }

        public RToken Token { get; }
    }
}
