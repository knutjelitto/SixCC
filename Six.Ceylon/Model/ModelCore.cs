using Six.Ceylon.Ast;
using Six.Tools;

namespace Six.Ceylon.Model
{
    public abstract class ModelCore : FromSource
    {
        public ModelCore(Compiler compiler, FileRef source)
        {
            Compiler = compiler;
            Source = source;
        }

        public Compiler Compiler { get; }
        public FileRef Source { get; }

        public void Dump(IndentWriter writer, Member member)
        {
            switch (member)
            {
                case ImportDeclaration import:
                    writer.WriteLine($"import: {import.Name}");
                    break;
                case FunctionDeclaration function:
                    writer.WriteLine($"function: {function.Header.Name}");
                    break;
                case InterfaceDeclaration iface:
                    writer.WriteLine($"interface: {iface.Header.Name}");
                    break;
                case ClassDeclaration clss:
                    writer.WriteLine($"class: {clss.Header.Name}");
                    break;
                case ObjectDeclaration obj:
                    writer.WriteLine($"object: {obj.Header.Name}");
                    break;
                case ValueDeclaration value:
                    writer.WriteLine($"value: {value.Header.Name}");
                    break;
                case AliasDeclaration alias:
                    writer.WriteLine($"alias: {alias.Header.Name}");
                    break;

                default:
                    Compiler.ErrorCount++;
                    break;
            }
        }
    }
}
