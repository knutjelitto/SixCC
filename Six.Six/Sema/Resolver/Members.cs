using System;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class Members
    {
        public T AddAndDeclareMember<T>(Block block, T decl)
            where T : Decl
        {
            AddTo((dynamic)block, (dynamic)decl);

            return block.Declare(decl);
        }

        private void AddTo(Block block, Decl decl)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void AddTo(CodeBlock block, Decl.Funcy funcy)
        {
            block.Funcy.Members.AddFunction(funcy);
        }

        private void AddTo(CodeBlock block, Decl.LetVar letvar)
        {
            block.Funcy.Members.AddLocal(letvar);
        }

        private void AddTo(FuncBlock block, Decl.SelfParameter parameter)
        {
            block.Funcy.Members.AddParameter(parameter);
        }

        private void AddTo(FuncBlock block, Decl.Parameter parameter)
        {
            block.Funcy.Members.AddParameter(parameter);
        }

        private void AddTo(ClassBlock block, Decl.Funcy function)
        {
            block.Classy.Members.AddFunction(function);
        }

        private void AddTo(ClassBlock block, Decl.Field field)
        {
            block.Classy.Members.AddField(field);
        }

        private void AddTo(NamespaceBlock block, Decl.Funcy funcy)
        {
            block.AddMember(funcy);
        }

        private void AddTo(NamespaceBlock block, Decl.Classy classy)
        {
            block.AddMember(classy);
        }

        private void AddTo(NamespaceBlock block, Decl.Alias alias)
        {
            block.AddMember(alias);
        }

        private void AddTo(NamespaceBlock block, Decl.Global global)
        {
            block.AddMember(global);
        }
    }
}
