using System;

using A = Six.Six.Ast;
using static Six.Six.Sema.Expr;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class ExpressionSelect
    {
        public Expr SelectOnAny(Expr primary, A.Reference reference)
        {
            return DoSelectOnAny(primary, (dynamic)primary, reference);
        }

        private Expr SelectOnType(Entity entity, A.Reference reference)
        {
            return DoSelectOnType((dynamic)entity, reference);
        }

        private Expr SelectOnObject(Expr primary, Entity entity, A.Reference reference)
        {
            return DoSelectOnObject(primary, (dynamic)entity, reference);
        }

        private Expr DoSelectOnAny(Expr primary, Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnType(Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnObject(Expr primary, Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnAny(Expr primary, SelectField selectField, A.Reference reference)
        {
            return SelectOnObject(selectField, selectField.Type, reference);
        }

        private Expr DoSelectOnAny(Expr primary, ClassReference classyReference, A.Reference reference)
        {
            return SelectOnType(classyReference.Decl, reference);
        }

        private Expr DoSelectOnAny(Expr primary, ParameterReference parameterReference, A.Reference reference)
        {
            return SelectOnObject(primary, parameterReference.Type, reference);
        }

        private Expr DoSelectOnAny(Expr primary, FieldReference fieldReference, A.Reference reference)
        {
            return SelectOnObject(primary, fieldReference.Type, reference);
        }

        private Expr DoSelectOnAny(Expr primary, LocalReference local, A.Reference reference)
        {
            return SelectOnObject(primary, local.Type, reference);
        }

        private Expr DoSelectOnAny(Expr primary, AliasReference aliasRef, A.Reference reference)
        {
            return SelectOnType(aliasRef.Decl.Type, reference);
        }

        private Expr DoSelectOnAny(Expr primary, CallConstructor ctorCall, A.Reference reference)
        {
            return SelectOnObject(primary, ctorCall.Type, reference);
        }

        private Expr DoSelectOnObject(Expr objekt, Decl.Class classy, A.Reference reference)
        {
            var referenced = classy.Block.Resolve(reference);

            if (referenced is Decl.Attribute attribute)
            {
                return CallFunction.From(attribute);
            }
            else if (referenced is Decl.Function function)
            {
                return new SelectFunction(objekt, function);
            }
            else if (referenced is Decl.Field field)
            {
                return new SelectField(objekt, field);
            }

            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnType(Decl.Class classy, A.Reference reference)
        {
            var referenced = classy.Block.Resolve(reference);

            Assert(referenced.IsStatic);

            if (referenced is Decl.Attribute attribute)
            {
                return CallFunction.From(attribute);
            }
            else if (referenced is Decl.Function function)
            {
                return new FunctionReference(function);
            }
            else if (referenced is Decl.Constructor constructor)
            {
                return new ConstructorReference(constructor);
            }

            Assert(false);
            throw new NotImplementedException();
        }
    }
}
