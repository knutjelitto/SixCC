// See https://aka.ms/new-console-template for more information


using SixBot.Ast;

var g = new Grammar(
        new Rule("E", new Alt(new Seq(new Reference("E"), new Literal("+"), new Reference("E")), new Literal("e")))
    );

Console.WriteLine("Hello, World!");
Console.ReadKey(true);