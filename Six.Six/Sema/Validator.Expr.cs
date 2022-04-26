using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public partial class Validator
    {
        private void Validate(Expr expr)
        {
            Expr((dynamic)expr);
        }

        private void Expr(Expr expr)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Expr(Expr.SelectField expr)
        {
            Walk(expr.Reference);

            Assert(slip);
        }

        private void Expr(Expr.CallConstructor expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallStaticFunction expr)
        {
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallDynamicFunction expr)
        {
            Walk(expr.Reference);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallMemberFunction expr)
        {
            Walk(expr.Reference);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallIndirect expr)
        {
            Walk(expr.Value);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallMember expr)
        {
            Walk(expr.Make);
            Walk(expr.Arguments);

            Assert(slip);
        }

        private void Expr(Expr.CallPrefixMember expr)
        {
            Walk(expr.Arg);

            Assert(slip);
        }

        private void Expr(Expr.CallInfixMember expr)
        {
            Walk(expr.Arg1);
            Walk(expr.Arg2);

            Assert(slip);
        }

        private void Expr(Expr.If expr)
        {
            Walk(expr.Condition);
            Walk(expr.Then);
            Walk(expr.Else);

            Assert(slip);
        }

        private void Expr(Expr.Reference expr)
        {
            Assert(slip);
        }

        private void Expr(Primitive.ConstS32 expr)
        {
            // -- bottom
        }

        private void Expr(Primitive.ConstU32 expr)
        {
            // -- bottom
        }

        private void Expr(Primitive.ConstString expr)
        {
            // -- bottom
        }

        private void Expr(Primitive.ConstNatural expr)
        {
            // -- bottom
        }
    }
}
