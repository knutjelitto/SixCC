using Six.Six.Sema;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        private void Handle(Expression expr)
        {
            Assert(false);
        }

        private void Handle(Expression.If expr)
        {
            Emit(expr.Condition.Expr);
            wl($"{Insn.If} {Result(expr.Then.Expr.Type)}");
            indent(() => Emit(expr.Then.Expr));
            wl($"{Insn.Else}");
            indent(() => Emit(expr.Else.Expr));
            wl($"{Insn.End}");
        }


        private void Handle(Expression.Binop expr)
        {
            Emit(expr.Arg1);
            Emit(expr.Arg2);
            wl($"{expr.Insn}");
        }

        private void Handle(Expression.Const expr)
        {
            wl($"{expr.Insn}");
        }

        private void Handle(Expression.LocalReference expr)
        {
            wl($"{Insn.Local.Get(expr.LocalDecl.Index)}");
        }

        private void Handle(Expression.ParameterReference expr)
        {
            wl($"{Insn.Local.Get(expr.ParameterDecl.Index)}");
        }

        private void Handle(Expression.FunctionReference expr)
        {
            var function = expr.FunctionDecl;
            var name = function.FullName;

            uint index;
            if (!globalFunctionsTable.TryGetValue(name, out var entry))
            {
                index = (uint)globalFunctionsTable.Count;
                globalFunctionsTable.Add(name, (index, function));
            }
            else
            {
                index = entry.index;
            }

            wl($"{Insn.U32.Const(index)}");
        }

        private void Handle(Expression.SelectAttribute expr)
        {
            wl($"TODO: select attribute");
        }

        private void Handle(Expression.CallFunction expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            wl($"{Insn.Call(expr.Function.FunctionDecl.FullName)}");
        }

        private void Handle(Expression.CallIndirect expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            var callable = expr.Callable;

            Emit(expr.Value);
            wl($"{Insn.CallIndirect(globalFunctionsTableName)} (type {FindType(callable)})");
        }
    }
}
