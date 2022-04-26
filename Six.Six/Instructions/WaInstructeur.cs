using System;

using Six.Core;
using Six.Six.Sema;
using Six.Six.Types;
using Six.Six.Wasms;
using Six.Six.Wasms.Instructions;
using Type = Six.Six.Sema.Type;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public class WaInstructeur
    {
        private readonly Stack<WaInstructionList> instructionsStack = new();

        public WaInstructeur(WaModule module)
        {
            Module = module;
        }

        public WaModule Module { get; }
        public TypeResolver TypeResolver => Module.SemaModule.Resolver.T;
        public WaFunction? Function { get; private set; }

        private WaInstructionList Current => instructionsStack.Peek();

        public Builtin Resolve(Decl named)
        {
            return Module.SemaModule.Builtins.Resolve(named);
        }

        public Builtin Lower(Type type)
        {
            return TypeResolver.Lower(type);
        }

        private IDisposable Into(WaInstructionList list)
        {
            instructionsStack.Push(list);

            return new Disposable(() => instructionsStack.Pop());
        }

        private WaInstructionList Nested(Expr expr)
        {
            var instructions = new WaInstructionList(Module);

            using (Into(instructions))
            {
                Walk(expr);
            }

            return instructions;
        }

        private WaInstructionList Nested(CodeBlock block)
        {
            var instructions = new WaInstructionList(Module);

            using (Into(instructions))
            {
                foreach (var stmt in block.Stmts)
                {
                    Walk(stmt);
                }
            }

            return instructions;
        }

        private string TypeFor(Type.Callable callable)
        {
            var signature = WaFuncSignature.From(
                callable.Parameters.Select(p => Lower(p).Wasm),
                Lower(callable.Result).Wasm);

            var type = Module.FunctionTypes.Get(signature).Name;

            return $"(type ${type})";
        }

        public void Walk(WaFunction function, Decl.Funcy funcy)
        {
            using (Into(function.Instructions))
            {
                Function = function;

                if (funcy is Decl.Constructor ctor && ctor.Parent is ClassBlock classBlock && classBlock.Classy is Decl.Class clazz && !clazz.IsNative)
                {
                    Add(Insn.Local.Get(0));
                    Add(Insn.Call($"{clazz.FullName}.{Sema.Module.InitCtor}"));
                }

                var stmts = funcy.Block.CodeBlock.Stmts;

                foreach (var stmt in stmts)
                {
                    Walk(stmt);
                }

                if (stmts.Count > 0 && (stmts.Last() is not Stmt.Return))
                {
                    Add(Insn.Return);
                }

                Function = null;
            }

        }

        public void Walk(WaInstructionList instructions, Expr expr)
        {
            using (Into(instructions))
            {
                Walk(expr);
            }
        }

        public void CreateInitCtor(WaFunction function, Decl.Classy clazz)
        {
            // move all field initializations into init@ctor

            using (Into(function.Instructions))
            {
                var get = Insn.Local.Get(0);
                foreach (var field in clazz.Members.Fields)
                {
                    Add(get);
                    Walk(field.Value);
                    Add(Lower(field.Type).Store(field.Offset));
                }
                Add(Insn.Return);
            }
        }

        public void CreateDefaultCtor(WaFunction function, Decl.Classy clazz)
        {
            using (Into(function.Instructions))
            {
                Add(Insn.Local.Get(0));
                Add(Insn.Return);
            }
        }

        public void CreateModuleCtor(WaFunction function)
        {
            // initialize all static fields

            using (Into(function.Instructions))
            {
                foreach (var field in Module.StaticData)
                {
                    Add(new WiInitStaticField(field));
                }
                Add(Insn.Return);
            }
        }

        private void Walk(Entity entity)
        {
            Build((dynamic)entity);
        }

        private void Add(WaInstruction instruction)
        {
            Current.Add(instruction);
        }

        private void Add(Insn instruction)
        {
            Add(new WiInsn(Module, instruction));
        }

        private void Build(Entity entity)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Build(Decl.LetVar decl)
        {
            Assert(false);
            throw new InvalidOperationException();
        }

        private void Build(Decl.Funcy decl)
        {
            Assert(false);
            // NOP - handled elsewhere
        }

        private void Build(Decl.Parameter decl)
        {
            Assert(false);
            // NOP - handled elsewhere
        }

        private void Build(Decl.SelfParameter decl)
        {
            Assert(false);
            // NOP - handled elsewhere
        }

        private void Build(Stmt.If block)
        {
            var condition = Nested(block.Condition);

            var type = block.Type is Type.Void ? null : Lower(block.Type).Wasm;

            var ifBlock = Nested(block.IfBlock);
            
            if (block.ElseBlock != null)
            {
                var elseBlock = Nested(block.ElseBlock);
                
                Add(new WiIfBlock(Module, type, condition, ifBlock, elseBlock));
            }
            else
            {
                Add(new WiIfBlock(Module, type, condition, ifBlock, null));
            }
        }

        private void Build(Stmt.While block)
        {
            var condition = Nested(block.Condition);

            var type = block.Type is Type.Void ? null : Lower(block.Type).Wasm;

            var whileBlock = Nested(block.WhileBlock);

            Add(new WiWhileBlock(Module, type, condition, whileBlock));
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
                    Add(Lower(select.Field.Type).Store(select.Field.Offset));
                    return;
                case Expr.GlobalReference globalReference:
                    Walk(stmt.Right);
                    Add(Insn.Global.Set(globalReference.Decl.FullName));
                    return;
                case Expr.LocalReference localReference:
                    Walk(stmt.Right);
                    Add(Insn.Local.Set(localReference.LocalDecl.Index));
                    return;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private void Build(Stmt.Expression stmt)
        {
            Walk(stmt.Expr);
        }

        private void Build(Expr.If expr)
        {
            var condition = Nested(expr.Condition);
            var then = Nested(expr.Then);
            var @else = Nested(expr.Else);

            var type = Lower(expr.Then.Type).Wasm;
            var type2 = Lower(expr.Else.Type).Wasm;
            Assert(type == type2);

            Add(new WiIfBlock(Module, type, condition, then, @else));
        }

        private void Build(Expr.Reference reference)
        {
            BuildReference((dynamic)reference.Decl);
        }

        private void BuildReference(Decl decl)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void BuildReference(Decl.Global decl)
        {
            Add(Insn.Global.Get(decl.FullName));
        }

        private void BuildReference(Decl.LetVar decl)
        {
            Add(Insn.Local.Get(decl.Index));
        }

        private void BuildReference(Decl.Parameter decl)
        {
            Add(Insn.Local.Get(decl.Index));
        }

        private void BuildReference(Decl.SelfParameter decl)
        {
            Assert(decl.Index == 0);
            Add(Insn.Local.Get(decl.Index));
        }

        private void BuildReference(Decl.Classy decl)
        {
            Add(Insn.Local.Get(0));
        }

        private void BuildReference(Decl.Function decl)
        {
            Assert(decl.Validated);

            var name = decl.FullName;

            var function = WaFunction.From(Module, name);

            var index = Module.GlobalFunctionTable.Add(function, name);

            Add(Insn.U32.Const(index));
        }

        private void BuildReference(Decl.Object decl)
        {
            if (decl.IsNative)
            {
                if (decl.FullName == "six.core.true")
                {
                    Add(Insn.Boolean.True);
                    return;
                }
                if (decl.FullName == "six.core.false")
                {
                    Add(Insn.Boolean.False);
                    return;
                }
            }

            Assert(false);
            throw new NotImplementedException();
        }

        private void BuildReference(Decl.Field decl)
        {
            if (decl.IsStatic)
            {
                var staticField = Module.FindStaticField(decl.StaticName);

                Add(new WiGetStaticField(staticField));
            }
            else
            {
                Add(Insn.Local.Get(0));

                Add(Lower(decl.Type).Load(decl.Offset));
            }
        }

        private void Build(Expr.CallConstructor expr)
        {
            if (expr.Ctor.IsNative)
            {
                Walk(Resolve(expr.Class).Method(expr.Ctor.Name, expr.Arguments.Count)(expr.Arguments));
            }
            else
            {
                var classy = WaClass.From(Module, expr.Class.FullName);
                Add(new WiGetRuntimeType(classy));
                Add(Insn.Call(Sema.Module.CoreClassAlloc));

                foreach (var argument in expr.Arguments)
                {
                    Walk(argument);
                }
                Add(Insn.Call(expr.Ctor.FullName));
            }
        }

        private void Build(Expr.CallIndirect expr)
        {
            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }
            Walk(expr.Value);
            Add(Insn.CallIndirect(Module.GlobalFunctionTable.Name, TypeFor(expr.Callable)));
        }


        private void Build(Expr.CallInfixMember expr)
        {
            if (expr.Function.IsNative)
            {
                Walk(Resolve(expr.Classy).Method(expr.Function.Name, 2)(new List<Expr> { expr.Arg1, expr.Arg2 }));
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg1, expr.Arg2);
                Walk(callMember);
            }
        }

        private void Build(Expr.CallPrefixMember expr)
        {
            if (expr.Function.IsNative)
            {
                Walk(Resolve(expr.Classy).Method(expr.Function.Name, 1)(new List<Expr> { expr.Arg }));
            }
            else
            {
                var callMember = new Expr.CallMember(expr.Classy, expr.Function, expr.Arg);
                Walk(callMember);
            }
        }

        private void Build(Expr.CallStaticFunction expr)
        {
            var funcy = expr.Funcy;

            if (funcy.IsNative)
            {
                if (funcy.Parent is ClassBlock classBlock)
                {
                    var classy = classBlock.Classy;

                    Walk(Resolve(classy).Method(funcy.Name, expr.Arguments.Count)(expr.Arguments));
                }
                else
                {
                    Assert(false);
                    throw new NotImplementedException();
                }
            }
            else
            {
                foreach (var argument in expr.Arguments)
                {
                    Walk(argument);
                }

                Add(Insn.Call(funcy.FullName));
            }
        }

        private void Build(Expr.CallMemberFunction expr)
        {
            if (expr.Funcy.IsNative)
            {
                Assert(false);
                throw new NotImplementedException();
            }

            Walk(expr.Reference);

            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }

            Add(Insn.Call(expr.Funcy.FullName));
        }

        private void Build(Expr.CallMember expr)
        {
            if (expr.Function.IsNative)
            {
                Walk(expr.Make);

                Walk(Resolve(expr.Classy).Method(expr.Function.Name, expr.Arguments.Count)(expr.Arguments));
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

        private void Build(Expr.CallDynamicFunction expr)
        {
            Walk(expr.Reference);
         
            foreach (var argument in expr.Arguments)
            {
                Walk(argument);
            }

            Add(Insn.Local.Get(0));
            Add(Insn.U32.Load(4));
            Add(Insn.U32.Const(expr.SlotNo));
            Add(Insn.U32.Add);
            Add(Insn.CallIndirect(Sema.Module.DispatchTableName, TypeFor(expr.Funcy.CallableType)));
        }

        private void Build(Expr.SelectField expr)
        {
            Walk(expr.Reference);

            Add(Lower(expr.Field.Type).Load(expr.Field.Offset));
        }

        private void Build(Primitive.Binop primitive)
        {
            Walk(primitive.Arg1);
            Walk(primitive.Arg2);
            Add(primitive.Insn);
        }

        private void Build(Primitive.Unop primitive)
        {
            Walk(primitive.Arg);
            if (primitive.Insn is not Insn.Simple.Nop)
            {
                Add(primitive.Insn);
            }
        }

        private void Build(Primitive.Arged primitive)
        {
            Walk(primitive.Arg);
        }

        private void Build(Primitive.Instructions insns)
        {
            foreach (var insn in insns.Insns)
            {
                Add(insn);
            }
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
            var constString = Module.AddString(primitive.Value);
            Add(new WiConstString(constString));
        }
    }
}
