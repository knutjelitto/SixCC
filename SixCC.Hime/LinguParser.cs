/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.5.0.0
 */
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Hime.Redist;
using Hime.Redist.Parsers;

namespace SixCc.Hime
{
	/// <summary>
	/// Represents a parser
	/// </summary>
	[GeneratedCodeAttribute("Hime.SDK", "3.5.0.0")]
	public class LinguParser : LRkParser
	{
		/// <summary>
		/// The automaton for this parser
		/// </summary>
		private static readonly LRkAutomaton commonAutomaton = LRkAutomaton.Find(typeof(LinguParser), "LinguParser.bin");
		/// <summary>
		/// Contains the constant IDs for the variables and virtuals in this parser
		/// </summary>
		[GeneratedCodeAttribute("Hime.SDK", "3.5.0.0")]
		public class ID
		{
			/// <summary>
			/// The unique identifier for variable file
			/// </summary>
			public const int VariableFile = 0x0016;
			/// <summary>
			/// The unique identifier for variable cf_grammar
			/// </summary>
			public const int VariableCfGrammar = 0x0017;
			/// <summary>
			/// The unique identifier for variable grammar_item
			/// </summary>
			public const int VariableGrammarItem = 0x0018;
			/// <summary>
			/// The unique identifier for variable grammar_options
			/// </summary>
			public const int VariableGrammarOptions = 0x0019;
			/// <summary>
			/// The unique identifier for variable option
			/// </summary>
			public const int VariableOption = 0x001A;
			/// <summary>
			/// The unique identifier for variable range
			/// </summary>
			public const int VariableRange = 0x001B;
			/// <summary>
			/// The unique identifier for variable character
			/// </summary>
			public const int VariableCharacter = 0x001C;
			/// <summary>
			/// The unique identifier for variable string
			/// </summary>
			public const int VariableString = 0x001D;
			/// <summary>
			/// The unique identifier for variable grammar_rules
			/// </summary>
			public const int VariableGrammarRules = 0x001E;
			/// <summary>
			/// The unique identifier for variable rule
			/// </summary>
			public const int VariableRule = 0x001F;
			/// <summary>
			/// The unique identifier for variable rule_expression
			/// </summary>
			public const int VariableRuleExpression = 0x0020;
			/// <summary>
			/// The unique identifier for variable rule_alternative
			/// </summary>
			public const int VariableRuleAlternative = 0x0021;
			/// <summary>
			/// The unique identifier for variable rule_sequence
			/// </summary>
			public const int VariableRuleSequence = 0x0022;
			/// <summary>
			/// The unique identifier for variable rule_repetition
			/// </summary>
			public const int VariableRuleRepetition = 0x0023;
			/// <summary>
			/// The unique identifier for variable rule_element
			/// </summary>
			public const int VariableRuleElement = 0x0024;
			/// <summary>
			/// The unique identifier for variable rule_sub
			/// </summary>
			public const int VariableRuleSub = 0x0025;
			/// <summary>
			/// The unique identifier for variable rule_not
			/// </summary>
			public const int VariableRuleNot = 0x0026;
			/// <summary>
			/// The unique identifier for variable rule_atom
			/// </summary>
			public const int VariableRuleAtom = 0x0027;
			/// <summary>
			/// The unique identifier for variable reference
			/// </summary>
			public const int VariableReference = 0x0028;
		}
		/// <summary>
		/// The collection of variables matched by this parser
		/// </summary>
		/// <remarks>
		/// The variables are in an order consistent with the automaton,
		/// so that variable indices in the automaton can be used to retrieve the variables in this table
		/// </remarks>
		private static readonly Symbol[] variables = {
			new Symbol(0x0016, "file"), 
			new Symbol(0x0017, "cf_grammar"), 
			new Symbol(0x0018, "grammar_item"), 
			new Symbol(0x0019, "grammar_options"), 
			new Symbol(0x001A, "option"), 
			new Symbol(0x001B, "range"), 
			new Symbol(0x001C, "character"), 
			new Symbol(0x001D, "string"), 
			new Symbol(0x001E, "grammar_rules"), 
			new Symbol(0x001F, "rule"), 
			new Symbol(0x0020, "rule_expression"), 
			new Symbol(0x0021, "rule_alternative"), 
			new Symbol(0x0022, "rule_sequence"), 
			new Symbol(0x0023, "rule_repetition"), 
			new Symbol(0x0024, "rule_element"), 
			new Symbol(0x0025, "rule_sub"), 
			new Symbol(0x0026, "rule_not"), 
			new Symbol(0x0027, "rule_atom"), 
			new Symbol(0x0028, "reference"), 
			new Symbol(0x002B, "__V43"), 
			new Symbol(0x002C, "__V44"), 
			new Symbol(0x002F, "__V47"), 
			new Symbol(0x0030, "__V48"), 
			new Symbol(0x0035, "__V53"), 
			new Symbol(0x0036, "__V54"), 
			new Symbol(0x003A, "__V58"), 
			new Symbol(0x003C, "__V60"), 
			new Symbol(0x0043, "__VAxiom") };
		/// <summary>
		/// The collection of virtuals matched by this parser
		/// </summary>
		/// <remarks>
		/// The virtuals are in an order consistent with the automaton,
		/// so that virtual indices in the automaton can be used to retrieve the virtuals in this table
		/// </remarks>
		private static readonly Symbol[] virtuals = {
 };
		/// <summary>
		/// Initializes a new instance of the parser
		/// </summary>
		/// <param name="lexer">The input lexer</param>
		public LinguParser(LinguLexer lexer) : base (commonAutomaton, variables, virtuals, null, lexer) { }

