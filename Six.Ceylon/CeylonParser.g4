parser grammar CeylonParser;

options { tokenVocab=CeylonLexer; }

/*=============================================================================
  2.4 Literals
=============================================================================*/

/* 2.4.1 Numeric literals */
integerLiteral
    : DECIMAL_LITERAL
    | HEX_LITERAL
    | BIN_LITERAL
    ;

floatLiteral
    : NORMAL_FLOAT_LITERAL
    | SHORT_FLOAT_LITERAL
    ;

/* 2.4.2 Character literals */
characterLiteral
    : CHAR_LITERAL
    ;

/* 2.4.3. String literals */
stringLiteral
    : STRING_LITERAL
    | VERBATIM_STRING
    ;

stringStart
    : STRING_START
    ;

stringMid
    : STRING_MID
    ;

stringEnd
    : STRING_END
    ;

/*=============================================================================
  2.5 Operators and delimiters
=============================================================================*/

/*=============================================================================
  3 Type System
=============================================================================*/

/*=============================================================================
  3.1 Identifier naming
=============================================================================*/
typeName
    : UIDENTIFIER
    ;

memberName
    : LIDENTIFIER
    ;

name
    : LIDENTIFIER | UIDENTIFIER
    ;

/*=============================================================================
  3.2 Types
=============================================================================*/

/* 3.2.3 Union types */
unionType
    : intersectionType ('|' intersectionType)*
    ;

/* 3.2.3 Intersection types */
intersectionType
    : primaryType ('&' primaryType)*
    ;

/* 3.2.7 Type expressions */
type
    : unionType
    | entryType     
    ;

typeNameWithArguments
    : typeName typeArguments?
    ;

qualifiedType
    : packageQualifier? typeNameWithArguments ('.' typeNameWithArguments)*
    ;

groupedType
    : '<' type '>'
    ;

emptyType
    : '[' ']'
    ;

tupleType
    : '[' typeList ']'
    ;

iterableType
    : '{' unionType ('*' | '+') '}'
    ;

/* 3.2.8 Type abbreviations */
primaryType
    : qualifiedType                                 # LiftType
    | groupedType                                   # LiftType
    | emptyType                                     # LiftType
    | tupleType                                     # LiftType
    | iterableType                                  # LiftType
    | primaryType '?'                               # OptionalType
    | primaryType '[' ']'                           # SequenceType
    | primaryType '[' integerLiteral ']'            # CountedTupleType
    | primaryType '(' (typeList? | spreadType) ')'  # CallableType
    ;

typeList
    : (defaultedType ',')*? (defaultedType | variadicType)
    ;

defaultedType
    : type '='?
    ;

variadicType
    : unionType ('*' | '+')
    ;

spreadType
    : '*' unionType
    ;

entryType
    : key=unionType '->' item=unionType
    ;

/*=============================================================================
  3.3 Inheritance
=============================================================================*/

/* 3.3.2 Extension */
extendedType
    : 'extends' extension
    ;

extension
    : extensionQualifier? nameWithArguments ('.' nameWithArguments)* positionalArguments?
    ;

extensionQualifier
    : packageQualifier
    | superQualifier
    ;

packageQualifier
    : 'package' '.'
    ;

superQualifier
    : 'super' '.'
    ;

thisQualifier
    : 'this' '.'
    ;

/* 3.3.3 Satisfaction */
satisfiedTypes
    : 'satisfies' primaryType ('&' primaryType)*
    ;


/* 3.3.x Abstraction (lower bound) */
abstractedType
    : 'abstracts' primaryType
    ;

/*=============================================================================
  3.4 Case enumeration and coverage
=============================================================================*/

/* 3.4.2 Cases */
caseTypes
    : 'of' ofCaseItem ('|' ofCaseItem)*
    ;

ofCaseItem
    : caseValue
    | caseType
    ;

caseType
    : primaryType
    ;

caseValue
    : packageQualifier? memberName
    ;

/*=============================================================================
  3.5 Generic type parameters
=============================================================================*/

typeParameters
    : '<' typeParameter (',' typeParameter)* '>'
    ;

/* 3.5.1 Type parameters and variance */
typeParameter
    : variance typeName typeDefault?
    ;

