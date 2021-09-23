using Six.Ceylon.Ast;
using Six.Ceylon.Errors;
using Six.Tools;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Six.Ceylon
{
    public class Visitor
    {
        private HashSet<string> ignored = new();

        public Visitor()
        {
        }

        private void Accept(INode node)
        {
            throw new ErrorException(new CantVisitError(node));
        }

        public void Visit(INode node)
        {
            Ignore((dynamic)node);
        }

        public void Ignore(INode? node)
        {
            if (node != null)
            {
                ignored.Add(node.GetType().Name);
            }
        }

        public void Report(IndentWriter writer)
        {
            var ignored = this.ignored.OrderBy(n => n);
            writer.WriteLine("Visitor:");
            using (writer.Indent())
            {
                writer.WriteLine("ignored:");
                var line = new StringBuilder();
                foreach(var ignore in ignored)
                {
                    if (line.Length >= 120)
                    {
                        writer.WriteLine(line.ToString());
                        line.Clear();
                    }
                    if (line.Length > 0)
                    {
                        line.Append(' ');
                    }
                    line.Append(ignore);
                }
                if (line.Length > 0)
                {
                    writer.WriteLine(line.ToString());
                    line.Clear();
                }
            }
        }

        protected virtual void Accept(FunctionDeclaration node)
        {
            Ignore(node.Header);
            Ignore(node.Definition);
        }

        protected virtual void Accept(FunctionHeader node)
        {
            Ignore(node.Annotations);
            Ignore(node.Prefix);
            Ignore(node.Name);
            Ignore(node.TypeParameters);
            Ignore(node.Parameters);
            Ignore(node.Constraints);
        }
    }
}
