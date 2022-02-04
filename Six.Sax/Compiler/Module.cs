﻿using Six.Runtime;

namespace Six.Sax.Compiler
{
    public class Module
    {
        public Module(SourceFile moduleFile)
        {
            ModuleFile = moduleFile;
        }

        public SourceFile ModuleFile { get; }
        public List<Folder> Folders { get; } = new List<Folder>();

        public string Name => Path.GetDirectoryName(ModuleFile.ShortPath)!.Replace("\\", "/");
    }
}
