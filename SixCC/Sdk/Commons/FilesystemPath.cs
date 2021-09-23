using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.IO;
using SPath = System.IO.Path;
using SFile = System.IO.File;
using SDirectory = System.IO.Directory;
using System;

#pragma warning disable IDE1006 // Naming Styles

namespace SixCC.Sdk.Commons
{
    public interface HasString
    {
        string Path { get; }
    }
    
    public interface FilesystemPath<T> : HasString
        where T : FilesystemPath<T>
    {
        bool Exists { get; }

        public DirectoryRef Directory => new DirectoryImpl(SPath.GetDirectoryName(Path)!);
        public string Name => SPath.GetFileName(Path);
        public string NameStem => SPath.GetFileNameWithoutExtension(Path);

        T RelativeTo(DirectoryRef root);

        abstract class Impl<U> : FilesystemPath<U>
            where U : FilesystemPath<U>
        {
            public Impl(string path)
            {
                Path = Normalize(path);
            }
            public string Path { get; }
            public abstract bool Exists { get; }

            public override string ToString()
            {
                return Path;
            }

            public override bool Equals(object? obj)
            {
                return obj is Impl<U> other && string.Compare(Path, other.Path, StringComparison.InvariantCultureIgnoreCase) == 0;
            }

            public override int GetHashCode()
            {
                return Path.ToLowerInvariant().GetHashCode();
            }

            private static string Normalize(string path)
            {
                path = SPath.GetFullPath(new Uri("file://" + path).LocalPath).Replace('\\', '/').TrimEnd('/');
                if (path.Length > 1 && path[1] == ':' && char.IsAscii(path[0]) && char.IsLetter(path[0]) && char.IsUpper(path[0]))
                {
                    path = char.ToLower(path[0]) + ":" + path[2..];
                }
                else if (path.StartsWith("//"))
                {
                    path = path[2..];
                }
                return path;
            }

            public abstract U RelativeTo(DirectoryRef root);

            protected string Relative(DirectoryRef root)
            {
                if (Path.StartsWith(root.Path, StringComparison.InvariantCultureIgnoreCase))
                {
                    return Path[(root.Path.Length + 1)..];
                }
                return Path;
            }
        }

        class FileImpl : Impl<FileRef>, FileRef
        {
            public FileImpl(string path) : base(path) { }

            public override bool Exists => SFile.Exists(Path);

            public override FileRef RelativeTo(DirectoryRef root)
            {
                return new FileImpl(Relative(root));
            }
        }

        class DirectoryImpl : Impl<DirectoryRef>, DirectoryRef
        {
            public DirectoryImpl(string path) : base(path) { }

            public override bool Exists => SDirectory.Exists(Path);

            public override DirectoryRef RelativeTo(DirectoryRef root)
            {
                return new DirectoryImpl(Relative(root));
            }
        }
    }

    public interface FileRef : FilesystemPath<FileRef>
    {
        public static FileRef From(string path) => new FileImpl(path);
        string Text() => SFile.ReadAllText(Path);
        string Text(Encoding encoding) => SFile.ReadAllText(Path, encoding);
    }

    public interface DirectoryRef : FilesystemPath<DirectoryRef>
    {
        public static DirectoryRef From(string path) => new DirectoryImpl(path);

        public DirectoryRef Ensure()
        {
            SDirectory.CreateDirectory(Path);
            return this;
        }

        public DirectoryRef AppendDirectory(string path)
        {
            return From(SPath.Combine(Path, path));
        }

        public FileRef AppendFile(string path)
        {
            return FileRef.From(SPath.Combine(Path, path));
        }

        IEnumerable<DirectoryRef> Directories(string searchPattern = "*.*", bool recursive = false)
        {
            var option = recursive ? IO.SearchOption.AllDirectories : IO.SearchOption.TopDirectoryOnly;
            return SDirectory.EnumerateDirectories(Path, searchPattern, option).Select(path => new DirectoryImpl(path));
        }

        IEnumerable<FileRef> Files(string searchPattern = "*.*", bool recursive = false)
        {
            var option = recursive ? IO.SearchOption.AllDirectories : IO.SearchOption.TopDirectoryOnly;
            return SDirectory.EnumerateFiles(Path, searchPattern, option).Select(path => new FileImpl(path));
        }
    }
}
