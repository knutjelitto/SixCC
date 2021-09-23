using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Six.Ceylon.Ast;
using Six.Ceylon.Errors;
using Six.Tools;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using String = Six.Ceylon.Ast.String;
using Type = Six.Ceylon.Ast.Type;

namespace Six.Ceylon
{
    public class AstBuilder : ICeylonParserListener
    {
        private readonly bool skipImplemented = true;
        private int level = 0;
        private int count = 0;
        public int missings = 0;

        private readonly ParseTreeProperty<INode> properties = new();

        public AntlrInputStream Characters { get; }
        public FileRef File { get; }
        public BufferedTokenStream Tokens { get; }

        public AstBuilder(FileRef file, BufferedTokenStream tokens, AntlrInputStream characters)
        {
            File = file;
            Tokens = tokens;
            Characters = characters;
        }

        public CompilationUnit Walk(CeylonParser.CompilationUnitContext context)
        {
            var walker = new ParseTreeWalker();
            walker.Walk(this, context);
            return Get<CompilationUnit>(context);
        }

        private void Return(IParseTree node, INode value)
        {
            Debug.Assert(node != null);
            Debug.Assert(value != null);
            value.SourceReference = new SourceReference(node, File, Tokens, Characters);
            properties.Put(node, value);
            EnterExit(true);
        }

        private T Get<T>(IParseTree node)
            where T : INode
        {
            Debug.Assert(node != null);
            return (T)properties.Get(node);
        }

        private T? GetOptional<T>(IParseTree? node)
            where T : INode
        {
            if (node == null)
            {
                return default;
            }
            return (T)properties.Get(node);
        }

        private IEnumerable<T> GetMany<T>(IEnumerable<IParseTree> nodes)
            where T : INode
        {
            return nodes.Select(i => Get<T>(i));
        }

        private void Lift(IParseTree node)
        {
            Debug.Assert(node.ChildCount == 1);
            properties.Put(node, properties.Get(node.GetChild(0)));
            EnterExit(true);
        }

        private void Implemented([CallerMemberName] string enterExit = "")
        {
            Debug.Assert(enterExit.StartsWith("Enter"));
            EnterExit(true, enterExit);
        }

        private void NotImplemented([CallerMemberName] string enterExit = "")
        {
            Debug.Assert(enterExit.StartsWith("Enter") || enterExit.StartsWith("Exit"));
            EnterExit(false, enterExit);
        }

        public void VisitErrorNode(IErrorNode node)
        {
            NotImplemented();
        }

        public void VisitTerminal(ITerminalNode node)
        {
            var spaceBefore = Tokens.GetHiddenTokensToLeft(node.Symbol.TokenIndex);

            properties.Put(node, new Terminal(node, spaceBefore));
            EnterExit(true);
        }

        private void EnterExit(bool implemented = false, [CallerMemberName] string enterExit = "")
        {
            if (skipImplemented && implemented)
            {
                return;
            }

            if (!implemented)
            {
                missings += 1;
            }

            if (count >= 60)
            {
                return;
            }
            if (enterExit.StartsWith("Enter"))
            {
                enterExit = enterExit[5..];
                print();
                level += 1;
            }
            else if (enterExit.StartsWith("Exit"))
            {
                level -= 1;
                enterExit = enterExit[4..];
                print();
            }
            else
            {
                enterExit = enterExit[5..];
                print();
            }

            void print()
            {
                var prefix = new string(' ', level * 4);
                System.Console.WriteLine($"{prefix}{enterExit}");
                count += implemented ? 0 : 1;
            }
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            //NotImplemented();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            //NotImplemented();
        }

        public void ExitAbstractedType([NotNull] CeylonParser.AbstractedTypeContext context)
        {
            NotImplemented();
        }
        public void EnterAbstractedType([NotNull] CeylonParser.AbstractedTypeContext context) => NotImplemented();


        public void ExitTypeAliasDeclaration([NotNull] CeylonParser.TypeAliasDeclarationContext context)
        {
            var header = Get<AliasHeader>(context.aliasHeader());
            var type = Get<TypeDefinition>(context.typeDefinition());
            Return(context, new AliasDeclaration(header, type));
        }
        public void EnterTypeAliasDeclaration([NotNull] CeylonParser.TypeAliasDeclarationContext context) => Implemented();


        public void ExitAliasHeader([NotNull] CeylonParser.AliasHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var typeName = Get<Name>(context.typeName());
            var parameters = GetOptional<TypeParameters>(context.typeParameters());
            var constraints = GetOptional<TypeConstraints>(context.typeConstraints());
            Return(context, new AliasHeader(annotations, typeName, parameters, constraints));
        }
        public void EnterAliasHeader([NotNull] CeylonParser.AliasHeaderContext context) => Implemented();


        public void ExitAnnotation([NotNull] CeylonParser.AnnotationContext context)
        {
            var name = Get<Name>(context.memberName());
            var arguments = GetOptional<Arguments>(context.arguments());
            Return(context, new Annotation(name, arguments));
        }
        public void EnterAnnotation([NotNull] CeylonParser.AnnotationContext context) => Implemented();


        public void ExitAnnotations([NotNull] CeylonParser.AnnotationsContext context)
        {
            var doc = GetOptional<String>(context.stringLiteral());
            var annotations = GetMany<Annotation>(context.annotation());
            Return(context, new Annotations(doc, annotations));
        }
        public void EnterAnnotations([NotNull] CeylonParser.AnnotationsContext context) => Implemented();


        public void ExitAnonymousArgument([NotNull] CeylonParser.AnonymousArgumentContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new AnonymousArgument(expression));
        }
        public void EnterAnonymousArgument([NotNull] CeylonParser.AnonymousArgumentContext context) => Implemented();


        public void ExitArgumentList([NotNull] CeylonParser.ArgumentListContext context)
        {
            var arguments = new List<Argument>();
            if (context.ChildCount == 0)
            {
                Debug.Assert(context.argumentListLast() == null);
                Debug.Assert(context.listedArgument().Length == 0);
            }
            foreach (var listed in context.listedArgument())
            {
                arguments.Add(Get<Argument>(listed));
            }
            if (context.argumentListLast() != null)
            {
                arguments.Add(Get<Argument>(context.argumentListLast()));
            }
            Return(context, new ArgumentList(arguments));
        }
        public void EnterArgumentList([NotNull] CeylonParser.ArgumentListContext context) => Implemented();


        public void ExitArgumentListLast([NotNull] CeylonParser.ArgumentListLastContext context)
        {
            Lift(context);
        }
        public void EnterArgumentListLast([NotNull] CeylonParser.ArgumentListLastContext context) => Implemented();


        public void ExitArguments([NotNull] CeylonParser.ArgumentsContext context)
        {
            Lift(context);
        }
        public void EnterArguments([NotNull] CeylonParser.ArgumentsContext context) => Implemented();


        public void ExitCountedTupleType([NotNull] CeylonParser.CountedTupleTypeContext context)
        {
            var type = Get<Type>(context.primaryType());
            var integer = Get<Integer>(context.integerLiteral());
            Return(context, new CountedTupleType(type, integer));
        }
        public void EnterCountedTupleType([NotNull] CeylonParser.CountedTupleTypeContext context) => Implemented();


        public void ExitClassifier([NotNull] CeylonParser.ClassifierContext context)
        {
            var literal = Get<String>(context.stringLiteral());
            Return(context, new ModuleClassifier(literal));
        }
        public void EnterClassifier([NotNull] CeylonParser.ClassifierContext context) => Implemented();


        public void ExitArtifact([NotNull] CeylonParser.ArtifactContext context)
        {
            var literal = Get<String>(context.stringLiteral());
            Return(context, new ModuleArtifact(literal));
        }
        public void EnterArtifact([NotNull] CeylonParser.ArtifactContext context) => Implemented();


        public void ExitAssertion([NotNull] CeylonParser.AssertionContext context)
        {
            var message = GetOptional<Expression>(context.assertionMessage());
            var conditions = Get<Conditions>(context.conditionList());
            Return(context, new AssertionStatement(message, conditions));
        }
        public void EnterAssertion([NotNull] CeylonParser.AssertionContext context) => Implemented();

        public void ExitAssertionMessage([NotNull] CeylonParser.AssertionMessageContext context)
        {
            Lift(context);
        }
        public void EnterAssertionMessage([NotNull] CeylonParser.AssertionMessageContext context) => Implemented();


        public void ExitAtom([NotNull] CeylonParser.AtomContext context)
        {
            Lift(context);
        }
        public void EnterAtom([NotNull] CeylonParser.AtomContext context) => Implemented();


        public void ExitAtomExpr([NotNull] CeylonParser.AtomExprContext context)
        {
            Lift(context);
        }
        public void EnterAtomExpr([NotNull] CeylonParser.AtomExprContext context) => Implemented();


        public void ExitBaseExpression([NotNull] CeylonParser.BaseExpressionContext context)
        {
            var qualifier = GetOptional<PackageQualifier>(context.packageQualifier());
            var name = Get<NameWithArguments>(context.nameWithArguments());
            Return(context, new BaseExpression(qualifier, name));
        }
        public void EnterBaseExpression([NotNull] CeylonParser.BaseExpressionContext context) => Implemented();


        public void ExitBaseMeta([NotNull] CeylonParser.BaseMetaContext context)
        {
            NotImplemented();
        }
        public void EnterBaseMeta([NotNull] CeylonParser.BaseMetaContext context) => NotImplemented();


        public void ExitBlockDefinition([NotNull] CeylonParser.BlockDefinitionContext context)
        {
            var imports = Get<Imports>(context.imports());
            var members = new Members(GetMany<Member>(context.blockMember()));
            Return(context, new BlockDefinition(imports, members));
        }
        public void EnterBlockDefinition([NotNull] CeylonParser.BlockDefinitionContext context) => Implemented();


        public void ExitBooleanCondition([NotNull] CeylonParser.BooleanConditionContext context)
        {
            Lift(context);
        }
        public void EnterBooleanCondition([NotNull] CeylonParser.BooleanConditionContext context) => Implemented();


        public void ExitBreakDirective([NotNull] CeylonParser.BreakDirectiveContext context)
        {
            Return(context, new BreakStatement());
        }
        public void EnterBreakDirective([NotNull] CeylonParser.BreakDirectiveContext context) => Implemented();


        public void ExitCallableConstructorHeader([NotNull] CeylonParser.CallableConstructorHeaderContext context)
        {
            var memberName = GetOptional<Name>(context.memberName());
            var parameters = Get<Parameters>(context.parameters());
            var extendedType = GetOptional<ExtendedType>(context.extendedType());
            Return(context, new CallableConstructorHeader(memberName, parameters, extendedType));
        }
        public void EnterCallableConstructorHeader([NotNull] CeylonParser.CallableConstructorHeaderContext context) => Implemented();


        public void ExitCallableParameter([NotNull] CeylonParser.CallableParameterContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var prefix = Get<Type>(context.callableParameterPrefix());
            var name = Get<Name>(context.memberName());
            var parameters = GetMany<Parameters>(context.parameters());
            Return(context, new CallableParameter(annotations, prefix, name, parameters));
        }
        public void EnterCallableParameter([NotNull] CeylonParser.CallableParameterContext context) => Implemented();


