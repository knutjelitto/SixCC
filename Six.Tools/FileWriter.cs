using System;
using System.IO;
using System.Text;

namespace Six.Tools
{
    public class FileWriter : IndentWriter, IDisposable
    {
        public FileWriter(FileRef file, string? indent = null)
            : base(GetWriter(file), indent)
        {
        }

        public void Dispose()
        {
            var baseWriter = (BaseTextWriter)Writer;

            var stream = (StreamWriter)baseWriter.Writer;
            stream.Flush();
            stream.Close();
        }

        private static BaseTextWriter GetWriter(FileRef file)
        {
            file.Directory.Ensure();
            return new BaseTextWriter(new StreamWriter(file.Path, false, Encoding.UTF8));
        }
    }
}
