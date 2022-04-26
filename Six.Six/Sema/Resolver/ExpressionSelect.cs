using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = Six.Six.Ast;
using static Six.Six.Sema.Expr;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class ExpressionSelect
    {
        public Expr SelectOnAny(Block block, Expr primary, Entity entity, A.Reference reference)
        {
            return DoSelectOnAny(block, primary, (dynamic)entity, reference);
        }

        private Expr SelectOnType(Block block, Entity entity, A.Reference reference)
        {
            return DoSelectOnType(block, (dynamic)entity, reference);
        }

        private Expr SelectOnObject(Block block, Expr primary, Entity entity, A.Reference reference)
        {
            return DoSelectOnObject(block, primary, (dynamic)entity, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnType(Block block, Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnObject(Block block, Expr primary, Entity entity, A.Reference reference)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnAny(Block block, Expr primary, ClassReference classyReference, A.Reference reference)
        {
            return SelectOnType(block, classyReference.Decl, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, ParameterReference parameterReference, A.Reference reference)
        {
            return SelectOnObject(block, primary, parameterReference.Type, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, FieldReference fieldReference, A.Reference reference)
        {
            return SelectOnObject(block, primary, fieldReference.Type, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, LocalReference local, A.Reference reference)
        {
            return SelectOnObject(block, primary, local.Type, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, AliasReference aliasRef, A.Reference reference)
        {
            return SelectOnType(block, aliasRef.Decl.Type, reference);
        }

        private Expr DoSelectOnAny(Block block, Expr primary, CallConstructor ctorCall, A.Reference reference)
        {
            return SelectOnObject(block, primary, ctorCall.Type, reference);
        }

        private Expr DoSelectOnObject(Block block, Expr objekt, Decl.Class classy, A.Reference reference)
        {
            var referenced = classy.Block.Resolve(reference);

            if (referenced is Decl.Attribute attribute)
            {
                return CallFunction.From(attribute);
            }
            else if (referenced is Decl.Function function)
            {
                return new SelectFunction(objekt, classy, function);
            }
            else if (referenced is Decl.Field field)
            {
                return new SelectField(objekt, classy, field);
            }

            Assert(false);
            throw new NotImplementedException();
        }

        private Expr DoSelectOnType(Block block, Decl.Class classy, A.Reference reference)
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