variance
    : ('in' | 'out')?
    ;
    
/* 3.5.3 Generic type constraints */
typeConstraints
    : typeConstraint+
    ;

typeConstraint
    : 'given' typeName typeParameters? typeConstraintInheritance
    ;

typeConstraintInheritance
    : caseTypes? satisfiedTypes? abstractedType?
    ;

/*=============================================================================
  3.6 Generic type arguments
=============================================================================*/

typeArguments
    : '<' typeArgumentList '>'
    ;

typeArgumentList
    : (typeArgument (',' typeArgument)*)?
    ;

typeArgument
    : variance type
    ;

/*=============================================================================
  3.7. Principal instantiations and polymorphism
=============================================================================*/

/*=============================================================================
  Chapter 4. Declarations
=============================================================================*/

/*=============================================================================
  4.1. Compilation unit structure
=============================================================================*/

compilationUnit
    : toplevelDeclaration* eof
    ;

eof : EOF;

/* 4.1.1. Toplevel and nested declarations */
toplevelDeclaration
    : importDeclaration
    | moduleDescriptor
    | packageDescriptor
    | declaration
    ;

declaration
    : functionDeclaration
    | valueDeclaration
    | setterDeclaration
    | classDeclaration
    | interfaceDeclaration
    | objectDeclaration
    | typeAliasDeclaration
    | parameterDeclaration
    ;

/* 4.1.2. Packages */
fullName
    : name ('.' name)*
    ;

/*=============================================================================
  4.2. Imports
=============================================================================*/

imports
    : importDeclaration*
    ;
    
importDeclaration
    : 'import' fullName importElements
    ;

importElements
    : '{' importElementList (',' importWildcard)? '}'
    | '{' importWildcard '}'
    ;

importElementList
    : importElement (',' importElement)*
    ;

importElement
    : importAlias? name importElements?
    ;

importAlias
    : name '='
    ;

importWildcard
    : '...'
    ;

/*=============================================================================
  4.3. Parameters
=============================================================================*/

parameterDeclaration
    : valueParameter ';'
    | callableParameter ';'
    | variadicParameter ';'
    ;

/* 4.3.1. Parameter lists */
parameters
    : '(' ((required ',')*? (required | (defaulted ',')*? (defaulted | variadic)))? ')'
    ;

/* 4.3.2. Required parameters */
required
    : valueParameter
    | callableParameter
    | pattern
    | memberName
    ;
    
/* 4.3.3. Defaulted parameters */
defaulted
    : valueParameter valueSpecifier
    | callableParameter lazySpecifier
    | memberName valueSpecifier
    ;

valueSpecifier
    : '=' expression
    ;

lazySpecifier
    : '=>' expression
    ;

/* 4.3.4. Value parameters */
valueParameter
    : annotations valueParameterPrefix memberName
    ;

valueParameterPrefix
    : type | 'value' | 'dynamic'
    ;

/* 4.3.5. callable parameters */
callableParameter
    : annotations callableParameterPrefix memberName parameters+
    ;

callableParameterPrefix
    : type | 'void' | 'dynamic'
    ;

/* 4.3.6. Variadic parameters */
variadicParameter
    : annotations variadicType memberName
    ;

variadic
    : variadicParameter
    | memberName
    ;

/*=============================================================================
  4.4. Interfaces
=============================================================================*/

interfaceDeclaration
    : interfaceHeader (interfaceBody | typeDefinition)
    ;

interfaceHeader
    : annotations interfacePrefix typeName typeParameters? interfaceInheritance typeConstraints?
    ;

interfacePrefix
    : 'interface'
    | 'dynamic'
    ;

interfaceInheritance
    : caseTypes? satisfiedTypes?
    ;

interfaceBody
    : '{' imports interfaceMember* '}'
    ;

interfaceMember
    : declaration
    | specification
    ;


/*=============================================================================
  4.5. Classes
=============================================================================*/

classDeclaration
    : classHeader classBody
    ;

classHeader
    : annotations 'class' typeName typeParameters? parameters? classInheritance typeConstraints?
    ;

classInheritance
    : caseTypes? extendedType? satisfiedTypes?
    ;

classBody
    : classBlock
    | classDefinition
    | emptyDefinition
    ;

