lexer grammar PostgresLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }

UESCAPE : 'UESCAPE' ;

WHITE_SPACE : [ \r\n\t]+ -> channel(whitespace) ;

// Comments

DOUBLE_QUOTED_IDENTIFER : 'U&'? '"' ( '""' | ~'"' )* '"' ( UESCAPE  )? ;
IDENTIFIER : ( [A-Z_] | FULL_WIDTH_LETTER ) ( [A-Z_0-9$] | FULL_WIDTH_LETTER )* ;

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