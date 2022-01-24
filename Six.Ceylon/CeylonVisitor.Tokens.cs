using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CIdentifier element)
        {
            element.Value = new AnyIdentifier(element);
        }

        protected override void Visit(CLowerIdentifier element)
        {
            element.Value = new LowerIdentifier(element);
        }

        protected override void Visit(CUpperIdentifier element)
        {
            element.Value = new UpperIdentifier(element);
        }

        protected override void Visit(CLiteralNatural element)
        {
        }

        protected override void Visit(CLiteralFloat element)
        {
        }

        protected override void Visit(CLiteralString element)
        {
        }

        protected override void Visit(CLiteralChar element)
        {
        }

        protected override void Visit(CVerbatimString element)
        {
        }

        protected override void Visit(CStringStart element)
        {
            Assert(element.Text.StartsWith("\"") && element.Text.EndsWith("``"));
        }

        protected override void Visit(CStringEnd element)
        {
            Assert(element.Text.StartsWith("``") && element.Text.EndsWith("\""));
        }

        protected override void Visit(CStringMid element)
        {
            Assert(element.Text.StartsWith("``") && element.Text.EndsWith("``"));
        }
    }
}
