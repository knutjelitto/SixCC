using Six.Runtime.Types;

namespace Six.Ceylon.Ast
{
    public class NaturalNumber : Expr
    {
        //TODO

        public NaturalNumber(RToken token)
        {
            Token = token;
        }

        public RToken Token { get; }
    }
}
