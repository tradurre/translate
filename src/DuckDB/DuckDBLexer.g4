lexer grammar DuckDBLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }

CASCADE : 'CASCADE';
CREATE : 'CREATE';

DROP : 'DROP';

EXISTS : 'EXISTS';

FUNCTION : 'FUNCTION';

IF : 'IF' ;
INDEX: 'INDEX';

MACRO : 'MACRO';

NOT : 'NOT';

ON : 'ON';
OR : 'OR';

REPLACE : 'REPLACE';
RESTRICT : 'RESTRICT';

SCHEMA : 'SCHEMA';
SEQUENCE : 'SEQUENCE';

TABLE : 'TABLE';
TYPE : 'TYPE';

UNIQUE : 'UNIQUE';

VIEW : 'VIEW';

EQ : '=' ;
NEQ : '<>' | '!=' ;
GT : '>' ;
GTE : '>=' ;
NGT : '!>' ;
LT : '<' ;
LTE : '<=' ;
NLT : '!<' ;

AMPERSAND : '&' ;
AMPERSAND_EQUALS : '&=' ;
ASTERISK : '*' ;
BRACKET_L : '[' ;
BRACKET_R : ']' ;
COLON : ':' ;
COMMA : ',' ;
MINUS : '-' ;
PAREN_L : '(' ;
PAREN_R : ')' ;
PARENS : '()' ;
PERCENT_ : '%' ;
PERIOD_ : '.' ;
PLUS : '+' ;
SEMICOLON : ';' ;
SLASH : '/' ;

WHITE_SPACE : [ \r\n\t]+ -> channel(whitespace) ;

// Comments
COMMENT_MULTI_LINE : '/*' (.)*? '*/' -> channel(comment) ;
COMMENT_SINGLE_LINE : '--' ~[\r\n]* -> channel(comment) ;

DOUBLE_QUOTED_IDENTIFER : '"' ( '""' | ~'"' )* '"' ;
IDENTIFIER : ( [A-Z] | FULL_WIDTH_LETTER ) ( [A-Z_#$@0-9] | FULL_WIDTH_LETTER )* ;

fragment FULL_WIDTH_LETTER options {
    caseInsensitive = false;
}:
    '\u00c0' ..'\u00d6'
    | '\u00d8' ..'\u00f6'
    | '\u00f8' ..'\u00ff'
    | '\u0100' ..'\u1fff'
    | '\u2c00' ..'\u2fff'
    | '\u3040' ..'\u318f'
    | '\u3300' ..'\u337f'
    | '\u3400' ..'\u3fff'
    | '\u4e00' ..'\u9fff'
    | '\ua000' ..'\ud7ff'
    | '\uf900' ..'\ufaff'
    | '\uff00' ..'\ufff0'
;

// Catch all for undefined rules
UNRECOGNIZED : . ;