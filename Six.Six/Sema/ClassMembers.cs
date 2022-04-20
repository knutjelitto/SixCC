using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public class ClassMembers
    {
        private readonly List<Decl.Field> fields = new();
        private readonly List<Decl.Funcy> functions = new();
        private readonly List<Decl.Classy> classes = new();

        public IReadOnlyList<Decl.Field> Fields => fields;
        public IReadOnlyList<Decl.Funcy> Functions => functions;
        public IReadOnlyList<Decl.Classy> Classes => classes;

        public IEnumerable<Decl> GetAll() => fields.Cast<Decl>().Concat(functions).Concat(classes);

        public void AddField(Decl.Field field)
        {
            fields.Add(field);
        }

        public void AddFunction(Decl.Funcy function)
        {
            functions.Add(function);
        }

        public void AddClassy(Decl.Classy classy)
        {
            classes.Add(classy);
        }
    }
}
