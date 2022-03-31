using Six.Core;
using Six.Six.Sema;
using Six.Six.Types;
using Six.Six.Wasms;
using Six.Six.Wasms.Instructions;
using System;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public class WaInstructeur
    {
        private Stack<WaInstructionList> instructions = new();

        public WaInstructeur(WaModule module, Decl.Funcy funcy, WaFunction function)
        {
            Module = module;
            Funcy = funcy;
            Function = function;
        }

        public WaModule Module { get; }
        public Builtins Builtins => Module.SemaModule.Builtins;
        public Emitter Emitter => Module.SemaModule.Emitter;
        public Decl.Funcy Funcy { get; }
        public WaFunction Function { get; }

        private WaInstructionList Current => instructions.Peek();

        private IDisposable Into(WaInstructionList list)
        {
            instructions.Push(list);

            return new Disposable(() => instructions.Pop());
        }

        private string TypeFor(Sema.Type.Callable callable)
        {
            var signature = WaFuncSignature.From(
                callable.Parameters.Select(p => Emitter.Lower(p).Wasm),
                Emitter.Lower(callable.Result).Wasm);

            var type = Module.FunctionTypes.Get(signature).Name;

            return type;
        }

        public void Walk()
        {
            instructions.Push(Function.Instructions);
            foreach (var member in Funcy.Block.Members)
            {
                Walk(member);
            }
            instructions.Pop();
        }

        public void Walk(Entity entity)
        {
            Build((dynamic)entity);
        }

        private void Add(WaInstruction instruction)
        {
            Current.Add(instruction);
        }

        private void Add(Insn instruction)
        {
            Add(new WiInsn(Function, instruction));
        }

        private void Build(Entity entity)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Build(Decl.LetVar decl)
        {
            Walk(decl.Value);
            Add(Insn.Local.Set(decl.Index));
        }

        private void Build(Decl.Funcy decl)
        {
            // NOP - handled elsewhere
        }

        private void Build(Decl.Parameter decl)
        {
            // NOP
        }

        private void Build(Decl.SelfParameter decl)
        {
            // NOP
        }

        private void Build(Stmt.Return stmt)
        {
            if (stmt.Expr != null)
            {
                Walk(stmt.Expr);
            }
            Add(Insn.Return);
        }

        private void Build(Stmt.Assign stmt)
        {
            switch (stmt.Left)
            {
                case Expr.SelectField select:
                    Walk(select.Reference);
                    Walk(stmt.Right);
                    Add(Emitter.Lower(select.Field.Type).Store(select.Field.Offset));
                    return;
                case Expr.GlobalReference globalReference:
                    Walk(stmt.Right);
                    Add(Insn.Global.Set(globalReference.Decl.FullName));
                    return;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private void Build(Expr.If expr)
        {
            var condition = new WaInstructionList();
            var then = new WaInstructionList();
            var @else = new WaInstructionList();
            var type1 = Emitter.Lower(expr.Then.Type).Wasm;
            var type2 = Emitter.Lower(expr.Else.Type).Wasm;
            Assert(type1 == type2);

            using (Into(condition))
            {
                Walk(expr.Condition);
            }

            using (Into(then))
            {
                Walk(expr.Then);
            }

            using (Into(@else))
            {
                Walk(expr.Else);
            }

            Add(new WiIfBlock(Function, type1, condition, then, @else));
        }

        private void Build(Expr.GlobalReference expr)
        {
            Add(Insn.Global.Get(expr.Decl.FullName));
        }

        private void Build(Expr.LocalReference expr)
        {
            Add(Insn.Local.Get(expr.LocalDecl.Index));
        }

        private void Build(Expr.ParameterReference expr)
        {
            Add(Insn.Local.Get(expr.ParameterDecl.Index));
        }

        private void Build(Expr.FunctionReference expr)
        {
            Assert(expr.Decl.Validated);

            var funcy = expr.FunctionDecl;
            var name = funcy.FullName;

            var function = WaFunction.From(Module, funcy.FullName);

            var index = Module.GlobalFunctions.Add(function, name);

            Add(Insn.U32.Const(index));
        }

        private void Build(Expr.CallNativeConstructor expr)
        {
            Assert(expr.Ctor.IsNative);

            var builtin = Builtins.Resolve(expr.Class);
            var method = builtin.Method(expr.Ctor.Name, expr.Arguments.Count);
            var emit = method(expr.Arguments);
            Walk(emit);
        }

        private void Build(Expr.CallInfixMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var b = Builtins.Resolve(expr.Classy);
                var m = b.Infix(expr.Function.Name)(expr.Arg1, expr.Arg2);

                Walk(m);
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg1, expr.Arg2);
                Walk(callMember);
            }
        }

        private void Build(Expr.CallPrefixMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var b = Builtins.Resolve(expr.Classy);
                var m = b.Prefix(expr.Function.Name)(expr.Arg);

                Walk(m);
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg);
                Walk(callMember);
            }
        }


        private void Build(Expr.CallMember expr)
        {
            if (expr.Classy.IsNative && expr.Function.IsNative)
            {
                var builtin = Builtins.Resolve(expr.Classy);
                var method = builtin.Method(expr.Function.Name, expr.Arguments.Count);
                var emit = method(expr.Arguments);
                Walk(expr.Make);
                Walk(emit);
            }
            else
            {
                Walk(expr.Make);
                foreach (var arg in expr.Arguments)
                {
                    Walk(arg);
                }
                Add(Insn.Call(expr.Function.FullName));
            }
        }

        private void Build(Expr.CallStaticFunction expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }
            Add(Insn.Call(expr.Funcy.FullName));
        }

        private void Build(Expr.CallConstructor expr)
        {
            Add(Insn.Ptr.Push(expr.Class.Layout.MetaPtr()));
            Add(Insn.Call(Sema.Module.CoreClassAlloc));

            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }
            Add(Insn.Call(expr.Ctor.FullName));
        }

        private void Build(Expr.CallIndirect expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }
            Walk(expr.Value);
            Add(Insn.CallIndirect(Module.GlobalFunctions.Name, TypeFor(expr.Callable)));
        }

        private void Build(Expr.SelectAttribute expr)
        {
            Walk(expr.Reference);

            var funcy = expr.Attribute;

            if (funcy.IsStatic || funcy.IsLocalFunction || funcy.IsGlobalFunction)
            {
                Add(Insn.Call(expr.Attribute.FullName));
            }
            else if (funcy.IsObjectMember)
            {
                if (expr.Attribute.IsDynamic)
                {
                    Assert(expr.ScratchLocal >= 0);
                    Add(Insn.Local.Tee(expr.ScratchLocal));
                    var slot = expr.Classy.Slot(expr.Attribute);
                    if (slot != null)
                    {
                        Add(Insn.Local.Get(expr.ScratchLocal));
                        Add(Insn.U32.Load(4));
                        Add(Insn.U32.Const((uint)slot.Index));
                        Add(Insn.U32.Add);
                        Add(Insn.CallIndirect(Sema.Module.DispatchFunctions, TypeFor(expr.Attribute.CallableType)));
                    }
                    else
                    {
                        Assert(false);
                        throw new NotImplementedException();
                    }
                }
                else
                {
                    Assert(false);
                    throw new NotImplementedException();
                }
            }
            else
            {
                Assert(false);
                throw new NotImplementedException();
            }
        }

        private void Build(Primitive.Binop primitive)
        {
            Walk(primitive.Arg1);
            Walk(primitive.Arg2);
            Add(primitive.Insn);
        }

        private void Build(Primitive.Arged primitive)
        {
            Walk(primitive.Arg);
        }

        private void Build(Primitive.ConstU32 primitive)
        {
            Add(primitive.Insn);
        }

        private void Build(Primitive.ConstS32 primitive)
        {
            Add(primitive.Insn);
        }

        private void Build(Primitive.ConstString primitive)
        {
            Add(primitive.Insn);
        }
    }
}