classDefinition
    : classSpecifier ';'
    ;

classBlock
    : '{' imports classMember* '}'
    ;

classMember
    : declaration
    | statement
    | constructorDeclaration
    ;

/* 4.5.7. Anonymous classes */
objectDeclaration
    : objectHeader classBlock
    ;

objectHeader
    : annotations 'object' memberName objectInheritance
    ;

objectInheritance
    : extendedType? satisfiedTypes?
    ;

/* 4.5.9. Class aliases */
classSpecifier
    : '=>' extension
    ;

/*=============================================================================
  4.6. Type aliases
=============================================================================*/

typeAliasDeclaration
    : aliasHeader typeDefinition
    ;

aliasHeader
    : annotations 'alias' typeName typeParameters? typeConstraints?
    ;

/*=============================================================================
  4.7. Functions
=============================================================================*/

functionDeclaration
    : functionHeader functionBody
    ;

functionHeader
    : annotations functionPrefix memberName typeParameters? parameters+ typeConstraints?
    ;

functionPrefix
    : type | 'function' | 'void' | 'dynamic'
    ;

functionBody
    : blockDefinition
    | lazyDefinition
    | emptyDefinition
    ;

/*=============================================================================
  4.8. Values
=============================================================================*/

valueDeclaration
    : valueHeader valueBody
    ;

valueHeader
    : annotations valuePrefix memberName
    ;

valuePrefix
    : type | 'value' | 'dynamic'
    ;

valueBody
    : blockDefinition
    | valueDefinition
    | lazyDefinition
    | emptyDefinition
    ;

/* 4.8.3. Setters */
setterDeclaration
    : setterHeader setterBody
    ;

setterHeader
    : annotations 'assign' memberName 
    ;

setterBody
    : blockDefinition
    | lazyDefinition
    ;

lazyDefinition
    : lazySpecifier ';'
    ;

valueDefinition
    : valueSpecifier ';'
    ;

emptyDefinition
    : ';'
    ;

typeDefinition
    : typeSpecifier ';'
    ;

typeSpecifier
    : '=>' type
    ;

typeDefault
    : '=' type
    ;

/*=============================================================================
  4.9. Constructors
=============================================================================*/

constructorDeclaration
    : annotations constructorHeader blockDefinition
    ;

constructorHeader
    : valueConstructorHeader
    | callableConstructorHeader
    ;

valueConstructorHeader
    : 'new' memberName extendedType?
    ;

callableConstructorHeader
    : 'new' memberName? parameters extendedType?
    ;

/*=============================================================================
  Chapter 5. Statements, blocks, and control structures
=============================================================================*/

/*=============================================================================
  5.1. Block structure and references
=============================================================================*/

/*=============================================================================
  5.2. Patterns and variables
=============================================================================*/

/* 5.2.1. Variables */
typedVariable
    : type memberName
    ;

variable
    : (type | 'value')? memberName
    ;

/* 5.2.2. Patterns */
pattern
    : variable
    | tuplePattern
    | entryPattern
    ;

/* 5.2.3. Pattern variables */
variadicVariable
    : unionType? '*' memberName
    ;


/* 5.2.4. Tuple patterns */
tuplePattern
    : '[' (pattern ',')*? (pattern | variadicVariable) ']'
    ;

/* 5.2.5. Entry patterns */
entryPattern
    : key=keyOrItemPattern '->' item=keyOrItemPattern
    ;

keyOrItemPattern
    : variable
    | tuplePattern
    ;

/*=============================================================================
  5.3. Blocks and statements
=============================================================================*/

blockDefinition
    : '{' imports blockMember* '}'
    ;

blockMember
    : declaration
    | statement
    ;

statement
    : expressionStatement
    | specification
    | destructure
    | directive
    | controlStructure
    | dynamicBlock
    ;

/* 5.3.1. Expression statements */
expressionStatement /*TODO:restrictions*/
    : expression ';'
    ;

/* 5.3.2. Control directives */
directive
    : returnDirective
    | throwDirective
    | breakDirective
    | continueDirective
    ;

returnDirective
    : 'return' expression? ';'
    ;

throwDirective
    : 'throw' expression? ';'
    ;

