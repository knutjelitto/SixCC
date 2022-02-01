using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CIdentifier element)
        {
            element.Value = new Identifier.Any(element);
        }

        protected override void Visit(CLowerIdentifier element)
        {
            element.Value = new Identifier.Lower(element);
        }

        protected override void Visit(CUpperIdentifier element)
        {
            element.Value = new Identifier.Upper(element);
        }

        protected override void Visit(CLiteralNatural element)
        {
            element.Value = new NaturalNumber(element);
        }

        protected override void Visit(CLiteralFloat element)
        {
            element.Value = new FloatNumber(element);
        }

        protected override void Visit(CLiteralString element)
        {
            element.Value = new StandardString(element);
        }

        protected override void Visit(CLiteralChar element)
        {
            element.Value = new CharString(element);
        }

        protected override void Visit(CVerbatimString element)
        {
            element.Value = new VerbatimString(element);
        }

        protected override void Visit(CStringStart element)
        {
            element.Value = new StartInterpolationString(element);
        }

        protected override void Visit(CStringEnd element)
        {
            element.Value = new EndInterpolationString(element);
        }

        protected override void Visit(CStringMid element)
        {
            element.Value = new MidInterpolationString(element);
        }
    }
}
