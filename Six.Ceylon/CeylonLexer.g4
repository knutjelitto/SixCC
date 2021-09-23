lexer grammar CeylonLexer;

/* Lexer */

fragment Digits
    : Digit ('_' | Digit)*
    ;

fragment FractionalDigits
    : Digit ('_' | Digit)*
    ;

fragment HexDigits
    : HexDigit ('_' | HexDigit)*
    ;

fragment BinaryDigits
    : BinaryDigit ('_' | BinaryDigit)*
    ;

fragment Exponent    
    : ( 'e' | 'E' ) ( '+' | '-' )? Digit*
    ;

fragment Magnitude
    : 'k' | 'M' | 'G' | 'T' | 'P'
    ;

fragment FractionalMagnitude
    : 'm' | 'u' | 'n' | 'p' | 'f'
    ;
    
NORMAL_FLOAT_LITERAL
    : Digits '.' FractionalDigits (Exponent|Magnitude|FractionalMagnitude)?
    ;
    
SHORT_FLOAT_LITERAL
    : Digits FractionalMagnitude
    ;

DECIMAL_LITERAL
    : Digits Magnitude?
    ;
    
HEX_LITERAL
    : '#' HexDigits
    ;
    
BIN_LITERAL
    : '$' BinaryDigits
    ;
    
CHAR_LITERAL
    : '\'' CharCharacter '\''
    ;

STRING_LITERAL
    : '"' StringCharacter* '`'? '"'
    ;

STRING_START
    : '"' StringCharacter* '``'
    ;

STRING_MID
    : '``' StringCharacter* '``'
    ;

STRING_END
    : '``' StringCharacter* '"'
    ;

VERBATIM_STRING
    : '"""' .*? '"""'
    ;

VERBATIM_STRING2
    : '"""' (~'"' | '"' ~'"' | '""' ~'"')* ('"' ('"' ('"' ('"' '"'?)?)?)?)?
    ;

fragment CharCharacter
    : ~('\\' | '\'')
    | EscapeSequence
    ;
    
fragment StringCharacter
    : ~('\\' | '"' | '`')
    | '`' ~('`' | '"' | '\\')
    | '`'? EscapeSequence
    | '`'? EscapedBreak
    ;

fragment EscapedBreak
    : '\\' LineBreak
    ;

fragment EscapeSequence 
    : '\\' (SingleCharacterEscape | '{' CharacterCode '}')
    ;

fragment SingleCharacterEscape
    : 'b' | 't' | 'n' | 'f' | 'r' | 'e' | '\\' | '"' | '\'' | '`' | '0'
    ;

fragment CharacterCode
    : '#' HexDigit HexDigit (HexDigit HexDigit (HexDigit HexDigit (HexDigit HexDigit)?)?)?
    | (Letter | ' ' | '_' | '-')+
    ;

fragment CarriageReturnCharacter
    : '\r'
    ;

fragment NewlineCharacter
    : '\n'
    ;

fragment LineBreak
    : CarriageReturnCharacter NewlineCharacter
    | CarriageReturnCharacter
    | NewlineCharacter
    ;

Whitespace
    :   (' ' | '\r' | '\n')+ -> channel(HIDDEN)
    ;

SingleLineComment
    :   ('//'|'#!') ~('\r' | '\n')* LineBreak? -> channel(HIDDEN)
    ;   

MultiLineComment
    :   '/*' (MultiLineComment|.)*? '*/' -> channel(HIDDEN)
    ;

/*
    List of keywords.
    
    Note that this must be kept in sync with org.eclipse.ceylon.compiler.typechecker.parser.ParseUtil
*/

ABSTRACTS:  'abstracts';
ALIAS:      'alias';
ASSEMBLY:   'assembly';
ASSERT:     'assert';
ASSIGN:     'assign';
BREAK:      'break';
CASE:       'case';
CATCH:      'catch';
CLASS:      'class';
CONTINUE:   'continue';
DYNAMIC:    'dynamic';
ELSE:       'else';
EXISTS:     'exists';
EXTENDS:    'extends';
FINALLY:    'finally';
FOR:        'for';
FUNCTION:   'function';
GIVEN:      'given';
IF:         'if';
IMPORT:     'import';
IN:         'in';
INTERFACE:  'interface';
IS:         'is';
LET:        'let';
MODULE:     'module';
NEW:        'new';
NONEMPTY:   'nonempty';
OBJECT:     'object';
OF:         'of';
OUT:        'out';
OUTER:      'outer';
PACKAGE:    'package';
RETURN:     'return';
SATISFIES:  'satisfies';
SUPER:      'super';
SWITCH:     'switch';
THEN:       'then';            
THIS:       'this';
THROW:      'throw';
TRY:        'try';
VALUE:      'value';
VOID:       'void';
WHILE:      'while';