		/// <summary>
		/// Visitor interface
		/// </summary>
		[GeneratedCodeAttribute("Hime.SDK", "3.5.0.0")]
		public class Visitor
		{
			public virtual void OnTerminalBlockComment(ASTNode node) {}
			public virtual void OnTerminalSpace(ASTNode node) {}
			public virtual void OnTerminalName(ASTNode node) {}
			public virtual void OnTerminalInteger(ASTNode node) {}
			public virtual void OnTerminalLiteralAny(ASTNode node) {}
			public virtual void OnTerminalLiteralText(ASTNode node) {}
			public virtual void OnTerminalUnicodeBlock(ASTNode node) {}
			public virtual void OnTerminalUnicodeCategory(ASTNode node) {}
			public virtual void OnTerminalUnicodeCodepoint(ASTNode node) {}
			public virtual void OnVariableFile(ASTNode node) {}
			public virtual void OnVariableCfGrammar(ASTNode node) {}
			public virtual void OnVariableGrammarItem(ASTNode node) {}
			public virtual void OnVariableGrammarOptions(ASTNode node) {}
			public virtual void OnVariableOption(ASTNode node) {}
			public virtual void OnVariableRange(ASTNode node) {}
			public virtual void OnVariableCharacter(ASTNode node) {}
			public virtual void OnVariableString(ASTNode node) {}
			public virtual void OnVariableGrammarRules(ASTNode node) {}
			public virtual void OnVariableRule(ASTNode node) {}
			public virtual void OnVariableRuleExpression(ASTNode node) {}
			public virtual void OnVariableRuleAlternative(ASTNode node) {}
			public virtual void OnVariableRuleSequence(ASTNode node) {}
			public virtual void OnVariableRuleRepetition(ASTNode node) {}
			public virtual void OnVariableRuleElement(ASTNode node) {}
			public virtual void OnVariableRuleSub(ASTNode node) {}
			public virtual void OnVariableRuleNot(ASTNode node) {}
			public virtual void OnVariableRuleAtom(ASTNode node) {}
			public virtual void OnVariableReference(ASTNode node) {}
		}

		/// <summary>
		/// Walk the AST of a result using a visitor
		/// <param name="result">The parse result</param>
		/// <param name="visitor">The visitor to use</param>
		/// </summary>
		public static void Visit(ParseResult result, Visitor visitor)
		{
			VisitASTNode(result.Root, visitor);
		}

		/// <summary>
		/// Walk the sub-AST from the specified node using a visitor
		/// </summary>
		/// <param name="node">The AST node to start from</param>
		/// <param name="visitor">The visitor to use</param>
		public static void VisitASTNode(ASTNode node, Visitor visitor)
		{
			for (int i = 0; i < node.Children.Count; i++)
				VisitASTNode(node.Children[i], visitor);
			switch(node.Symbol.ID)
			{
				case 0x0007: visitor.OnTerminalBlockComment(node); break;
				case 0x0008: visitor.OnTerminalSpace(node); break;
				case 0x000E: visitor.OnTerminalName(node); break;
				case 0x000F: visitor.OnTerminalInteger(node); break;
				case 0x0011: visitor.OnTerminalLiteralAny(node); break;
				case 0x0012: visitor.OnTerminalLiteralText(node); break;
				case 0x0013: visitor.OnTerminalUnicodeBlock(node); break;
				case 0x0014: visitor.OnTerminalUnicodeCategory(node); break;
				case 0x0015: visitor.OnTerminalUnicodeCodepoint(node); break;
				case 0x0016: visitor.OnVariableFile(node); break;
				case 0x0017: visitor.OnVariableCfGrammar(node); break;
				case 0x0018: visitor.OnVariableGrammarItem(node); break;
				case 0x0019: visitor.OnVariableGrammarOptions(node); break;
				case 0x001A: visitor.OnVariableOption(node); break;
				case 0x001B: visitor.OnVariableRange(node); break;
				case 0x001C: visitor.OnVariableCharacter(node); break;
				case 0x001D: visitor.OnVariableString(node); break;
				case 0x001E: visitor.OnVariableGrammarRules(node); break;
				case 0x001F: visitor.OnVariableRule(node); break;
				case 0x0020: visitor.OnVariableRuleExpression(node); break;
				case 0x0021: visitor.OnVariableRuleAlternative(node); break;
				case 0x0022: visitor.OnVariableRuleSequence(node); break;
				case 0x0023: visitor.OnVariableRuleRepetition(node); break;
				case 0x0024: visitor.OnVariableRuleElement(node); break;
				case 0x0025: visitor.OnVariableRuleSub(node); break;
				case 0x0026: visitor.OnVariableRuleNot(node); break;
				case 0x0027: visitor.OnVariableRuleAtom(node); break;
				case 0x0028: visitor.OnVariableReference(node); break;
			}
		}
	}
}
