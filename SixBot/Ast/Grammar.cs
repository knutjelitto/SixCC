﻿namespace SixBot.Ast
{
    internal class Grammar
    {
        public Grammar(string name, UniqueList<string, Rule> rules)
        {
            Name = name;
            Rules = rules;
        }

        public string Name { get; }
        public UniqueList<string, Rule> Rules { get; }
    }
}
