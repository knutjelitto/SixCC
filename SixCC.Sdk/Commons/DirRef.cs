using System;
using System.Linq;

using SPath = System.IO.Path;
using SDirectory = System.IO.Directory;

namespace SixCC.Sdk.Commons
{
    public class DirRef
    {
        private DirRef(string path)
        {
            Path = path;
            EnsureDirectory();
        }

        public string Path { get; }
        public string BaseName => SPath.GetFileNameWithoutExtension(Path);
        public string FileName => SPath.GetFileName(Path);
        public string Directory => SPath.GetDirectoryName(Path)!;

        public FileRef File(string fileName)
        {
            return FileRef.From(SPath.Combine(Path, fileName).Replace("\\", "/"));
        }

        public DirRef Dir(string dirName)
        {
            return From(SPath.Combine(Path, dirName).Replace("\\", "/"));
        }

        public DirRef Up => From(Directory);

        public static DirRef From(string name)
        {
            return new DirRef(name);
        }

        public static implicit operator string(DirRef dir)
        {
            return dir.Path;
        }

        public override string ToString()
        {
            return Path;
        }

        private void EnsureDirectory()
        {
            var dirPath = Path;
            if (!string.IsNullOrEmpty(dirPath) && !System.IO.Directory.Exists(dirPath))
            {
                SDirectory.CreateDirectory(dirPath);
            }
        }


        public static DirRef ProjectDir()
        {
            var cwd = Environment.CurrentDirectory!;

            while (SDirectory.Exists(cwd) && !SDirectory.EnumerateFiles(cwd, "*.csproj").Any())
            {
                cwd = SPath.GetDirectoryName(cwd)!;
            }

            var projectDir = From(cwd.Replace("\\", "/"));

            return projectDir;
        }

    }
}
