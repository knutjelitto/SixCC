using SixCC.Sdk.Commons;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;

namespace SixCC.Writing
{
    public sealed class FileWriter : WriterCore
    {
        public FileWriter(string path)
            : base(new IndentedTextWriter(new StreamWriter(path, false, new UTF8Encoding(false))))
        {
        }

        public FileWriter(FileRef file)
            : this(file.Path)
        {
        }

        public override void Dispose()
        {
            writer.Close();
        }
    }
}
