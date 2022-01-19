﻿using Six.Runtime;

namespace Six.Ceylon
{
    public class Module
    {
        public Module(FileJob moduleFile)
        {
            ModuleFile = moduleFile;
        }

        public FileJob ModuleFile { get; }
        public List<Package> Packages { get; } = new List<Package>();

        public string Name => Path.GetDirectoryName(ModuleFile.Fullname)!.Replace("\\", ".");
    }
}
