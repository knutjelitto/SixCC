using Six.Six.Builtins;
using Six.Six.Sema;
using System;
using Type = Six.Six.Sema.Type;

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

        private void Handle(Expr.Instructions insns)
        {
            foreach (var insn in insns.Insns)
            {
                Emit(insn);
            }
        }


        private void Handle(Expr.Arged arged)
        {
            Emit(arged.Arg);
        }

        private void Handle(Expr.CallNativeConstructor expr)
        {
            Assert(expr.Ctor.IsNative);

            var builtin = Builtins.Resolve(expr.Class);
            var method = builtin.Method(expr.Ctor.Name, expr.Arguments.Count);
            var emit = method(expr.Arguments);
            Emit(emit);
        }

        private void Handle(Expr.CallConstructor expr)
        {
            Emit(Insn.Ptr.Push(expr.Class.Layout.MetaPtr()));
            Emit(Insn.Call(Module.CoreClassAlloc));

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
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var builtin = Builtins.Resolve(expr.Classy);
                var method = builtin.Method(expr.Function.Name, expr.Arguments.Count);
                var emit = method(expr.Arguments);
                Emit(expr.Make);
                Emit(emit);
            }
            else
            {
                Emit(expr.Make);
                foreach (var arg in expr.Arguments)
                {
                    Emit(arg);
                }
                Emit(Insn.Call(expr.Function.FullName));
            }
        }

        private void Handle(Expr.CallInfixMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var b = Builtins.Resolve(expr.Classy);
                var m = b.Infix(expr.Function.Name)(expr.Arg1, expr.Arg2);

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
                var m = b.Prefix(expr.Function.Name)(expr.Arg);

                Emit(m);
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg);
                Emit(callMember);
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
            Emit(Insn.CallIndirect(GlobalFunctions.Name, TypeFor(callable)));
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

        private void Handle(Expr.Unop expr)
        {
            Emit(expr.Arg);
            Emit(expr.Insn);
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
            Assert(expr.Decl.Validated);

            var function = expr.FunctionDecl;
            var name = function.FullName;

            var index = GlobalFunctions.Add(function, name);
            Emit(Insn.U32.Const(index));
        }

        private void Handle(Expr.ClassReference expr)
        {
            Assert(expr.ClassDecl.Validated);

            Assert(false);
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

            if (expr.Attribute.IsDynamic)
            {
                Assert(expr.ScratchLocal >= 0);
                Emit(Insn.Local.Tee(expr.ScratchLocal));
                var slot = expr.Classy.Layout.Slots.Where(s => s.Funcy.Name == expr.Attribute.Name).SingleOrDefault();
                if (slot != null)
                {
                    Emit(Insn.Local.Get(expr.ScratchLocal));
                    Emit(Insn.U32.Load(0));
                    Emit(Insn.U32.Load((uint)slot.Index * WasmDef.I32.Size));
                    Emit(Insn.CallIndirect(Module.ModuleFunctions, TypeFor((Type.Callable)expr.Attribute.Type)));
                }
                else
                {
                    Assert(false);
                    throw new NotImplementedException();
                }
            }
            else
            {
                Emit(Insn.Call(expr.Attribute.FullName));
            }
        }

        private void Handle(Expr.AttributeReference expr)
        {
            Emit(Insn.ToDo("GET attribute from reference"));
        }

        private void Handle(Expr.FieldReference expr)
        {
            // TODO: must be in method ??
            Assert(!expr.FieldDecl.IsStatic);
            Emit(Insn.Local.Get(0));
            Emit(Lower(expr.FieldDecl.Type).Load(expr.FieldDecl.Offset));
        }

        private void Handle(Expr.SelectField expr)
        {
            Emit(expr.Reference);
            Emit(Lower(expr.Field.Type).Load(expr.Field.Offset));
        }
    }
}
