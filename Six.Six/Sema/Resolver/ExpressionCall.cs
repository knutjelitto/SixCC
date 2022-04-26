using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Six.Six.Sema.Expr;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Sema
{
    public class ExpressionCall
    {

        public ExpressionCall(Resolver resolver)
        {
            Resolver = resolver;
        }

        public Resolver Resolver { get; }
        public Module Module => Resolver.Module;
        public Errors Errors => Module.Errors;
        public TypeChecker Checker => Module.Checker;
        public TypeResolver T => Resolver.T;

        public Expr On(Entity primary, List<Expr> args)
        {
            return Call((dynamic)primary, args);
        }

        private Expr On(Expr primary, Entity entity, List<Expr> args)
        {
            return Call(primary, (dynamic)entity, args);
        }

        private Expr Call(Entity primary, List<Expr> args)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr Call(Expr primary, Entity entity, List<Expr> args)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        private Expr Call(FunctionReference primary, List<Expr> args)
        {
            return On(primary, primary.Decl, args);
        }

        private Expr Call(ConstructorReference primary, List<Expr> args)
        {
            return On(primary, primary.Decl, args);
        }

        private Expr Call(Reference primary, List<Expr> args)
        {
            return On(primary, primary.Type, args);
        }

        private Expr Call(SelectFunction select, List<Expr> args)
        {
            return CallFunction.From(select.Function, args);
        }

        private Expr Call(Expr primary, Decl.Function function, List<Expr> args)
        {
            var prms = function.Parameters;
            var arguments = function.IsClassMember ? MakeMemberArguments(prms, args) : MakeArguments(prms, args);

            return CallFunction.From(function, arguments);
        }

        private Expr Call(Expr primary, Type.Callable callable, List<Expr> args)
        {
            var prms = callable.Parameters;

            Assert(prms.Count >= args.Count);
            var arguments = new List<Expr>();

            var index = 0;
            for (; index < Math.Min(prms.Count, args.Count); ++index)
            {
                var argType = args[index].Type;
                var prmType = prms[index];

                Assert(Checker.CanAssign(prmType, argType));

                arguments.Add(args[index]);
            }
            for (; index < prms.Count; ++index)
            {
                Assert(false);
            }

            Assert(arguments.Count == prms.Count);

            return new CallIndirect(primary, callable, arguments);
        }

        private Expr Call(Expr primary, Decl.Class classy, List<Expr> args)
        {
            if (classy.IsAbstract)
            {
                throw Errors.CanNotCreateInstanceOfAbstractClass(classy, Names.Nouns.Class);
            }

            var ctor = classy.Block.Find<Decl.Constructor>(classy.AClassy.GetLocation(), Module.DefaultCtor);

            Assert(ctor.IsStatic);

            var prms = ctor.Parameters;

            if (ctor.IsNative)
            {
                var arguments = MakeArguments(prms, args);

                return new CallConstructor(classy, ctor, arguments);
            }
            else
            {
                var arguments = MakeMemberArguments(prms, args);

                return new CallConstructor(classy, ctor, arguments);
            }

        }

        private Expr Call(Expr primary, Decl.Constructor ctor, List<Expr> args)
        {
            var classy = ctor.Class;

            Assert(!classy.IsAbstract);

            if (classy.IsAbstract)
            {
                throw Errors.CanNotCreateInstanceOfAbstractClass(classy, Names.Nouns.Class);
            }

            Assert(ctor.IsStatic);

            var prms = ctor.Parameters;

            var arguments = ctor.IsNative ? MakeArguments(prms, args) : MakeMemberArguments(prms, args);

            return new CallConstructor(classy, ctor, arguments);
        }

        private List<Expr> MakeMemberArguments(IReadOnlyList<Decl.Local> prms, List<Expr> args)
        {
            Assert(prms.Count > args.Count);
            var arguments = new List<Expr>();

            var index = 0;
            for (; index < args.Count; ++index)
            {
                var prmType = T.LowerType(prms[index + 1].Type);
                var argType = T.LowerType(args[index].Type);

                Assert(Checker.CanAssign(prmType, argType));

                arguments.Add(args[index]);
            }
            for (; ++index < prms.Count;)
            {
                if (prms[index] is Decl.Parameter param)
                {
                    Assert(param.Default != null);

                    arguments.Add(param.Default!);
                }
                else
                {
                    Assert(prms[index] is Decl.Parameter);
                }
            }

            Assert(arguments.Count == prms.Count - 1);

            return arguments;
        }

        private List<Expr> MakeArguments(IReadOnlyList<Decl.Local> prms, List<Expr> args)
        {
            Assert(prms.Count >= args.Count);
            var arguments = new List<Expr>();

            var index = 0;
            for (; index < Math.Min(prms.Count, args.Count); ++index)
            {
                var argType = args[index].Type;
                var prmType = prms[index].Type;

                Assert(Checker.CanAssign(prmType, argType));

                arguments.Add(args[index]);
            }
            for (; index < prms.Count; ++index)
            {
                if (prms[index] is Decl.Parameter param)
                {
                    Assert(param.Default != null);

                    arguments.Add(param.Default!);
                }
                else
                {
                    Assert(prms[index] is Decl.Parameter);
                }
            }

            Assert(arguments.Count == prms.Count);

            return arguments;
        }

    }
}