        public void ExitCallableParameterPrefix([NotNull] CeylonParser.CallableParameterPrefixContext context)
        {
            if (context.type() != null)
            {
                Lift(context);
            }
            else
            {
                var terminal = Get<Terminal>(context.GetChild(0));
                Return(context, new PrefixType(terminal));
            }
        }
        public void EnterCallableParameterPrefix([NotNull] CeylonParser.CallableParameterPrefixContext context) => Implemented();


        public void ExitCallableType([NotNull] CeylonParser.CallableTypeContext context)
        {
            var primary = Get<Type>(context.primaryType());
            TypeList typeList;
            if (context.spreadType() != null)
            {
                typeList = new TypeList(Enumerable.Repeat(Get<Type>(context.spreadType()), 1), null);
            }
            else if (context.typeList() != null)
            {
                typeList = Get<TypeList>(context.typeList());
            }
            else
            {
                typeList = new TypeList(Enumerable.Empty<Type>(), null);
            }
            Return(context, new CallableType(primary, typeList));
        }
        public void EnterCallableType([NotNull] CeylonParser.CallableTypeContext context) => Implemented();


        public void ExitCase([NotNull] CeylonParser.CaseContext context)
        {
            var condition = Get<CaseCondition>(context.caseCondition());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new CaseStatementCase(condition, block));
        }
        public void EnterCase([NotNull] CeylonParser.CaseContext context) => Implemented();


        public void ExitCaseCondition([NotNull] CeylonParser.CaseConditionContext context)
        {
            var condition = GetOptional<ConditionForCase>(context.valueCase()) ??
                            GetOptional<ConditionForCase>(context.typeCase()) ??
                            Get<ConditionForCase>(context.patternCase());
            Return(context, new CaseCondition(condition));
        }
        public void EnterCaseCondition([NotNull] CeylonParser.CaseConditionContext context) => Implemented();


        public void ExitCaseExpression([NotNull] CeylonParser.CaseExpressionContext context)
        {
            var condition = Get<CaseCondition>(context.caseCondition());
            var expression = Get<Expression>(context.expression());
            Return(context, new CaseExpression(condition, expression));
        }
        public void EnterCaseExpression([NotNull] CeylonParser.CaseExpressionContext context) => Implemented();


        public void ExitCaseType([NotNull] CeylonParser.CaseTypeContext context)
        {
            Return(context, new CaseType(Get<Type>(context.primaryType())));
        }
        public void EnterCaseType([NotNull] CeylonParser.CaseTypeContext context) => Implemented();


        public void ExitCaseTypes([NotNull] CeylonParser.CaseTypesContext context)
        {
            var items = GetMany<OfCaseItem>(context.ofCaseItem());
            Return(context, new CaseTypes(items));
        }
        public void EnterCaseTypes([NotNull] CeylonParser.CaseTypesContext context) => Implemented();


        public void ExitCaseValue([NotNull] CeylonParser.CaseValueContext context)
        {
            var qualifier = GetOptional<PackageQualifier>(context.packageQualifier());
            var memberName = Get<Name>(context.memberName());
            Return(context, new CaseValue(qualifier, memberName));
        }
        public void EnterCaseValue([NotNull] CeylonParser.CaseValueContext context) => Implemented();


        public void ExitCatchBlock([NotNull] CeylonParser.CatchBlockContext context)
        {
            var variable = Get<Variable>(context.variable());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new CatchBlock(variable, block));
        }
        public void EnterCatchBlock([NotNull] CeylonParser.CatchBlockContext context) => Implemented();


        public void ExitCharacterLiteral([NotNull] CeylonParser.CharacterLiteralContext context)
        {
            Return(context, new Character(Get<Terminal>(context.GetChild(0))));
        }
        public void EnterCharacterLiteral([NotNull] CeylonParser.CharacterLiteralContext context) => Implemented();


        public void ExitClassBlock([NotNull] CeylonParser.ClassBlockContext context)
        {
            var imports = Get<Imports>(context.imports());
            var members = new Members(GetMany<Member>(context.classMember()));
            var item = new BlockDefinition(imports, members);
            Return(context, item);
        }
        public void EnterClassBlock([NotNull] CeylonParser.ClassBlockContext context) => Implemented();


        public void ExitClassDeclaration([NotNull] CeylonParser.ClassDeclarationContext context)
        {
            var header = Get<ClassHeader>(context.classHeader());
            var body = Get<Definition>(context.classBody());
            Return(context, new ClassDeclaration(header, body));
        }
        public void EnterClassDeclaration([NotNull] CeylonParser.ClassDeclarationContext context) => Implemented();


        public void ExitClassHeader([NotNull] CeylonParser.ClassHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var name = Get<Name>(context.typeName());
            var typeParameters = GetOptional<TypeParameters>(context.typeParameters());
            var parameters = GetOptional<Parameters>(context.parameters());
            var inheritance = Get<ClassInheritance>(context.classInheritance());
            var constraints = GetOptional<TypeConstraints>(context.typeConstraints());

            var item = new ClassHeader(annotations, name, typeParameters, parameters, inheritance, constraints);
            Return(context, item);
        }
        public void EnterClassHeader([NotNull] CeylonParser.ClassHeaderContext context) => Implemented();


        public void ExitClassInheritance([NotNull] CeylonParser.ClassInheritanceContext context)
        {
            var caseTypes = GetOptional<CaseTypes>(context.caseTypes());
            var extendedType = GetOptional<ExtendedType>(context.extendedType());
            var satisfiedTypes = GetOptional<SatisfiedTypes>(context.satisfiedTypes());
            var item = new ClassInheritance(caseTypes, extendedType, satisfiedTypes);
            Return(context, item);
        }
        public void EnterClassInheritance([NotNull] CeylonParser.ClassInheritanceContext context) => Implemented();


        public void ExitClassSpecifier([NotNull] CeylonParser.ClassSpecifierContext context)
        {
            var extension = Get<Extension>(context.extension());
            Return(context, new ExtensionSpecifier(extension));
        }
        public void EnterClassSpecifier([NotNull] CeylonParser.ClassSpecifierContext context) => Implemented();


        public void ExitCompilationUnit([NotNull] CeylonParser.CompilationUnitContext context)
        {
            var declarations = GetMany<Declaration>(context.toplevelDeclaration());
            var eof = Get<Eof>(context.eof());
            Return(context, new CompilationUnit(declarations, eof));
        }
        public void EnterCompilationUnit([NotNull] CeylonParser.CompilationUnitContext context) => Implemented();


        public void ExitComprehension([NotNull] CeylonParser.ComprehensionContext context)
        {
            Lift(context);
        }
        public void EnterComprehension([NotNull] CeylonParser.ComprehensionContext context) => Implemented();


        public void ExitComprehensionClause([NotNull] CeylonParser.ComprehensionClauseContext context)
        {
            Lift(context);
        }
        public void EnterComprehensionClause([NotNull] CeylonParser.ComprehensionClauseContext context) => Implemented();


        public void ExitCondition([NotNull] CeylonParser.ConditionContext context)
        {
            Lift(context);
        }
        public void EnterCondition([NotNull] CeylonParser.ConditionContext context) => Implemented();


        public void ExitConditionalExpression([NotNull] CeylonParser.ConditionalExpressionContext context)
        {
            Lift(context);
        }
        public void EnterConditionalExpression([NotNull] CeylonParser.ConditionalExpressionContext context) => Implemented();

        public void ExitConditionList([NotNull] CeylonParser.ConditionListContext context)
        {
            var items = GetMany<Condition>(context.condition());
            Return(context, new Conditions(items));
        }
        public void EnterConditionList([NotNull] CeylonParser.ConditionListContext context) => Implemented();


        public void ExitConstantExpression([NotNull] CeylonParser.ConstantExpressionContext context)
        {
            Lift(context);
        }
        public void EnterConstantExpression([NotNull] CeylonParser.ConstantExpressionContext context) => Implemented();


        public void ExitConstructorDeclaration([NotNull] CeylonParser.ConstructorDeclarationContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var header = Get<ConstructorHeader>(context.constructorHeader());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new ConstructorDeclaration(annotations, header, block));
        }
        public void EnterConstructorDeclaration([NotNull] CeylonParser.ConstructorDeclarationContext context) => Implemented();


        public void ExitConstructorHeader([NotNull] CeylonParser.ConstructorHeaderContext context)
        {
            Lift(context);
        }
        public void EnterConstructorHeader([NotNull] CeylonParser.ConstructorHeaderContext context) => Implemented();


        public void ExitConstructorMeta([NotNull] CeylonParser.ConstructorMetaContext context)
        {
            NotImplemented();
        }
        public void EnterConstructorMeta([NotNull] CeylonParser.ConstructorMetaContext context) => NotImplemented();


        public void ExitContinueDirective([NotNull] CeylonParser.ContinueDirectiveContext context)
        {
            Return(context, new ContinueStatement());
        }
        public void EnterContinueDirective([NotNull] CeylonParser.ContinueDirectiveContext context) => Implemented();


        public void ExitControlStructure([NotNull] CeylonParser.ControlStructureContext context)
        {
            Lift(context);
        }
        public void EnterControlStructure([NotNull] CeylonParser.ControlStructureContext context) => Implemented();


        public void ExitDeclaration([NotNull] CeylonParser.DeclarationContext context)
        {
            Lift(context);
        }
        public void EnterDeclaration([NotNull] CeylonParser.DeclarationContext context) => Implemented();


        public void ExitDefaulted([NotNull] CeylonParser.DefaultedContext context)
        {
            var parameter = Get<Parameter>(context.GetChild(0));
            var specifier = Get<Specifier>(context.GetChild(1));
            Return(context, new DefaultedParameter(parameter, specifier));
        }
        public void EnterDefaulted([NotNull] CeylonParser.DefaultedContext context) => Implemented();


        public void ExitDefaultedType([NotNull] CeylonParser.DefaultedTypeContext context)
        {
            var type = Get<Type>(context.type());
            var specify = GetOptional<Terminal>(context.SPECIFY());
            if (specify == null)
            {
                Return(context, type);
            }
            else
            {
                Return(context, new DefaultedType(type));
            }
        }
        public void EnterDefaultedType([NotNull] CeylonParser.DefaultedTypeContext context) => Implemented();


        public void ExitDestructure([NotNull] CeylonParser.DestructureContext context)
        {
            NotImplemented();
        }
        public void EnterDestructure([NotNull] CeylonParser.DestructureContext context) => NotImplemented();


        public void ExitDirective([NotNull] CeylonParser.DirectiveContext context)
        {
            Lift(context);
        }
        public void EnterDirective([NotNull] CeylonParser.DirectiveContext context) => Implemented();


        public void ExitDynamicBlock([NotNull] CeylonParser.DynamicBlockContext context)
        {
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new DynamicStatement(block));
        }
        public void EnterDynamicBlock([NotNull] CeylonParser.DynamicBlockContext context) => Implemented();


        public void ExitDynamicValue([NotNull] CeylonParser.DynamicValueContext context)
        {
            var named = Get<NamedArgumentList>(context.namedArgumentList());
            var positional = Get<ArgumentList>(context.argumentList());
            Return(context, new DynamicValueExpression(named, positional));
        }
        public void EnterDynamicValue([NotNull] CeylonParser.DynamicValueContext context) => Implemented();


        public void ExitElsePart([NotNull] CeylonParser.ElsePartContext context)
        {
            var block = GetOptional<Block>(context.blockDefinition()) ?? Get<Block>(context.ifElse());
            Return(context, new ElsePart(block));
        }
        public void EnterElsePart([NotNull] CeylonParser.ElsePartContext context) => Implemented();


        public void ExitElseExpression([NotNull] CeylonParser.ElseExpressionContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new ElseExpressionPart(expression));
        }
        public void EnterElseExpression([NotNull] CeylonParser.ElseExpressionContext context) => Implemented();

        public void ExitEmptyType([NotNull] CeylonParser.EmptyTypeContext context)
        {
            Return(context, new EmptyType());
        }
        public void EnterEmptyType([NotNull] CeylonParser.EmptyTypeContext context) => Implemented();


        public void ExitEntryPattern([NotNull] CeylonParser.EntryPatternContext context)
        {
            var key = Get<Pattern>(context.key);
            var item = Get<Pattern>(context.item);
            Return(context, new EntryPattern(key, item));
        }
        public void EnterEntryPattern([NotNull] CeylonParser.EntryPatternContext context) => Implemented();


        public void ExitEntryType([NotNull] CeylonParser.EntryTypeContext context)
        {
            var key = Get<Type>(context.key);
            var item = Get<Type>(context.item);
            Return(context, new EntryType(key, item));
        }
        public void EnterEntryType([NotNull] CeylonParser.EntryTypeContext context) => Implemented();


        public void ExitEnumeration([NotNull] CeylonParser.EnumerationContext context)
        {
            Lift(context);
        }
        public void EnterEnumeration([NotNull] CeylonParser.EnumerationContext context) => Implemented();


        public void ExitExpressionStatement([NotNull] CeylonParser.ExpressionStatementContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new ExpressionStatement(expression));
        }
        public void EnterExpressionStatement([NotNull] CeylonParser.ExpressionStatementContext context) => Implemented();


        public void ExitExtendedType([NotNull] CeylonParser.ExtendedTypeContext context)
        {
            var extensionConstruction = Get<ExtensionConstruction>(context.GetChild(1));
            Return(context, new ExtendedType(extensionConstruction));
        }
        public void EnterExtendedType([NotNull] CeylonParser.ExtendedTypeContext context) => Implemented();


        public void ExitExtension([NotNull] CeylonParser.ExtensionContext context)
        {
            var qualifier = GetOptional<Qualifier>(context.extensionQualifier());
            var names = new NamesWithArguments(GetMany<NameWithArguments>(context.nameWithArguments()));
            var arguments = GetOptional<PositionalArguments>(context.positionalArguments());
            Return(context, new Extension(qualifier, names, arguments));
        }
        public void EnterExtension([NotNull] CeylonParser.ExtensionContext context) => Implemented();


        public void ExitFallback([NotNull] CeylonParser.FallbackContext context)
        {
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new Fallback(block));
        }
        public void EnterFallback([NotNull] CeylonParser.FallbackContext context) => Implemented();


        public void ExitFinallyBlock([NotNull] CeylonParser.FinallyBlockContext context)
        {
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new FinallyBlock(block));
        }
        public void EnterFinallyBlock([NotNull] CeylonParser.FinallyBlockContext context) => Implemented();


        public void ExitForFail([NotNull] CeylonParser.ForFailContext context)
        {
            var iterator = Get<ForIterator>(context.forIterator());
            var block = Get<BlockDefinition>(context.blockDefinition());
            var fallback = GetOptional<Fallback>(context.fallback());
            Return(context, new ForStatement(iterator, block, fallback));
        }
        public void EnterForFail([NotNull] CeylonParser.ForFailContext context) => Implemented();


        public void ExitForIterator([NotNull] CeylonParser.ForIteratorContext context)
        {
            var pattern = Get<Pattern>(context.pattern());
            var expression = Get<Expression>(context.expression());
            Return(context, new ForIterator(pattern, expression));
        }
        public void EnterForIterator([NotNull] CeylonParser.ForIteratorContext context) => Implemented();


        public void ExitFullName([NotNull] CeylonParser.FullNameContext context)
        {
            var names = GetMany<Name>(context.name());
            Return(context, new DottedName(names));
        }
        public void EnterFullName([NotNull] CeylonParser.FullNameContext context) => Implemented();


        public void ExitFunctionArgument([NotNull] CeylonParser.FunctionArgumentContext context)
        {
            var header = Get<FunctionHeader>(context.functionHeader());
            var body = GetOptional<Definition>(context.blockDefinition()) ?? Get<Definition>(context.lazyDefinition());
            Return(context, new FunctionArgument(header, body));
        }
        public void EnterFunctionArgument([NotNull] CeylonParser.FunctionArgumentContext context) => Implemented();


        public void ExitFunctionBody([NotNull] CeylonParser.FunctionBodyContext context)
        {
            Lift(context);
        }
        public void EnterFunctionBody([NotNull] CeylonParser.FunctionBodyContext context) => Implemented();


        public void ExitFunctionDeclaration([NotNull] CeylonParser.FunctionDeclarationContext context)
        {
            var header = Get<FunctionHeader>(context.functionHeader());
            var body = Get<Definition>(context.functionBody());
            Return(context, new FunctionDeclaration(header, body));
        }
        public void EnterFunctionDeclaration([NotNull] CeylonParser.FunctionDeclarationContext context) => Implemented();


        public void ExitFunctionHeader([NotNull] CeylonParser.FunctionHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var prefix = Get<Type>(context.functionPrefix());
            var memberName = Get<Name>(context.memberName());
            var typeParameters = GetOptional<TypeParameters>(context.typeParameters());
            var parameters = new ParametersList(GetMany<Parameters>(context.parameters()));
            var constraints = GetOptional<TypeConstraints>(context.typeConstraints());
            Return(context, new FunctionHeader(annotations, prefix, memberName, typeParameters, parameters, constraints));
        }
        public void EnterFunctionHeader([NotNull] CeylonParser.FunctionHeaderContext context) => Implemented();


        public void ExitFunctionExpression([NotNull] CeylonParser.FunctionExpressionContext context)
        {
            var prefix = GetOptional<Terminal>(context.FUNCTION() ?? context.VOID());
            var parameters = new ParametersList(GetMany<Parameters>(context.parameters()));
            var block = GetOptional<Block>(context.blockDefinition()) ?? Get<Block>(context.lazySpecifier());
            Return(context, new FunctionExpression(prefix, parameters, block));
        }
        public void EnterFunctionExpression([NotNull] CeylonParser.FunctionExpressionContext context) => Implemented();


        public void ExitFunctionPrefix([NotNull] CeylonParser.FunctionPrefixContext context)
        {
            if (context.type() != null)
            {
                Lift(context);
            }
            else
            {
                var terminal = Get<Terminal>(context.GetChild(0));
                Return(context, new PrefixType(terminal));
            }
        }
        public void EnterFunctionPrefix([NotNull] CeylonParser.FunctionPrefixContext context) => Implemented();


        public void ExitGroupedExpression([NotNull] CeylonParser.GroupedExpressionContext context)
        {
            Return(context, Get<Expression>(context.expression()));
        }
        public void EnterGroupedExpression([NotNull] CeylonParser.GroupedExpressionContext context) => Implemented();


        public void ExitGroupedType([NotNull] CeylonParser.GroupedTypeContext context)
        {
            var type = Get<Type>(context.type());
            Return(context, new GroupedType(type));
        }
        public void EnterGroupedType([NotNull] CeylonParser.GroupedTypeContext context) => Implemented();


        public void ExitIfPart([NotNull] CeylonParser.IfPartContext context)
        {
            var conditions = Get<Conditions>(context.conditionList());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new IfPart(conditions, block));
        }
        public void EnterIfPart([NotNull] CeylonParser.IfPartContext context) => Implemented();


        public void ExitForComprehensionClause([NotNull] CeylonParser.ForComprehensionClauseContext context)
        {
            var iterator = Get<ForIterator>(context.forIterator());
            var comprehension = Get<Comprehension>(context.comprehensionClause());
            Return(context, new ForComprehension(iterator, comprehension));
        }
        public void EnterForComprehensionClause([NotNull] CeylonParser.ForComprehensionClauseContext context) => Implemented();


        public void ExitIfComprehensionClause([NotNull] CeylonParser.IfComprehensionClauseContext context)
        {
            var conditions = Get<Conditions>(context.conditionList());
            var comprehension = Get<Comprehension>(context.comprehensionClause());
            Return(context, new IfComprehension(conditions, comprehension));
        }
        public void EnterIfComprehensionClause([NotNull] CeylonParser.IfComprehensionClauseContext context) => Implemented();


        public void ExitIfElse([NotNull] CeylonParser.IfElseContext context)
        {
            var ifPart = Get<IfPart>(context.ifPart());
            var elsePart = GetOptional<ElsePart>(context.elsePart());
            Return(context, new IfElseStatement(ifPart, elsePart));
        }
        public void EnterIfElse([NotNull] CeylonParser.IfElseContext context) => Implemented();


        public void ExitIfElseExpression([NotNull] CeylonParser.IfElseExpressionContext context)
        {
            var conditions = Get<Conditions>(context.conditionList());
            var thenPart = Get<ThenExpressionPart>(context.thenExpression());
            var elsePart = Get<ElseExpressionPart>(context.elseExpression());
            Return(context, new IfElseExpression(conditions, thenPart, elsePart));
        }
        public void EnterIfElseExpression([NotNull] CeylonParser.IfElseExpressionContext context) => Implemented();


        public void ExitImportAlias([NotNull] CeylonParser.ImportAliasContext context)
        {
            var name = Get<Name>(context.name());
            Return(context, new ImportAlias(name));
        }
        public void EnterImportAlias([NotNull] CeylonParser.ImportAliasContext context) => Implemented();


        public void ExitImportDeclaration([NotNull] CeylonParser.ImportDeclarationContext context)
        {
            var name = Get<DottedName>(context.fullName());
            var elements = Get<ImportElements>(context.importElements());
            Return(context, new ImportDeclaration(name, elements));
        }
        public void EnterImportDeclaration([NotNull] CeylonParser.ImportDeclarationContext context) => Implemented();


        public void ExitImportElement([NotNull] CeylonParser.ImportElementContext context)
        {
            var alias = GetOptional<ImportAlias>(context.importAlias());
            var name = Get<Name>(context.name());
            var elements = GetOptional<ImportElements>(context.importElements());
            Return(context, new ImportElement(alias, name, elements));
        }
        public void EnterImportElement([NotNull] CeylonParser.ImportElementContext context) => Implemented();


        public void ExitImportElementList([NotNull] CeylonParser.ImportElementListContext context)
        {
            var items = GetMany<ImportElement>(context.importElement());
            Return(context, new ImportElementList(items));
        }
        public void EnterImportElementList([NotNull] CeylonParser.ImportElementListContext context) => Implemented();


        public void ExitImportElements([NotNull] CeylonParser.ImportElementsContext context)
        {
            var elements = GetOptional<ImportElementList>(context.importElementList());
            var wildcard = GetOptional<ImportWildcard>(context.importWildcard());
            Return(context, new ImportElements(elements, wildcard));
        }
        public void EnterImportElements([NotNull] CeylonParser.ImportElementsContext context) => Implemented();


        public void ExitImportWildcard([NotNull] CeylonParser.ImportWildcardContext context)
        {
            Return(context, new ImportWildcard());
        }
        public void EnterImportWildcard([NotNull] CeylonParser.ImportWildcardContext context) => Implemented();


        public void ExitIndexed([NotNull] CeylonParser.IndexedContext context)
        {
            NotImplemented();
        }
        public void EnterIndexed([NotNull] CeylonParser.IndexedContext context) => NotImplemented();


        public void ExitIndexExpr([NotNull] CeylonParser.IndexExprContext context)
        {
            var expression = Get<Expression>(context.primary());
            var index = Get<IndexRange>(context.indexed());
            Return(context, new IndexExpression(expression, index));
        }
        public void EnterIndexExpr([NotNull] CeylonParser.IndexExprContext context) => Implemented();

        public void ExitInfixExpr([NotNull] CeylonParser.InfixExprContext context)
        {
            Debug.Assert(context.ChildCount == 3);
            var left = Get<Expression>(context.GetChild(0));
            var op = Get<Terminal>(context.GetChild(1));
            var right = Get<Expression>(context.GetChild(2));
            Return(context, new InfixExpression(op, left, right));
        }
        public void EnterInfixExpr([NotNull] CeylonParser.InfixExprContext context) => Implemented();


        public void ExitInlineDeclarationArgument([NotNull] CeylonParser.InlineDeclarationArgumentContext context)
        {
            Lift(context);
        }
        public void EnterInlineDeclarationArgument([NotNull] CeylonParser.InlineDeclarationArgumentContext context) => Implemented();


        public void ExitFloatLiteral([NotNull] CeylonParser.FloatLiteralContext context)
        {
            Return(context, new FloatLiteral(Get<Terminal>(context.GetChild(0))));
        }
        public void EnterFloatLiteral([NotNull] CeylonParser.FloatLiteralContext context) => Implemented();


        public void ExitIntegerLiteral([NotNull] CeylonParser.IntegerLiteralContext context)
        {
            Return(context, new Integer(Get<Terminal>(context.GetChild(0))));
        }
        public void EnterIntegerLiteral([NotNull] CeylonParser.IntegerLiteralContext context) => Implemented();


        public void ExitInterfaceBody([NotNull] CeylonParser.InterfaceBodyContext context)
        {
            var imports = Get<Imports>(context.imports());
            var members = new Members(GetMany<Member>(context.interfaceMember()));
            Return(context, new BlockDefinition(imports, members));
        }
        public void EnterInterfaceBody([NotNull] CeylonParser.InterfaceBodyContext context) => Implemented();


        public void ExitInterfaceDeclaration([NotNull] CeylonParser.InterfaceDeclarationContext context)
        {
            var header = Get<InterfaceHeader>(context.interfaceHeader());
            Definition definition;
            if (context.interfaceBody() != null)
            {
                definition = Get<Definition>(context.interfaceBody());
            }
            else
            {
                definition = Get<Definition>(context.typeDefinition());
            }
            Return(context, new InterfaceDeclaration(header, definition));
        }
        public void EnterInterfaceDeclaration([NotNull] CeylonParser.InterfaceDeclarationContext context) => Implemented();


        public void ExitInterfaceHeader([NotNull] CeylonParser.InterfaceHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var prefix = Get<Keyword>(context.interfacePrefix());
            var typeName = Get<Name>(context.typeName());
            var parameters = GetOptional<TypeParameters>(context.typeParameters());
            var inheritance = Get<InterfaceInheritance>(context.interfaceInheritance());
            var constraints = GetOptional<TypeConstraints>(context.typeConstraints());
            var header = new InterfaceHeader(annotations, prefix, typeName, parameters, inheritance, constraints);
            Return(context, header);
        }
        public void EnterInterfaceHeader([NotNull] CeylonParser.InterfaceHeaderContext context) => Implemented();


        public void ExitInterfaceInheritance([NotNull] CeylonParser.InterfaceInheritanceContext context)
        {
            var caseTypes = GetOptional<CaseTypes>(context.caseTypes());
            var satisfiedTypes = GetOptional<SatisfiedTypes>(context.satisfiedTypes());
            var interfaceInheritance = new InterfaceInheritance(caseTypes, satisfiedTypes);
            Return(context, interfaceInheritance);
        }
        public void EnterInterfaceInheritance([NotNull] CeylonParser.InterfaceInheritanceContext context) => Implemented();


        public void ExitInterfacePrefix([NotNull] CeylonParser.InterfacePrefixContext context)
        {
            var keyword = new Keyword(Get<Terminal>(context.GetChild(0)));
            Return(context, keyword);
        }
        public void EnterInterfacePrefix([NotNull] CeylonParser.InterfacePrefixContext context) => Implemented();


        public void ExitInvocation([NotNull] CeylonParser.InvocationContext context) => NotImplemented();
        public void EnterInvocation([NotNull] CeylonParser.InvocationContext context) => NotImplemented();


        public void ExitInvokeExpr([NotNull] CeylonParser.InvokeExprContext context)
        {
            var primary = Get<Expression>(context.primary());
            var arguments = Get<Arguments>(context.arguments());
            Return(context, new InvokeExpression(primary, arguments));
        }
        public void EnterInvokeExpr([NotNull] CeylonParser.InvokeExprContext context) => Implemented();



        public void ExitIterable([NotNull] CeylonParser.IterableContext context)
        {
            var arguments = Get<ArgumentList>(context.argumentList());
            Return(context, new IterableExpression(arguments));
        }
        public void EnterIterable([NotNull] CeylonParser.IterableContext context) => Implemented();


        public void ExitIterableType([NotNull] CeylonParser.IterableTypeContext context)
        {
            var type = Get<Type>(context.unionType());
            var op = Get<Terminal>(context.SUM_OP() ?? context.PRODUCT_OP());
            Return(context, new IterableType(op, type));
        }
        public void EnterIterableType([NotNull] CeylonParser.IterableTypeContext context) => Implemented();


        public void ExitKeyOrItemPattern([NotNull] CeylonParser.KeyOrItemPatternContext context)
        {
            Lift(context);
        }
        public void EnterKeyOrItemPattern([NotNull] CeylonParser.KeyOrItemPatternContext context) => Implemented();


        public void ExitIsCondition([NotNull] CeylonParser.IsConditionContext context)
        {
            var not = context.NOT_OP() != null;
            var variable = Get<TypedVariable>(context.typedVariable());
            var value = GetOptional<ValueSpecifier>(context.valueSpecifier());
            Return(context, new IsCondition(not, variable, value));
        }
        public void EnterIsCondition([NotNull] CeylonParser.IsConditionContext context) => Implemented();


        public void ExitLazySpecification([NotNull] CeylonParser.LazySpecificationContext context)
        {
            var reference = Get<MemberReference>(context.memberReference());
            var definition = Get<LazyDefinition>(context.lazyDefinition());
            Return(context, new Specification(reference, definition));
        }
        public void EnterLazySpecification([NotNull] CeylonParser.LazySpecificationContext context) => Implemented();


        public void ExitLazySpecifier([NotNull] CeylonParser.LazySpecifierContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new LazySpecifier(expression));
        }
        public void EnterLazySpecifier([NotNull] CeylonParser.LazySpecifierContext context) => Implemented();


        public void ExitLetExpression([NotNull] CeylonParser.LetExpressionContext context)
        {
            var patterns = Get<PatternsWithValue>(context.patternList());
            var expression = GetOptional<Expression>(context.expression());
            Return(context, new LetExpression(patterns, expression));
        }
        public void EnterLetExpression([NotNull] CeylonParser.LetExpressionContext context) => Implemented();


        public void ExitListedArgument([NotNull] CeylonParser.ListedArgumentContext context)
        {
            Lift(context);
        }
        public void EnterListedArgument([NotNull] CeylonParser.ListedArgumentContext context) => Implemented();


        public void ExitLiteral([NotNull] CeylonParser.LiteralContext context)
        {
            Lift(context);
        }
        public void EnterLiteral([NotNull] CeylonParser.LiteralContext context) => Implemented();



        public void ExitMember([NotNull] CeylonParser.MemberContext context)
        {
            var op = Get<Terminal>(context.memberSelectionOperator());
            var nameWithArguments = Get<NameWithArguments>(context.nameWithArguments());
            Return(context, new MemberSelector(op, nameWithArguments));
        }
        public void EnterMember([NotNull] CeylonParser.MemberContext context) => Implemented();


        public void ExitMemberExpr([NotNull] CeylonParser.MemberExprContext context)
        {
            var expression = Get<Expression>(context.primary());
            var selector = Get<MemberSelector>(context.member());
            Return(context, new MemberExpression(expression, selector));
        }
        public void EnterMemberExpr([NotNull] CeylonParser.MemberExprContext context) => Implemented();


        public void ExitMemberMeta([NotNull] CeylonParser.MemberMetaContext context) => NotImplemented();
        public void EnterMemberMeta([NotNull] CeylonParser.MemberMetaContext context) => NotImplemented();


        public void ExitMemberName([NotNull] CeylonParser.MemberNameContext context)
        {
            Return(context, new Name(Get<Terminal>(context.LIDENTIFIER())));
        }
        public void EnterMemberName([NotNull] CeylonParser.MemberNameContext context) => Implemented();


        public void ExitMemberSelectionOperator([NotNull] CeylonParser.MemberSelectionOperatorContext context)
        {
            Lift(context);
        }
        public void EnterMemberSelectionOperator([NotNull] CeylonParser.MemberSelectionOperatorContext context) => Implemented();


        public void ExitMeta([NotNull] CeylonParser.MetaContext context)
        {
            Lift(context);
        }
        public void EnterMeta([NotNull] CeylonParser.MetaContext context) => Implemented();


        public void ExitModuleName([NotNull] CeylonParser.ModuleNameContext context)
        {
            if (context.fullName() != null)
            {
                var name = Get<DottedName>(context.fullName());
                Return(context, new ModuleName(name));
            }
            else
            {
                var literal = Get<String>(context.stringLiteral());
                Return(context, new ModuleName(literal));
            }
        }
        public void EnterModuleName([NotNull] CeylonParser.ModuleNameContext context) => Implemented();


        public void ExitModuleBody([NotNull] CeylonParser.ModuleBodyContext context)
        {
            var imports = GetMany<ModuleImport>(context.moduleImport());
            Return(context, new ModuleBody(imports));
        }
        public void EnterModuleBody([NotNull] CeylonParser.ModuleBodyContext context) => Implemented();


        public void ExitModuleDescriptor([NotNull] CeylonParser.ModuleDescriptorContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var fullName = Get<DottedName>(context.fullName());
            var specifier = GetOptional<ModuleSpecifier>(context.moduleSpecifier());
            var version = Get<ModuleVersion>(context.version());
            var body = Get<ModuleBody>(context.moduleBody());
            Return(context, new ModuleDescriptor(annotations, fullName, specifier, version, body));
        }
        public void EnterModuleDescriptor([NotNull] CeylonParser.ModuleDescriptorContext context) => Implemented();


        public void ExitModuleImport([NotNull] CeylonParser.ModuleImportContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var designator = GetOptional<ModuleDesignator>(context.moduleName()) ?? Get<ModuleDesignator>(context.moduleSpecifier());
            var version = Get<ModuleVersion>(context.version());
            Return(context, new ModuleImport(annotations, designator, version));
        }
        public void EnterModuleImport([NotNull] CeylonParser.ModuleImportContext context) => Implemented();


        public void ExitModuleSpecifier([NotNull] CeylonParser.ModuleSpecifierContext context)
        {
            var repository = Get<Repository>(context.repository());
            var name = Get<ModuleName>(context.moduleName());
            var artifact = GetOptional<ModuleArtifact>(context.artifact());
            var classifier = GetOptional<ModuleClassifier>(context.classifier());
            Return(context, new ModuleSpecifier(repository, name, artifact, classifier));
        }
        public void EnterModuleSpecifier([NotNull] CeylonParser.ModuleSpecifierContext context) => Implemented();


        public void ExitName([NotNull] CeylonParser.NameContext context)
        {
            var terminal = Get<Terminal>(context.GetChild(0));
            Return(context, new Name(terminal));
        }
        public void EnterName([NotNull] CeylonParser.NameContext context) => Implemented();


        public void ExitNamedArgument([NotNull] CeylonParser.NamedArgumentContext context)
        {
            Lift(context);
        }
        public void EnterNamedArgument([NotNull] CeylonParser.NamedArgumentContext context) => Implemented();


        public void ExitNamedArgumentList([NotNull] CeylonParser.NamedArgumentListContext context)
        {
            var arguments = new NamedArgumentList(GetMany<NamedArgument>(context.namedArgument()));
            Return(context, arguments);
        }
        public void EnterNamedArgumentList([NotNull] CeylonParser.NamedArgumentListContext context) => Implemented();


        public void ExitNamedArguments([NotNull] CeylonParser.NamedArgumentsContext context)
        {
            var named = Get<NamedArgumentList>(context.namedArgumentList());
            var positional = Get<ArgumentList>(context.argumentList());
            Return(context, new NamedArguments(named, positional));
        }
        public void EnterNamedArguments([NotNull] CeylonParser.NamedArgumentsContext context) => Implemented();


        public void ExitNonassocInfixExpr([NotNull] CeylonParser.NonassocInfixExprContext context)
        {
            var left = Get<Expression>(context.GetChild(0));
            var op = Get<Terminal>(context.GetChild(1));
            var right = Get<Expression>(context.GetChild(2));
            Return(context, new InfixExpression(op, left, right));
        }
        public void EnterNonassocInfixExpr([NotNull] CeylonParser.NonassocInfixExprContext context) => Implemented();


        public void ExitNonassocPostfixExpr([NotNull] CeylonParser.NonassocPostfixExprContext context)
        {
            var expression = Get<Expression>(context.expression());
            var op = Get<Terminal>(context.GetChild(1));
            Return(context, new PostfixExpression(op, expression));
        }
        public void EnterNonassocPostfixExpr([NotNull] CeylonParser.NonassocPostfixExprContext context) => Implemented();


        public void ExitObjectArgument([NotNull] CeylonParser.ObjectArgumentContext context)
        {
            NotImplemented();
        }
        public void EnterObjectArgument([NotNull] CeylonParser.ObjectArgumentContext context) => NotImplemented();


        public void ExitObjectDeclaration([NotNull] CeylonParser.ObjectDeclarationContext context)
        {
            var header = Get<ObjectHeader>(context.objectHeader());
            var body = Get<Definition>(context.classBlock());
            Return(context, new ObjectDeclaration(header, body));
        }
        public void EnterObjectDeclaration([NotNull] CeylonParser.ObjectDeclarationContext context) => Implemented();


        public void ExitObjectHeader([NotNull] CeylonParser.ObjectHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var memberName = Get<Name>(context.memberName());
            var inheritance = Get<ObjectInheritance>(context.objectInheritance());
            Return(context, new ObjectHeader(annotations, memberName, inheritance));
        }
        public void EnterObjectHeader([NotNull] CeylonParser.ObjectHeaderContext context) => Implemented();


        public void ExitObjectExpression([NotNull] CeylonParser.ObjectExpressionContext context)
        {
            var inheritance = Get<ObjectInheritance>(context.objectInheritance());
            var body = Get<Definition>(context.classBlock());
            Return(context, new ObjectExpression(inheritance, body));
        }
        public void EnterObjectExpression([NotNull] CeylonParser.ObjectExpressionContext context) => Implemented();


        public void ExitObjectInheritance([NotNull] CeylonParser.ObjectInheritanceContext context)
        {
            var extended = GetOptional<ExtendedType>(context.extendedType());
            var satisfied = GetOptional<SatisfiedTypes>(context.satisfiedTypes());
            Return(context, new ObjectInheritance(extended, satisfied));
        }
        public void EnterObjectInheritance([NotNull] CeylonParser.ObjectInheritanceContext context) => Implemented();

        public void ExitOptionalType([NotNull] CeylonParser.OptionalTypeContext context)
        {
            var type = Get<Type>(context.primaryType());
            Return(context, new OptionalType(type));
        }
        public void EnterOptionalType([NotNull] CeylonParser.OptionalTypeContext context) => Implemented();


        public void ExitPackageDescriptor([NotNull] CeylonParser.PackageDescriptorContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var fullName = Get<DottedName>(context.fullName());
            Return(context, new PackageDescriptor(annotations, fullName));
        }
        public void EnterPackageDescriptor([NotNull] CeylonParser.PackageDescriptorContext context) => Implemented();


        public void ExitPackageQualifier([NotNull] CeylonParser.PackageQualifierContext context)
        {
            Return(context, new PackageQualifier());
        }
        public void EnterPackageQualifier([NotNull] CeylonParser.PackageQualifierContext context) => Implemented();


        public void ExitParameterDeclaration([NotNull] CeylonParser.ParameterDeclarationContext context)
        {
            var parameter = GetOptional<Parameter>(context.valueParameter()) ??
                            GetOptional<Parameter>(context.callableParameter()) ??
                            Get<Parameter>(context.variadicParameter());
            Return(context, new ParameterDeclaration(parameter));
        }
        public void EnterParameterDeclaration([NotNull] CeylonParser.ParameterDeclarationContext context) => Implemented();


        public void ExitParameters([NotNull] CeylonParser.ParametersContext context)
        {
            var items = new List<Parameter>();
            items.AddRange(GetMany<Parameter>(context.required()));
            items.AddRange(GetMany<Parameter>(context.defaulted()));
            if (context.variadic() != null)
            {
                items.Add(Get<Parameter>(context.variadic()));
            }
            Return(context, new Parameters(items));
        }
        public void EnterParameters([NotNull] CeylonParser.ParametersContext context) => Implemented();


        public void ExitPattern([NotNull] CeylonParser.PatternContext context)
        {
            Lift(context);
        }
        public void EnterPattern([NotNull] CeylonParser.PatternContext context) => Implemented();


        public void ExitPatternCase([NotNull] CeylonParser.PatternCaseContext context)
        {
            Lift(context);
        }
        public void EnterPatternCase([NotNull] CeylonParser.PatternCaseContext context) => Implemented();


        public void ExitPatternList([NotNull] CeylonParser.PatternListContext context)
        {
            var patterns = GetMany<PatternWithValue>(context.patternWithValue());
            Return(context, new PatternsWithValue(patterns));
        }
        public void EnterPatternList([NotNull] CeylonParser.PatternListContext context) => Implemented();


        public void ExitPositionalArguments([NotNull] CeylonParser.PositionalArgumentsContext context)
        {
            Return(context, new PositionalArguments(Get<ArgumentList>(context.argumentList())));
        }
        public void EnterPositionalArguments([NotNull] CeylonParser.PositionalArgumentsContext context) => Implemented();


        public void ExitPostfixExpr([NotNull] CeylonParser.PostfixExprContext context)
        {
            var expression = Get<Expression>(context.expression());
            var op = Get<Terminal>(context.GetChild(1));
            Return(context, new PostfixExpression(op, expression));
        }
        public void EnterPostfixExpr([NotNull] CeylonParser.PostfixExprContext context) => Implemented();

        public void ExitPrefixExpr([NotNull] CeylonParser.PrefixExprContext context)
        {
            var op = Get<Terminal>(context.GetChild(0));
            var expression = Get<Expression>(context.GetChild(1));
            Return(context, new PrefixExpression(op, expression));
        }
        public void EnterPrefixExpr([NotNull] CeylonParser.PrefixExprContext context) => Implemented();


        public void ExitPrimaryExpr([NotNull] CeylonParser.PrimaryExprContext context)
        {
            Lift(context);
        }
        public void EnterPrimaryExpr([NotNull] CeylonParser.PrimaryExprContext context) => Implemented();


        public void ExitQualifiedType([NotNull] CeylonParser.QualifiedTypeContext context)
        {
            var package = GetOptional<PackageQualifier>(context.packageQualifier());
            var names = GetMany<NameWithArguments>(context.typeNameWithArguments());
            Return(context, new QualifiedType(package, names));
        }
        public void EnterQualifiedType([NotNull] CeylonParser.QualifiedTypeContext context) => Implemented();


        public void ExitRepository([NotNull] CeylonParser.RepositoryContext context)
        {
            var name = Get<Name>(context.memberName());
            Return(context, new Repository(name));
        }
        public void EnterRepository([NotNull] CeylonParser.RepositoryContext context) => Implemented();


        public void ExitRequired([NotNull] CeylonParser.RequiredContext context)
        {
            Lift(context);
        }
        public void EnterRequired([NotNull] CeylonParser.RequiredContext context) => Implemented();


        public void ExitResource([NotNull] CeylonParser.ResourceContext context)
        {
            Lift(context);
        }
        public void EnterResource([NotNull] CeylonParser.ResourceContext context) => Implemented();


        public void ExitResourceList([NotNull] CeylonParser.ResourceListContext context)
        {
            var resources = GetMany<Resource>(context.resource());
            Return(context, new Resources(resources));
        }
        public void EnterResourceList([NotNull] CeylonParser.ResourceListContext context) => Implemented();


        public void ExitReturnDirective([NotNull] CeylonParser.ReturnDirectiveContext context)
        {
            var expression = GetOptional<Expression>(context.expression());
            Return(context, new ReturnStatement(expression));
        }
        public void EnterReturnDirective([NotNull] CeylonParser.ReturnDirectiveContext context) => Implemented();


        public void ExitSatisfiedTypes([NotNull] CeylonParser.SatisfiedTypesContext context)
        {
            var items = GetMany<Type>(context.primaryType());
            Return(context, new SatisfiedTypes(items));
        }
        public void EnterSatisfiedTypes([NotNull] CeylonParser.SatisfiedTypesContext context) => Implemented();


        public void ExitSelfReference([NotNull] CeylonParser.SelfReferenceContext context)
        {
            var terminal = Get<Terminal>(context.THIS() ?? context.SUPER() ?? context.OUTER());
            Return(context, new SelfReferenceExpression(terminal));
        }
        public void EnterSelfReference([NotNull] CeylonParser.SelfReferenceContext context) => Implemented();


        public void ExitSequenceType([NotNull] CeylonParser.SequenceTypeContext context)
        {
            var type = Get<Type>(context.primaryType());
            Return(context, new SequenceType(type));
        }
        public void EnterSequenceType([NotNull] CeylonParser.SequenceTypeContext context) => Implemented();


        public void ExitSetterDeclaration([NotNull] CeylonParser.SetterDeclarationContext context)
        {
            var header = Get<SetterHeader>(context.setterHeader());
            var block = Get<Definition>(context.setterBody());
            Return(context, new SetterDeclaration(header, block));
        }
        public void EnterSetterDeclaration([NotNull] CeylonParser.SetterDeclarationContext context) => Implemented();


        public void ExitSetterHeader([NotNull] CeylonParser.SetterHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var memberName = Get<Name>(context.memberName());
            Return(context, new SetterHeader(annotations, memberName));
        }
        public void EnterSetterHeader([NotNull] CeylonParser.SetterHeaderContext context) => Implemented();


        public void ExitSpecification([NotNull] CeylonParser.SpecificationContext context)
        {
            Lift(context);
        }
        public void EnterSpecification([NotNull] CeylonParser.SpecificationContext context) => Implemented();


        public void ExitSpecifiedArgument([NotNull] CeylonParser.SpecifiedArgumentContext context)
        {
            var specification = Get<Specification>(context.specification());
            Return(context, new SpecifiedArgument(specification));
        }
        public void EnterSpecifiedArgument([NotNull] CeylonParser.SpecifiedArgumentContext context) => Implemented();


        public void ExitValueSpecifier([NotNull] CeylonParser.ValueSpecifierContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new ValueSpecifier(expression));
        }
        public void EnterValueSpecifier([NotNull] CeylonParser.ValueSpecifierContext context) => Implemented();


        public void ExitSpreadArgument([NotNull] CeylonParser.SpreadArgumentContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new SpreadArgument(expression));
        }
        public void EnterSpreadArgument([NotNull] CeylonParser.SpreadArgumentContext context) => Implemented();


        public void ExitSpreadType([NotNull] CeylonParser.SpreadTypeContext context)
        {
            var type = Get<Type>(context.unionType());
            Return(context, new SpreadType(type));
        }
        public void EnterSpreadType([NotNull] CeylonParser.SpreadTypeContext context) => Implemented();


        public void ExitStatement([NotNull] CeylonParser.StatementContext context)
        {
            Lift(context);
        }
        public void EnterStatement([NotNull] CeylonParser.StatementContext context) => Implemented();


        public void ExitStringLiteral([NotNull] CeylonParser.StringLiteralContext context)
        {
            Return(context, new String(Get<Terminal>(context.GetChild(0))));
        }
        public void EnterStringLiteral([NotNull] CeylonParser.StringLiteralContext context) => Implemented();


        public void ExitStringStart([NotNull] CeylonParser.StringStartContext context)
        {
            Return(context, new StringStart(Get<Terminal>(context.STRING_START())));
        }
        public void EnterStringStart([NotNull] CeylonParser.StringStartContext context) => Implemented();


        public void ExitStringMid([NotNull] CeylonParser.StringMidContext context)
        {
            Return(context, new StringMid(Get<Terminal>(context.STRING_MID())));
        }
        public void EnterStringMid([NotNull] CeylonParser.StringMidContext context) => Implemented();


        public void ExitStringEnd([NotNull] CeylonParser.StringEndContext context)
        {
            Return(context, new StringEnd(Get<Terminal>(context.STRING_END())));
        }
        public void EnterStringEnd([NotNull] CeylonParser.StringEndContext context) => Implemented();


        public void ExitStringTemplate([NotNull] CeylonParser.StringTemplateContext context)
        {
            var start = Get<StringStart>(context.stringStart());
            var mids = GetMany<StringMid>(context.stringMid());
            var expressions = GetMany<Expression>(context.expression());
            var end = Get<StringEnd>(context.stringEnd());
            Return(context, new StringTemplate(start, expressions, mids, end));
        }
        public void EnterStringTemplate([NotNull] CeylonParser.StringTemplateContext context) => Implemented();


        public void ExitSuperQualifier([NotNull] CeylonParser.SuperQualifierContext context)
        {
            Return(context, new SuperQualifier());
        }
        public void EnterSuperQualifier([NotNull] CeylonParser.SuperQualifierContext context) => Implemented();


        public void ExitSwitch([NotNull] CeylonParser.SwitchContext context)
        {
            var switchable = Get<Switchable>(context.switchable());
            Return(context, new Ast.Switch(switchable));
        }
        public void EnterSwitch([NotNull] CeylonParser.SwitchContext context) => Implemented();


        public void ExitSwitchCaseElse([NotNull] CeylonParser.SwitchCaseElseContext context)
        {
            var @switch = Get<Ast.Switch>(context.@switch());
            var cases = new SwitchCases(GetMany<CaseStatementCase>(context.@case()));
            var elsePart = GetOptional<ElsePart>(context.elsePart());
            Return(context, new SwitchCaseElseStatement(@switch, cases, elsePart));
        }
        public void EnterSwitchCaseElse([NotNull] CeylonParser.SwitchCaseElseContext context) => Implemented();


        public void ExitSwitchCaseElseExpression([NotNull] CeylonParser.SwitchCaseElseExpressionContext context)
        {
            var @switch = Get<Ast.Switch>(context.@switch());
            var caseParts = new CaseExpressions(GetMany<CaseExpression>(context.caseExpression()));
            var elsePart = GetOptional<ElseExpressionPart>(context.elseExpression());
            Return(context, new SwitchCaseElseExpression(@switch, caseParts, elsePart));
        }
        public void EnterSwitchCaseElseExpression([NotNull] CeylonParser.SwitchCaseElseExpressionContext context) => Implemented();


        public void ExitThenExpression([NotNull] CeylonParser.ThenExpressionContext context)
        {
            var expression = Get<Expression>(context.expression());
            Return(context, new ThenExpressionPart(expression));
        }
        public void EnterThenExpression([NotNull] CeylonParser.ThenExpressionContext context) => Implemented();


        public void ExitThrowDirective([NotNull] CeylonParser.ThrowDirectiveContext context)
        {
            var expression = GetOptional<Expression>(context.expression());
            Return(context, new ThrowStatement(expression));
        }
        public void EnterThrowDirective([NotNull] CeylonParser.ThrowDirectiveContext context) => Implemented();


        public void ExitToplevelDeclaration([NotNull] CeylonParser.ToplevelDeclarationContext context)
        {
            Lift(context);
        }
        public void EnterToplevelDeclaration([NotNull] CeylonParser.ToplevelDeclarationContext context) => Implemented();


        public void ExitTryBlock([NotNull] CeylonParser.TryBlockContext context)
        {
            var resources = GetOptional<Resources>(context.resourceList());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new TryBlock(resources, block));
        }
        public void EnterTryBlock([NotNull] CeylonParser.TryBlockContext context) => Implemented();


        public void ExitTryCatchFinally([NotNull] CeylonParser.TryCatchFinallyContext context)
        {
            var tryBlock = Get<TryBlock>(context.tryBlock());
            var catches = new CatchBlocks(GetMany<CatchBlock>(context.catchBlock()));
            var finallyBlock = GetOptional<FinallyBlock>(context.finallyBlock());
            Return(context, new TryStatement(tryBlock, catches, finallyBlock));
        }
        public void EnterTryCatchFinally([NotNull] CeylonParser.TryCatchFinallyContext context) => Implemented();


        public void ExitTuple([NotNull] CeylonParser.TupleContext context)
        {
            var arguments = Get<ArgumentList>(context.argumentList());
            Return(context, new TupleExpression(arguments));
        }
        public void EnterTuple([NotNull] CeylonParser.TupleContext context) => Implemented();


        public void ExitTuplePattern([NotNull] CeylonParser.TuplePatternContext context)
        {
            var items = GetMany<Pattern>(context.pattern());
            var variadic = GetOptional<VariadicVariable>(context.variadicVariable());
            Return(context, new TuplePattern(items, variadic));
        }

        public void EnterTuplePattern([NotNull] CeylonParser.TuplePatternContext context) => Implemented();

        public void ExitTupleType([NotNull] CeylonParser.TupleTypeContext context)
        {
            var types = Get<TypeList>(context.typeList());
            Return(context, new TupleType(types));
        }
        public void EnterTupleType([NotNull] CeylonParser.TupleTypeContext context) => Implemented();


        public void ExitType([NotNull] CeylonParser.TypeContext context)
        {
            Lift(context);
        }
        public void EnterType([NotNull] CeylonParser.TypeContext context) => Implemented();


        public void ExitTypeArgument([NotNull] CeylonParser.TypeArgumentContext context)
        {
            var variance = Get<Variance>(context.variance());
            var type = Get<Type>(context.type());
            Return(context, new TypeArgument(variance, type));
        }
        public void EnterTypeArgument([NotNull] CeylonParser.TypeArgumentContext context) => Implemented();


        public void ExitTypeArgumentList([NotNull] CeylonParser.TypeArgumentListContext context)
        {
            var arguments = GetMany<TypeArgument>(context.typeArgument());
            Return(context, new TypeArgumentList(arguments));
        }
        public void EnterTypeArgumentList([NotNull] CeylonParser.TypeArgumentListContext context) => Implemented();


        public void ExitTypeArguments([NotNull] CeylonParser.TypeArgumentsContext context)
        {
            var argumentList = Get<TypeArgumentList>(context.typeArgumentList());
            Return(context, new TypeArguments(argumentList));
        }
        public void EnterTypeArguments([NotNull] CeylonParser.TypeArgumentsContext context) => Implemented();


        public void ExitTypeCase([NotNull] CeylonParser.TypeCaseContext context)
        {
            var type = Get<Type>(context.type());
            Return(context, new TypeCase(type));
        }
        public void EnterTypeCase([NotNull] CeylonParser.TypeCaseContext context) => Implemented();


        public void EnterTypeConstraint([NotNull] CeylonParser.TypeConstraintContext context) => Implemented();

        public void ExitTypeConstraint([NotNull] CeylonParser.TypeConstraintContext context)
        {
            var typeName = Get<Name>(context.typeName());
            var parameters = GetOptional<TypeParameters>(context.typeParameters());
            var inheritance = Get<TypeConstraintInheritance>(context.typeConstraintInheritance());
            Return(context, new TypeConstraint(typeName, parameters, inheritance));
        }

        public void ExitTypeConstraintInheritance([NotNull] CeylonParser.TypeConstraintInheritanceContext context)
        {
            var caseTypes = GetOptional<CaseTypes>(context.caseTypes());
            var satisfiedTypes = GetOptional<SatisfiedTypes>(context.satisfiedTypes());
            var abstractedType = GetOptional<AbstractedType>(context.abstractedType());
            Return(context, new TypeConstraintInheritance(caseTypes, satisfiedTypes, abstractedType));
        }
        public void EnterTypeConstraintInheritance([NotNull] CeylonParser.TypeConstraintInheritanceContext context) => Implemented();


        public void ExitTypeConstraints([NotNull] CeylonParser.TypeConstraintsContext context)
        {
            var items = GetMany<TypeConstraint>(context.typeConstraint());
            Return(context, new TypeConstraints(items));
        }
        public void EnterTypeConstraints([NotNull] CeylonParser.TypeConstraintsContext context) => Implemented();


        public void ExitTypeDefault([NotNull] CeylonParser.TypeDefaultContext context)
        {
            var type = Get<Type>(context.type());
            Return(context, new TypeDefault(type));
        }
        public void EnterTypeDefault([NotNull] CeylonParser.TypeDefaultContext context) => Implemented();


        public void ExitTypedVariable([NotNull] CeylonParser.TypedVariableContext context)
        {
            var type = Get<Type>(context.type());
            var memberName = Get<Name>(context.memberName());
            Return(context, new TypedVariable(type, memberName));
        }
        public void EnterTypedVariable([NotNull] CeylonParser.TypedVariableContext context) => Implemented();


        public void ExitTypeExpr([NotNull] CeylonParser.TypeExprContext context)
        {
            var expression = Get<Expression>(context.GetChild(0));
            var op = Get<Terminal>(context.GetChild(1));
            var type = Get<Type>(context.GetChild(2));
            Return(context, new TypeExpression(op, expression, type));
        }
        public void EnterTypeExpr([NotNull] CeylonParser.TypeExprContext context) => Implemented();


        public void ExitTypeList([NotNull] CeylonParser.TypeListContext context)
        {
            var types = GetMany<Type>(context.defaultedType()).ToList();
            var variadic = GetOptional<Type>(context.variadicType());
            Return(context, new TypeList(types, variadic));
        }
        public void EnterTypeList([NotNull] CeylonParser.TypeListContext context) => Implemented();


        public void ExitTypeMeta([NotNull] CeylonParser.TypeMetaContext context)
        {
            var type = Get<Type>(context.type());
            Return(context, new TypeMeta(type));
        }
        public void EnterTypeMeta([NotNull] CeylonParser.TypeMetaContext context) => Implemented();


        public void ExitTypeName([NotNull] CeylonParser.TypeNameContext context)
        {
            Return(context, new Name(Get<Terminal>(context.UIDENTIFIER())));
        }
        public void EnterTypeName([NotNull] CeylonParser.TypeNameContext context) => Implemented();


        public void ExitTypeNameWithArguments([NotNull] CeylonParser.TypeNameWithArgumentsContext context)
        {
            var name = Get<Name>(context.typeName());
            var arguments = GetOptional<TypeArguments>(context.typeArguments());
            Return(context, new NameWithArguments(name, arguments));
        }
        public void EnterTypeNameWithArguments([NotNull] CeylonParser.TypeNameWithArgumentsContext context) => Implemented();


        public void ExitTypeParameter([NotNull] CeylonParser.TypeParameterContext context)
        {
            var variance = Get<Variance>(context.variance());
            var typeName = Get<Name>(context.typeName());
            var typeDefault = GetOptional<TypeDefault>(context.typeDefault());
            Return(context, new TypeParameter(variance, typeName, typeDefault));
        }
        public void EnterTypeParameter([NotNull] CeylonParser.TypeParameterContext context) => Implemented();


        public void ExitTypeParameters([NotNull] CeylonParser.TypeParametersContext context)
        {
            var parameters = GetMany<TypeParameter>(context.typeParameter());
            Return(context, new TypeParameters(parameters));
        }
        public void EnterTypeParameters([NotNull] CeylonParser.TypeParametersContext context) => Implemented();


        public void ExitTypeSpecifier([NotNull] CeylonParser.TypeSpecifierContext context)
        {
            var type = Get<Type>(context.type());
            Return(context, new TypeSpecifier(type));
        }
        public void EnterTypeSpecifier([NotNull] CeylonParser.TypeSpecifierContext context) => Implemented();


        public void ExitIntersectionType([NotNull] CeylonParser.IntersectionTypeContext context)
        {
            var primaries = GetMany<Type>(context.primaryType()).ToList();
            if (primaries.Count == 1)
            {
                Return(context, primaries[0]);
            }
            else
            {
                Return(context, new IntersectionType(primaries));
            }
        }
        public void EnterIntersectionType([NotNull] CeylonParser.IntersectionTypeContext context) => Implemented();


        public void ExitUnionType([NotNull] CeylonParser.UnionTypeContext context)
        {
            var intersections = GetMany<Type>(context.intersectionType()).ToList();
            if (intersections.Count == 1)
            {
                Return(context, intersections[0]);
            }
            else
            {
                Return(context, new UnionType(intersections));
            }
        }
        public void EnterUnionType([NotNull] CeylonParser.UnionTypeContext context) => Implemented();


        public void ExitValueArgument([NotNull] CeylonParser.ValueArgumentContext context)
        {
            var header = Get<ValueHeader>(context.valueHeader());
            var body = Get<Definition>(context.valueArgumentBody());
            Return(context, new ValueArgument(header, body));
        }
        public void EnterValueArgument([NotNull] CeylonParser.ValueArgumentContext context) => Implemented();


        public void ExitValueCase([NotNull] CeylonParser.ValueCaseContext context)
        {
            var expressions = GetMany<Expression>(context.constantExpression());
            Return(context, new ValueCase(expressions));
        }
        public void EnterValueCase([NotNull] CeylonParser.ValueCaseContext context) => Implemented();


        public void ExitValueConstructorHeader([NotNull] CeylonParser.ValueConstructorHeaderContext context)
        {
            var memberName = Get<Name>(context.memberName());
            var extendedType = GetOptional<ExtendedType>(context.extendedType());
            Return(context, new ValueConstructorHeader(memberName, extendedType));
        }
        public void EnterValueConstructorHeader([NotNull] CeylonParser.ValueConstructorHeaderContext context) => Implemented();


        public void ExitValueDeclaration([NotNull] CeylonParser.ValueDeclarationContext context)
        {
            var header = Get<ValueHeader>(context.valueHeader());
            var body = Get<Definition>(context.valueBody());
            Return(context, new ValueDeclaration(header, body));
        }
        public void EnterValueDeclaration([NotNull] CeylonParser.ValueDeclarationContext context) => Implemented();


        public void ExitValueHeader([NotNull] CeylonParser.ValueHeaderContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var prefix = Get<Type>(context.valuePrefix());
            var name = Get<Name>(context.memberName());
            Return(context, new ValueHeader(annotations, prefix, name));
        }
        public void EnterValueHeader([NotNull] CeylonParser.ValueHeaderContext context) => Implemented();


        public void ExitValueParameter([NotNull] CeylonParser.ValueParameterContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var prefix = Get<Type>(context.valueParameterPrefix());
            var name = Get<Name>(context.memberName());
            Return(context, new ValueParameter(annotations, prefix, name));
        }
        public void EnterValueParameter([NotNull] CeylonParser.ValueParameterContext context) => Implemented();


        public void ExitValueParameterPrefix([NotNull] CeylonParser.ValueParameterPrefixContext context)
        {
            if (context.type() != null)
            {
                Lift(context);
            }
            else
            {
                var terminal = Get<Terminal>(context.GetChild(0));
                Return(context, new PrefixType(terminal));
            }
        }
        public void EnterValueParameterPrefix([NotNull] CeylonParser.ValueParameterPrefixContext context) => Implemented();


        public void ExitValuePrefix([NotNull] CeylonParser.ValuePrefixContext context)
        {
            if (context.type() != null)
            {
                Lift(context);
            }
            else
            {
                var terminal = Get<Terminal>(context.GetChild(0));
                Return(context, new PrefixType(terminal));
            }
        }
        public void EnterValuePrefix([NotNull] CeylonParser.ValuePrefixContext context) => Implemented();


        public void ExitValueSpecification([NotNull] CeylonParser.ValueSpecificationContext context)
        {
            NotImplemented();
        }
        public void EnterValueSpecification([NotNull] CeylonParser.ValueSpecificationContext context) => NotImplemented();


        public void ExitVariable([NotNull] CeylonParser.VariableContext context)
        {
            var type = GetOptional<Type>(context.type());
            if (type == null)
            {
                var prefix = GetOptional<Terminal>(context.VALUE());
                if (prefix != null)
                {
                    type = new PrefixType(prefix);
                }
            }
            var name = Get<Name>(context.memberName());
            Return(context, new Variable(type, name));
        }
        public void EnterVariable([NotNull] CeylonParser.VariableContext context) => Implemented();


        public void ExitVariadic([NotNull] CeylonParser.VariadicContext context)
        {
            Lift(context);
        }
        public void EnterVariadic([NotNull] CeylonParser.VariadicContext context) => Implemented();


        public void ExitVariadicParameter([NotNull] CeylonParser.VariadicParameterContext context)
        {
            var annotations = Get<Annotations>(context.annotations());
            var type = Get<VariadicType>(context.variadicType());
            var name = Get<Name>(context.memberName());
            Return(context, new VariadicParameter(annotations, type, name));
        }
        public void EnterVariadicParameter([NotNull] CeylonParser.VariadicParameterContext context) => Implemented();


        public void ExitVariadicType([NotNull] CeylonParser.VariadicTypeContext context)
        {
            var type = Get<Type>(context.unionType());
            var terminal = Get<Terminal>(context.SUM_OP() ?? context.PRODUCT_OP());

            var item = new VariadicType(type, terminal);
            Return(context, item);
        }
        public void EnterVariadicType([NotNull] CeylonParser.VariadicTypeContext context) => Implemented();


        public void ExitVariadicVariable([NotNull] CeylonParser.VariadicVariableContext context)
        {
            var type = GetOptional<Type>(context.unionType());
            var memberName = Get<Name>(context.memberName());
            Return(context, new VariadicVariable(type, memberName));
        }
        public void EnterVariadicVariable([NotNull] CeylonParser.VariadicVariableContext context) => Implemented();


        public void ExitVariance([NotNull] CeylonParser.VarianceContext context)
        {
            var kind = VarianceKind.Invariant;
            if (context.IN() != null)
            {
                kind = VarianceKind.Contravariant;
            }
            else if (context.OUT() != null)
            {
                kind = VarianceKind.Covariant;
            }
            Return(context, new Variance(kind));
        }
        public void EnterVariance([NotNull] CeylonParser.VarianceContext context) => Implemented();


        public void ExitVersion([NotNull] CeylonParser.VersionContext context)
        {
            var version = Get<String>(context.stringLiteral());
            Return(context, new ModuleVersion(version));
        }
        public void EnterVersion([NotNull] CeylonParser.VersionContext context) => Implemented();


        public void ExitWhile([NotNull] CeylonParser.WhileContext context)
        {
            var conditions = Get<Conditions>(context.conditionList());
            var block = Get<BlockDefinition>(context.blockDefinition());
            Return(context, new WhileStatement(conditions, block));
        }
        public void EnterWhile([NotNull] CeylonParser.WhileContext context) => Implemented();


        public void ExitDeclarationReference([NotNull] CeylonParser.DeclarationReferenceContext context)
        {
            var keyword = Get<ReferenceKeyword>(context.referenceKeyword());
            var name = GetOptional<ReferenceName>(context.referenceName());
            Return(context, new DeclarationReference(keyword, name));
        }
        public void EnterDeclarationReference([NotNull] CeylonParser.DeclarationReferenceContext context) => Implemented();


        public void ExitReferenceKeyword([NotNull] CeylonParser.ReferenceKeywordContext context)
        {
            var keyword = Get<Terminal>(context.GetChild(0));
            Return(context, new ReferenceKeyword(keyword));
        }
        public void EnterReferenceKeyword([NotNull] CeylonParser.ReferenceKeywordContext context) => Implemented();


        public void ExitReferenceName([NotNull] CeylonParser.ReferenceNameContext context)
        {
            var qualifier = GetOptional<PackageQualifier>(context.packageQualifier());
            var name = Get<DottedName>(context.fullName());
            Return(context, new ReferenceName(qualifier, name));
        }
        public void EnterReferenceName([NotNull] CeylonParser.ReferenceNameContext context) => Implemented();


        public void ExitMetaExpression([NotNull] CeylonParser.MetaExpressionContext context)
        {
            Lift(context);
        }
        public void EnterMetaExpression([NotNull] CeylonParser.MetaExpressionContext context) => Implemented();


        public void EnterInterfaceMember([NotNull] CeylonParser.InterfaceMemberContext context) => Implemented();

        public void ExitInterfaceMember([NotNull] CeylonParser.InterfaceMemberContext context)
        {
            Lift(context);
        }

        public void ExitClassMember([NotNull] CeylonParser.ClassMemberContext context)
        {
            Lift(context);
        }
        public void EnterClassMember([NotNull] CeylonParser.ClassMemberContext context) => Implemented();


        public void ExitBlockMember([NotNull] CeylonParser.BlockMemberContext context)
        {
            Lift(context);
        }
        public void EnterBlockMember([NotNull] CeylonParser.BlockMemberContext context) => Implemented();


        public void ExitImports([NotNull] CeylonParser.ImportsContext context)
        {
            var items = GetMany<ImportDeclaration>(context.importDeclaration());
            Return(context, new Imports(items));
        }
        public void EnterImports([NotNull] CeylonParser.ImportsContext context) => Implemented();


        public void ExitOfCaseItem([NotNull] CeylonParser.OfCaseItemContext context)
        {
            Lift(context);
        }
        public void EnterOfCaseItem([NotNull] CeylonParser.OfCaseItemContext context) => Implemented();


        public void ExitNameWithArguments([NotNull] CeylonParser.NameWithArgumentsContext context)
        {
            var name = Get<Name>(context.name());
            var arguments = GetOptional<TypeArguments>(context.typeArguments());
            Return(context, new NameWithArguments(name, arguments));
        }
        public void EnterNameWithArguments([NotNull] CeylonParser.NameWithArgumentsContext context) => Implemented();


        public void ExitValueBody([NotNull] CeylonParser.ValueBodyContext context)
        {
            Lift(context);
        }
        public void EnterValueBody([NotNull] CeylonParser.ValueBodyContext context) => Implemented();


        public void ExitThisQualifier([NotNull] CeylonParser.ThisQualifierContext context)
        {
            Return(context, new ThisQualifier());
        }
        public void EnterThisQualifier([NotNull] CeylonParser.ThisQualifierContext context) => Implemented();


        public void ExitMemberReference([NotNull] CeylonParser.MemberReferenceContext context)
        {
            var qualifier = GetOptional<ThisQualifier>(context.thisQualifier());
            var memberName = Get<Name>(context.memberName());
            var parameters = new ParametersList(GetMany<Parameters>(context.parameters()));
            Return(context, new MemberReference(qualifier, memberName, parameters));
        }
        public void EnterMemberReference([NotNull] CeylonParser.MemberReferenceContext context) => Implemented();


        public void ExitExistsCondition([NotNull] CeylonParser.ExistsConditionContext context)
        {
            var not = context.NOT_OP() != null;
            ConditionTestee testee;
            if (context.memberName() != null)
            {
                testee = new NameTestee(Get<Name>(context.memberName()));
            }
            else
            {
                testee = new PatternTestee(Get<PatternWithValue>(context.patternWithValue()));
            }
            Return(context, new ExistsCondition(not, testee));
        }
        public void EnterExistsCondition([NotNull] CeylonParser.ExistsConditionContext context) => Implemented();


        public void ExitNonemptyCondition([NotNull] CeylonParser.NonemptyConditionContext context)
        {
            var not = context.NOT_OP() != null;
            ConditionTestee testee;
            if (context.memberName() != null)
            {
                testee = new NameTestee(Get<Name>(context.memberName()));
            }
            else
            {
                testee = new PatternTestee(Get<PatternWithValue>(context.patternWithValue()));
            }
            Return(context, new NonemptyCondition(not, testee));
        }
        public void EnterNonemptyCondition([NotNull] CeylonParser.NonemptyConditionContext context) => Implemented();


        public void ExitPatternWithValue([NotNull] CeylonParser.PatternWithValueContext context)
        {
            var pattern = Get<Pattern>(context.pattern());
            var value = Get<ValueSpecifier>(context.valueSpecifier());
            Return(context, new PatternWithValue(pattern, value));
        }
        public void EnterPatternWithValue([NotNull] CeylonParser.PatternWithValueContext context) => Implemented();


        public void ExitUpToRange([NotNull] CeylonParser.UpToRangeContext context)
        {
            var two = Get<Expression>(context.expression());
            Return(context, new IndexRange(IndexRangeKind.FromUp, null, two));
        }
        public void EnterUpToRange([NotNull] CeylonParser.UpToRangeContext context) => Implemented();


        public void ExitFromUpRange([NotNull] CeylonParser.FromUpRangeContext context)
        {
            var one = Get<Expression>(context.expression());
            Return(context, new IndexRange(IndexRangeKind.FromUp, one, null));
        }
        public void EnterFromUpRange([NotNull] CeylonParser.FromUpRangeContext context) => Implemented();


        public void ExitFromToRange([NotNull] CeylonParser.FromToRangeContext context)
        {
            var one = Get<Expression>(context.expression()[0]);
            var two = Get<Expression>(context.expression()[1]);
            Return(context, new IndexRange(IndexRangeKind.FromTo, one, two));
        }
        public void EnterFromToRange([NotNull] CeylonParser.FromToRangeContext context) => Implemented();


        public void ExitFromLengthRange([NotNull] CeylonParser.FromLengthRangeContext context)
        {
            var one = Get<Expression>(context.expression()[0]);
            var two = Get<Expression>(context.expression()[1]);
            Return(context, new IndexRange(IndexRangeKind.FromLength, one, two));
        }
        public void EnterFromLengthRange([NotNull] CeylonParser.FromLengthRangeContext context) => Implemented();


        public void ExitSingleIndex([NotNull] CeylonParser.SingleIndexContext context)
        {
            var one = Get<Expression>(context.expression());
            var two = one;
            Return(context, new IndexRange(IndexRangeKind.Index, one, two));
        }
        public void EnterSingleIndex([NotNull] CeylonParser.SingleIndexContext context) => Implemented();


        public void ExitVariableWithValue([NotNull] CeylonParser.VariableWithValueContext context)
        {
            var variable = Get<Variable>(context.variable());
            var value = Get<ValueSpecifier>(context.valueSpecifier());
            Return(context, new VariableWithValue(variable, value));
        }
        public void EnterVariableWithValue([NotNull] CeylonParser.VariableWithValueContext context) => Implemented();


        public void ExitSwitchable([NotNull] CeylonParser.SwitchableContext context)
        {
            Lift(context);
        }
        public void EnterSwitchable([NotNull] CeylonParser.SwitchableContext context) => Implemented();

        
        public void EnterModuleDesignator([NotNull] CeylonParser.ModuleDesignatorContext context)
        {
            Lift(context);
        }
        public void ExitModuleDesignator([NotNull] CeylonParser.ModuleDesignatorContext context) => Implemented();


        public void ExitExtensionQualifier([NotNull] CeylonParser.ExtensionQualifierContext context)
        {
            Lift(context);
        }
        public void EnterExtensionQualifier([NotNull] CeylonParser.ExtensionQualifierContext context) => Implemented();


        public void ExitEof([NotNull] CeylonParser.EofContext context)
        {
            var terminal = Get<Terminal>(context.Eof());

            Return(context, new Eof(terminal));
        }
        public void EnterEof([NotNull] CeylonParser.EofContext context) => Implemented();


        public void ExitSetterBody([NotNull] CeylonParser.SetterBodyContext context)
        {
            Lift(context);
        }
        public void EnterSetterBody([NotNull] CeylonParser.SetterBodyContext context) => Implemented();


        public void ExitLazyDefinition([NotNull] CeylonParser.LazyDefinitionContext context)
        {
            var specifier = Get<LazySpecifier>(context.lazySpecifier());
            Return(context, new LazyDefinition(specifier));
        }
        public void EnterLazyDefinition([NotNull] CeylonParser.LazyDefinitionContext context) => Implemented();


        public void ExitValueDefinition([NotNull] CeylonParser.ValueDefinitionContext context)
        {
            var specifier = Get<ValueSpecifier>(context.valueSpecifier());
            Return(context, new ValueDefinition(specifier));
        }
        public void EnterValueDefinition([NotNull] CeylonParser.ValueDefinitionContext context) => Implemented();


        public void ExitEmptyDefinition([NotNull] CeylonParser.EmptyDefinitionContext context)
        {
            Return(context, new EmptyDefinition());
        }
        public void EnterEmptyDefinition([NotNull] CeylonParser.EmptyDefinitionContext context) => Implemented();


        public void ExitTypeDefinition([NotNull] CeylonParser.TypeDefinitionContext context)
        {
            var specifier = Get<TypeSpecifier>(context.typeSpecifier());
            Return(context, new TypeDefinition(specifier));
        }
        public void EnterTypeDefinition([NotNull] CeylonParser.TypeDefinitionContext context) => Implemented();


        public void ExitValueArgumentBody([NotNull] CeylonParser.ValueArgumentBodyContext context)
        {
            Lift(context);
        }
        public void EnterValueArgumentBody([NotNull] CeylonParser.ValueArgumentBodyContext context) => Implemented();


        public void ExitClassBody([NotNull] CeylonParser.ClassBodyContext context)
        {
            Lift(context);
        }
        public void EnterClassBody([NotNull] CeylonParser.ClassBodyContext context) => Implemented();


        public void ExitClassDefinition([NotNull] CeylonParser.ClassDefinitionContext context)
        {
            var specifier = Get<ClassSpecifier>(context.classSpecifier());
            Return(context, new ClassDefinition(specifier));
        }
        public void EnterClassDefinition([NotNull] CeylonParser.ClassDefinitionContext context) => Implemented();


        public void ExitLiftType([NotNull] CeylonParser.LiftTypeContext context)
        {
            Lift(context);
        }
        public void EnterLiftType([NotNull] CeylonParser.LiftTypeContext context) => Implemented();
    }
}