breakDirective
    : 'break' ';'
    ;

continueDirective
    : 'continue' ';'
    ;

/* 5.3.3 Specification statements */
specification
    : valueSpecification
    | lazySpecification
    ;

memberReference
    : thisQualifier? memberName parameters*
    ;

lazySpecification
    : memberReference lazyDefinition
    ;

valueSpecification
    : thisQualifier? memberName valueDefinition
    ;

/* 5.3.4 Destructuring statements */
destructure
    : 'value' (tuplePattern | entryPattern) valueDefinition
    ;

/* 5.3.5 Dynamic block */
dynamicBlock
    : 'dynamic' blockDefinition
    ;

/*=============================================================================
  5.4 Conditions
=============================================================================*/

conditionList
    : '(' condition (',' condition)* ')'
    ;

condition
    : booleanCondition
    | isCondition
    | existsCondition
    | nonemptyCondition
    ;

/* 5.4.1 Boolean conditions */
booleanCondition
    : expression
    ;

/* 5.4.2 Assignability conditions */
isCondition
    : '!'? 'is' typedVariable valueSpecifier?
    ;

/* 5.4.3 Existence and nonemptiness conditions */
existsCondition
    : '!'? 'exists' (patternWithValue | memberName)
    ;

nonemptyCondition
    : '!'? 'nonempty' (patternWithValue | memberName)
    ;

/* 5.4.4 case conditions */
caseCondition
    : '(' (valueCase | typeCase | patternCase) ')'
    ;

valueCase
    : constantExpression ('|' constantExpression)*
    ;

typeCase
    : 'is' type
    ;

patternCase
    : tuplePattern
    | entryPattern
    ;

constantExpression
    : expression
    ;

/*=============================================================================
  5.5. Control structures and assertions
=============================================================================*/

controlStructure
    : ifElse
    | switchCaseElse
    | while
    | forFail
    | tryCatchFinally
    | assertion
    ;

/* 5.5.1 if/else */
ifElse
    : ifPart elsePart?
    ;

ifPart
    : 'if' conditionList blockDefinition
    ;

elsePart:
    'else' (blockDefinition | ifElse)
    ;

/* 5.5.2 switch/case/else */
switchCaseElse
    : switch case+ elsePart?
    ;

switch
    : 'switch' '(' switchable ')'
    ;

switchable
    : expression
    | variableWithValue
    ;

variableWithValue
    : variable valueSpecifier
    ;

case
    : 'else'? 'case' caseCondition blockDefinition
    ;

/* 5.5.3 for/else */
forFail
    : 'for' forIterator blockDefinition fallback?
    ;

fallback
    : 'else' blockDefinition
    ;

forIterator
    : '(' pattern 'in' expression ')'
    ;
    
/* 5.5.4 while */
while
    : 'while' conditionList blockDefinition
    ;

/* 5.5.5 try/catch/finally */
tryCatchFinally
    : tryBlock catchBlock* finallyBlock?
    ;

tryBlock
    : 'try' resourceList? blockDefinition
    ;

resourceList
    : '(' resource (',' resource)* ')'
    ;

catchBlock
    : 'catch' '(' variable ')' blockDefinition
    ;

finallyBlock
    : 'finally' blockDefinition
    ;

resource
    : expression
    | variableWithValue
    ;

/* 5.5.6. assertions */
assertion
    : assertionMessage? 'assert' conditionList ';'
    ;

assertionMessage
    : stringLiteral
    | stringTemplate
    ;

/*=============================================================================
  Chapter 6. Expressions
=============================================================================*/

/*=============================================================================
  6.1. Literal values
=============================================================================*/

literal
    : integerLiteral
    | floatLiteral
    | characterLiteral
    | stringLiteral
    ;

/*=============================================================================
  6.2. String templates
=============================================================================*/

stringTemplate
    : stringStart expression (stringMid expression)* stringEnd
    ;

/*=============================================================================
  6.3. Self references
=============================================================================*/

selfReference
    : 'this'
    | 'super'
    | 'outer'
    ;
    
/*=============================================================================
  6.4. Anonymous functions
=============================================================================*/

functionExpression
    : ('function' | 'void')? parameters+ (blockDefinition | lazySpecifier)
    ;

