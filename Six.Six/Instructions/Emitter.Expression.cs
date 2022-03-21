using Six.Six.Sema;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        private void Handle(Expr expr)
        {
            Assert(false);
        }

        private void Handle(Expr.ToDo expr)
        {
            foreach (var ex in expr.Exprs)
            {
                Emit(ex);
            }
            Emit(Insn.ToDo(expr.Text));
        }

        private void Handle(Expr.CallConstructor expr)
        {
            var alloc = Module.CoreFindFunction(Module.Allocator);

            Emit(Insn.U32.Const(expr.Class.Layout.Size));
            Emit(new Expr.CallFunction(alloc));
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            Emit(Insn.Call(expr.Ctor.FullName));
        }

        private void Handle(Expr.CallFunction expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            Emit(Insn.Call(expr.Function.FullName));
        }

        private void Handle(Expr.CallMember expr)
        {
            Emit(expr.Make);
            foreach (var arg in expr.Arguments)
            {
                Emit(arg);
            }
            Emit(Insn.Call(expr.Function.FullName));
        }

        private void Handle(Expr.CallInfixMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var b = Builtins.Resolve(expr.Classy);
                var m = b.Infix(expr.Function.Name.Text)(expr.Arg1, expr.Arg2);

                Emit(m);
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg1, expr.Arg2);
                Emit(callMember);
            }
        }

        private void Handle(Expr.CallPrefixMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var b = Builtins.Resolve(expr.Classy);
                var m = b.Prefix(expr.Function.Name.Text)(expr.Arg);

                Emit(m);
            }
            else
            {
                Emit(expr.Arg);
                Emit(Insn.ToDo("call-prefix-member"));
            }
        }

        private void Handle(Expr.CallIndirect expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Emit(argument);
            }
            var callable = expr.Callable;

            Emit(expr.Value);
            Emit(Insn.CallIndirect(globalFunctionsTableName, TypeFor(callable)));
        }

        private void Handle(Expr.If expr)
        {
            Emit(expr.Condition);
            wl($"{Insn.If} {Result(expr.Then.Type)}");
            indent(() => Emit(expr.Then));
            wl($"{Insn.Else}");
            indent(() => Emit(expr.Else));
            wl($"{Insn.End}");
        }


        private void Handle(Expr.Binop expr)
        {
            Emit(expr.Arg1);
            Emit(expr.Arg2);
            Emit(expr.Insn);
        }

        private void Handle(Expr.Const expr)
        {
            Emit(expr.Insn);
        }

        private void Handle(Expr.ConstString expr)
        {
            Emit(expr.Resolve().Insn);
        }

        private void Handle(Expr.LocalReference expr)
        {
            Emit(Insn.Local.Get(expr.LocalDecl.Index));
        }

        private void Handle(Expr.GlobalReference expr)
        {
            Emit(Insn.Global.Get(expr.Decl.FullName));
        }

        private void Handle(Expr.ParameterReference expr)
        {
            Emit(Insn.Local.Get(expr.ParameterDecl.Index));
        }

        private void Handle(Expr.FunctionReference expr)
        {
            var function = expr.FunctionDecl;
            var name = function.FullName;

            var index = GlobalFunctions.Add(function, name);
            Emit(Insn.U32.Const(index));
        }

        private void Handle(Expr.ObjectReference expr)
        {
            if (expr.Decl.IsNative)
            {
                if (expr.Decl.FullName == "six.core.true")
                {
                    Emit(Insn.Boolean.True);
                    return;
                }
                if (expr.Decl.FullName == "six.core.false")
                {
                    Emit(Insn.Boolean.False);
                    return;
                }
            }

            Assert(false);
        }

        private void Handle(Expr.SelectAttribute expr)
        {
            Emit(expr.Reference);
            Emit(expr.Attribute);
            Emit(Insn.ToDo("GET attribute from classy"));
        }

        private void Handle(Expr.AttributeReference expr)
        {
            Emit(Insn.ToDo("GET attribute from reference"));
        }

        private void Handle(Expr.FieldReference expr)
        {
            Emit(Insn.ToDo("GET field from reference"));
        }

        private void Handle(Expr.SelectField expr)
        {
            Emit(expr.Reference);
            Emit(Lower(expr.Field.Type).Load(expr.Field.Offset));
        }
    }
}