BACKTICK:           '`'     ;
ELLIPSIS:           '...'   ;
RANGE_OP:           '..'    ;
SEGMENT_OP:         ':'     ;
MEMBER_OP:          '.'     ;
LPAREN:             '('     ;
RPAREN:             ')'     ;
LBRACE:             '{'     ;
RBRACE:             '}'     ;
LBRACKET:           '['     ;
RBRACKET:           ']'     ;
SEMICOLON:          ';'     ;
COMMA:              ','     ;    
SPECIFY:            '='     ;
COMPUTE:            '=>'    ;
SAFE_MEMBER_OP:     '?.'    ;
OPTIONAL:           '?'     ;
NOT_OP:             '!'     ;
COMPLEMENT_OP:      '~'     ;
EQUAL_OP:           '=='    ;
IDENTICAL_OP:       '==='   ;
AND_OP:             '&&'    ;
OR_OP:              '||'    ;
INCREMENT_OP:       '++'    ;
DECREMENT_OP:       '--'    ;
SUM_OP:             '+'     ;
DIFFERENCE_OP:      '-'     ;
SPREAD_OP:          '*.'    ;
SCALE_OP:           '**'    ;
PRODUCT_OP:         '*'     ;
QUOTIENT_OP:        '/'     ;
INTERSECTION_OP:    '&'     ;
UNION_OP:           '|'     ;
REMAINDER_OP:       '%'     ;
NOT_EQUAL_OP:       '!='    ;
LARGER_OP:          '>'     ;
SMALLER_OP:         '<'     ;
LARGE_AS_OP:        '>='    ;
SMALL_AS_OP:        '<='    ;
ENTRY_OP:           '->'    ;
COMPARE_OP:         '<=>'   ;
POWER_OP:           '^'     ;
ADD_SPECIFY:        '+='    ;
SUBTRACT_SPECIFY:   '-='    ;
MULTIPLY_SPECIFY:   '*='    ;
DIVIDE_SPECIFY:     '/='    ;
INTERSECT_SPECIFY:  '&='    ;
UNION_SPECIFY:      '|='    ;
COMPLEMENT_SPECIFY: '~='    ;
REMAINDER_SPECIFY:  '%='    ;
AND_SPECIFY:        '&&='   ;
OR_SPECIFY:         '||='   ;
PIPE:               '|>'    ;
BACKPIPE:           '<|'    ;
FISH:               '>|>'   ;
BACKFISH:           '<|<'   ;
DOLLAR:             '$'     ;
AT:                 '@'     ;
HASH:               '#'     ;


LIDENTIFIER
    :   LowercaseCharacter IdentifierCharacter*
    |   '\\i' IdentifierCharacter+
    ;

UIDENTIFIER 
    :   UppercaseCharacter IdentifierCharacter*
    |   '\\I' IdentifierCharacter+
    ;

fragment LowercaseCharacter
    : LowercaseLetter
    | '_'
    ;

fragment UppercaseCharacter
    : UppercaseLetter
    ;

fragment IdentifierCharacter
    : LowercaseCharacter
    | UppercaseCharacter
    | Number
    | [²]
    ;

fragment LowercaseLetter
    : 'a'..'z'
    ;

fragment UppercaseLetter
    : 'A'..'Z'
    ;

fragment Letter
    : LowercaseLetter
    | UppercaseLetter
    ;

fragment Number
    : '0'..'9'
    ;

fragment Digit
    : '0'..'9'
    ;

fragment HexDigit
    : '0'..'9' | 'A'..'F' | 'a'..'f'
    ;

fragment BinaryDigit
    : '0'|'1'
    ;
