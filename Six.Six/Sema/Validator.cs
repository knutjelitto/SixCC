using System;

using Six.Core.Errors;
using Six.Six.Instructions;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Sema
{
    public partial class Validator
    {
        const bool slip = true;

        public Validator(Module module)
        {
            Module = module;
        }

        public Module Module { get; }
        public Errors Errors => Module.Errors;
        public TypeChecker Checker => Module.Checker;

        public void Validate()
        {
            foreach (var nameSpace in Module.GetNamespaces())
            {
                Walk(nameSpace);
            }
        }

        private void Add(DiagnosticException error)
        {
            Module.Add(error);
        }

        private void Walk(NamespaceBlock block)
        {
            foreach (var member in block.Members)
            {
                Walk(member);
            }
        }

        private void Walk(ClassMembers classMembers)
        {
            foreach (var member in classMembers.GetAll())
            {
                Walk(member);
            }
        }

        private void Walk(FuncMembers funcyMembers)
        {
            foreach (var member in funcyMembers.GetAll())
            {
                Walk(member);
            }
        }

        private void Walk(Entity entity)
        {
            try
            {
                Validate((dynamic)entity);
            }
            catch (DiagnosticException diagnostic)
            {
                Module.Add(diagnostic);
            }
        }

        private void Walk(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                Walk(entity);
            }
        }

        private void Validate(Entity entity)
        {
            Assert(false);
            throw new NotImplementedException();
        }
    }
}
