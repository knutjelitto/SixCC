using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public partial class Validator
    {
        private void Validate(Decl decl)
        {
            Decl((dynamic)decl);
        }

        private void Decl(Decl decl)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void Decl(Decl.Class decl)
        {
            ClassyDecl(decl);

            Assert(slip);
        }

        private void Decl(Decl.Interface decl)
        {
            ClassyDecl(decl);

            Assert(slip);
        }

        private void Decl(Decl.Object decl)
        {
            ClassyDecl(decl);

            if (!decl.IsAbstract)
            {
                foreach (var slot in decl.Layout.Slots)
                {
                    if (slot.Funcy.IsConcrete)
                    {
                        continue;
                    }

                    var subject = $"the {Names.Attr.Abstract} member";

                    Add(Errors.AbstractNotImplemented(decl, slot.Funcy, subject));
                }
            }

            Assert(slip);
        }

        private void ClassyDecl(Decl.Classy decl)
        {
            // force layout
            _ = decl.Layout;

            Walk(decl.Block);

            if (!decl.IsAbstract)
            {
                foreach (var slot in decl.Layout.Slots)
                {
                    if (slot.Funcy.IsConcrete)
                    {
                        continue;
                    }

                    var subject = $"the {Names.Attr.Abstract} member";

                    Add(Errors.AbstractNotImplemented(decl, slot.Funcy, subject));
                }
            }

            Assert(slip);
        }

        private void Decl(Decl.Field decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Decl(Decl.Global decl)
        {
            Walk(decl.Value);

            if (!Checker.CanAssign(decl.Type, decl.Value.Type))
            {
                Add(Errors.TypeMismatch(decl.Location, decl.Type, decl.Value.Type));
            }

            Assert(slip);
        }

        private void Decl(Decl.LetVar decl)
        {
            Walk(decl.Value);

            Assert(slip);
        }

        private void Decl(Decl.SelfParameter decl)
        {
            Assert(slip);
        }

        private void Decl(Decl.Parameter decl)
        {
            if (decl.Default != null)
            {
                Walk(decl.Default);
            }

            Assert(slip);
        }

        private void Decl(Decl.Funcy decl)
        {
            Walk(decl.Block);

            FuncyDecl((dynamic)decl);
        }

        private void FuncyDecl(Decl.Funcy decl)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private void FuncyDecl(Decl.Constructor decl)
        {
            Assert(slip);
        }

        private void FuncyDecl(Decl.Attribute decl)
        {
            FunctionOrAttributeDecl(decl);

            Assert(slip);
        }

        private void FuncyDecl(Decl.Function decl)
        {
            FunctionOrAttributeDecl(decl);

            Assert(slip);
        }

        private void FunctionOrAttributeDecl(Decl.Funcy decl)
        {
            if (decl.Parent is NamespaceBlock)
            {
                // GLOBAL FUNCTION

                var subject = $"global {Names.Nouns.Function}";

                if (decl.IsStatic) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Static));
                if (decl.IsAbstract) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Abstract));
                if (decl.IsOverride) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Override));
                if (decl.IsVirtual) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Virtual));
                if (decl.IsSealed) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Sealed));
                if (!decl.HasBody) Add(Errors.SubjectMustBeImplemented(decl, subject));

                decl.TableIndex = Emitter.GlobalFunctions.Add(decl);
                decl.Validated = true;

                Assert(slip);
            }
            else if (decl.Parent is ClassBlock classBlock)
            {
                // METHOD

                var subject = Names.Nouns.Method;

                if (decl.IsStatic)
                {
                    subject = $"{Names.Attr.Static} {Names.Nouns.Member} {Names.Nouns.Function}";
                    if (decl.IsAbstract) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Abstract));
                    if (decl.IsOverride) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Override));
                    if (decl.IsVirtual) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Virtual));
                    if (decl.IsSealed) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Sealed));
                    if (!decl.HasBody) Add(Errors.SubjectMustBeImplemented(decl, subject));
                }
                else if (decl.IsAbstract)
                {
                    subject = $"{Names.Attr.Abstract} {subject}";
                    if (decl.IsOverride) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Override));
                    if (decl.IsVirtual) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Virtual));
                    if (decl.IsSealed) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Sealed));
                    if (decl.HasBody) Add(Errors.SubjectShouldNotBeImplemented(decl, subject));

                    //TODO: check NO base
                    Assert(slip);
                }
                else if (decl.IsOverride)
                {
                    subject = $"{Names.Attr.Abstract} {subject}";
                    if (decl.IsVirtual) Add(Errors.SubjectShouldNotBeMarkedAs(decl, subject, Names.Attr.Virtual));
                    if (!decl.HasBody) Add(Errors.SubjectMustBeImplemented(decl, subject));

                    //TODO: check base
                    Assert(slip);
                }
                else if (decl.IsVirtual)
                {
                    subject = $"{Names.Attr.Abstract} {subject}";
                    if (!decl.HasBody) Add(Errors.SubjectMustBeImplemented(decl, subject));

                    //TODO: check NO base
                    Assert(slip);
                }
                else
                {
                    if (!decl.HasBody) Add(Errors.SubjectMustBeImplemented(decl, subject));

                    Assert(slip);
                }

                if (!decl.IsAbstract)
                {
                    decl.TableIndex = Emitter.GlobalFunctions.Add(decl);
                }
                decl.Validated = true;

                Assert(slip);
            }
            else if (decl.Parent is FuncBlock)
            {
                // LOCAL FUNCTION

                Assert(slip);
            }
            else
            {
                Assert(false);
                throw new NotImplementedException();
            }
        }
    }
}