/*=============================================================================
  6.5. Compound expressions
=============================================================================*/

atom
    : literal
    | stringTemplate
    | baseExpression
    | selfReference
    | groupedExpression
    | enumeration
    | objectExpression
    | functionExpression
    | letExpression
    | conditionalExpression
    | metaExpression
    ;

metaExpression
    : meta
    | declarationReference
    ;

primary
    : atom              # AtomExpr
    | primary member    # MemberExpr
    | primary arguments # InvokeExpr
    | primary indexed   # IndexExpr
    ;

groupedExpression
    : '(' expression ')'
    ;

nameWithArguments
    : name typeArguments?
    ;

/* 6.5.1. Base expressions */
baseExpression
    : packageQualifier? nameWithArguments
    ;

/* 6.5.2. Member expressions */

member
    : memberSelectionOperator nameWithArguments
    ;

/* 6.5.3. Constructor expressions */

/* 6.5.6. Static expressions */

/*=============================================================================
  6.6. Invocation expressions
=============================================================================*/

invocation
    : primary arguments
    ;

arguments
    : positionalArguments
    | namedArguments
    ;
    
/* 6.6.3. The type of a list of arguments */
argumentList
    : ((listedArgument ',')* argumentListLast)?
    ;

argumentListLast
    : listedArgument
    | spreadArgument
    | comprehension
    ;

/* 6.6.4. Listed arguments */
listedArgument
    : expression
    ;

/* 6.6.5. Spread arguments */
spreadArgument
    : '*' expression
    ;

/* 6.6.6. Comprehensions */
comprehension
    : forComprehensionClause
    | ifComprehensionClause
    ;

forComprehensionClause
    : 'for' forIterator comprehensionClause
    ;
    
ifComprehensionClause
    : 'if' conditionList comprehensionClause
    ;

comprehensionClause
    : forComprehensionClause 
    | ifComprehensionClause 
    | expression
    ;

/* 6.6.7. Positional argument lists */
positionalArguments
    : '(' argumentList ')'
    ;

/* 6.6.8. Named argument lists */
namedArguments
    : '{' namedArgumentList argumentList '}'
    ;

namedArgumentList
    : namedArgument*
    ;

namedArgument
    : anonymousArgument
    | specifiedArgument
    | inlineDeclarationArgument
    ;

/* 6.6.9. Anonymous arguments */
anonymousArgument
    : expression ';'
    ;

/* 6.6.10. Specified arguments */
specifiedArgument
    : specification
    ;

/* 6.6.11. Inline declaration arguments */
inlineDeclarationArgument
    : valueArgument
    | functionArgument
    | objectArgument
    ;

valueArgument
    : valueHeader valueArgumentBody
    ;

valueArgumentBody
    : blockDefinition
    | valueDefinition
    | lazyDefinition
    ;

functionArgument
    : functionHeader (blockDefinition | lazyDefinition)
    ;

objectArgument
    : objectHeader classBlock
    ;

/* 6.6.12. Iterable and tuple enumeration */
enumeration
    : iterable
    | tuple
    | dynamicValue
    ;

iterable
    : '{' argumentList '}'
    ;

tuple
    : '[' argumentList ']'
    ;

/* 6.6.13. Dynamic enumerations */
dynamicValue
    : 'dynamic' '[' namedArgumentList argumentList ']'
    ;

/*=============================================================================
  6.7. Conditional expressions, let expressions, and anonymous class expressions
=============================================================================*/

conditionalExpression
    : ifElseExpression
    | switchCaseElseExpression
    ;

/* 6.7.1. if/then/else expressions */
ifElseExpression
    : 'if' conditionList thenExpression elseExpression
    ;

thenExpression
    : 'then' expression
    ;

elseExpression
    : 'else' expression
    ;

/* 6.7.2. switch/case/else expressions */
switchCaseElseExpression
    : switch caseExpression+ elseExpression?
    ;

caseExpression
    : 'else'? 'case' caseCondition expression
    ;

/* 6.7.3. let expressions */
letExpression
    : 'let' patternList expression?
    ;

patternList
    : '(' patternWithValue (',' patternWithValue)* ')'
    ;

patternWithValue
    : pattern valueSpecifier
    ;

