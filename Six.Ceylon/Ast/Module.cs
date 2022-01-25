﻿namespace Six.Ceylon.Ast
{
    public class Module
    {
        public Module(SourceFile moduleFile)
        {
            ModuleFile = moduleFile;
        }

        public SourceFile ModuleFile { get; }
        public List<Package> Packages { get; } = new List<Package>();

        public string Name => Path.GetDirectoryName(ModuleFile.ShortPath)!.Replace("\\", ".");
    }
}