/* 6.7.4. Inline anonymous class expressions */
objectExpression
    : 'object' objectInheritance classBlock
    ;

indexed
    : '[' '...' expression ']'              # UpToRange
    | '[' expression '...' ']'              # FromUpRange
    | '[' expression '..' expression ']'    # FromToRange
    | '[' expression ':' expression ']'     # FromLengthRange
    | '[' expression ']'                    # SingleIndex
    ;

/*=============================================================================
  6.8. Operators
=============================================================================*/

expression
    : primary                                       # PrimaryExpr
    | expression ('--' | '++')                      # PostfixExpr
    | ('--' | '++') expression                      # PrefixExpr
    | <assoc=right> expression ('^') expression     # InfixExpr
    | ('-' | '+' | '~') expression                  # PrefixExpr
    | expression ('&') expression                   # InfixExpr
    | expression ('|' | '~') expression             # InfixExpr
    | expression ('*' | '/' | '%') expression       # InfixExpr
    | <assoc=right> expression ('**') expression    # InfixExpr
    | expression ('+' | '-') expression             # InfixExpr
    | expression ('..' | ':' | '->') expression     # NonassocInfixExpr
    | expression ('|>' | '>|>') expression          # InfixExpr
    | expression ('exists' | 'nonempty')            # NonassocPostfixExpr
    | expression 
      ('is' | 'of'| 'extends' | 'satisfies')
      type                                          # TypeExpr
    | expression 
      ('<=>' | '<' | '>' | '<=' | '>=' | 'in')
      expression                                    # NonassocInfixExpr
    | expression ('==' | '!=' | '===') expression   # NonassocInfixExpr
    | ('!') expression                              # PrefixExpr
    | expression ('&&') expression                  # InfixExpr
    | expression ('||') expression                  # InfixExpr
    | expression ('else' | 'then') expression       # InfixExpr
    | <assoc=right> expression
      ('=' | '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '|=' | '~=' | '&&=' | '||=')
      expression                                    # InfixExpr
    ;

memberSelectionOperator
    : '.' | '?.' | '*.'
    ;

/*=============================================================================
  6.9. Metamodel expressions
=============================================================================*/

meta
    : typeMeta
    | baseMeta
    | memberMeta
    | constructorMeta
    ;

typeMeta
    : '`' type '`'
    ;
    
baseMeta
    : '`' packageQualifier? memberName typeArguments? '`'
    ;
    
memberMeta
    : '`' primaryType '.' memberName typeArguments? '`'
    ;
    
constructorMeta
    : '`' primaryType '.' nameWithArguments '`'
    ;
    

/*=============================================================================
  6.10. Reference expressions
=============================================================================*/

declarationReference
    : '`' referenceKeyword referenceName? '`'
    ;

referenceKeyword
    : 'class'
    | 'interface'
    | 'alias'
    | 'given'
    | 'value'
    | 'function'
    | 'package'
    | 'module'
    ;

referenceName
    : packageQualifier? fullName
    ;

/*=============================================================================
 Chapter 7. Annotations
=============================================================================*/

/*=============================================================================
  7.1. Annotations of program elements
=============================================================================*/

/* 7.1.1 Annotation lists */
annotation
    : memberName arguments?
    ;

annotations
    : stringLiteral? annotation*
    ;

/*=============================================================================
  Chapter 9. Module system
=============================================================================*/

/* 9.3.9. Package descriptors */
packageDescriptor
    : annotations 'package' fullName ';'
    ;

/* 9.3.10. Module descriptors */
moduleDescriptor
    : annotations 'module' fullName moduleSpecifier? version moduleBody
    ;

moduleSpecifier
    : repository moduleName (artifact classifier?)?
    ;

repository
    : memberName ':'
    ;

moduleName
    : fullName
    | stringLiteral
    ;

artifact
    : ':' stringLiteral
    ;

classifier
    : ':' stringLiteral
    ;

version
    : stringLiteral
    ;

moduleBody
    : '{' moduleImport* '}'
    ;

moduleDesignator
    : moduleName
    | moduleSpecifier
    ;

moduleImport
    : annotations 'import' (moduleName | moduleSpecifier) version ';'
    ;

