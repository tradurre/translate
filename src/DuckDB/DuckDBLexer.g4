lexer grammar DuckDBLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }

ALTER : 'ALTER';
ANALYZE : 'ANALYZE';
ARRAY : 'ARRAY' ;
AS : 'AS';
ATTACH : 'ATTACH';

BIGINT : 'BIGINT' ;
BINARY : 'BINARY' ;
BIT : 'BIT' ;
BITSTRING : 'BITSTRING' ;
BLOB : 'BLOB' ;
BOOL : 'BOOL' ;
BOOLEAN : 'BOOLEAN' ;
BPCHAR : 'BPCHAR' ;
BY : 'BY';
BYTEA : 'BYTEA' ;

CALL : 'CALL';
CASCADE : 'CASCADE';
CHAR : 'CHAR' ;
CHECKPOINT : 'CHECKPOINT';
COLUMN : 'COLUMN';
COMMENT : 'COMMENT';
COPY : 'COPY';
CREATE : 'CREATE';
CYCLE : 'CYCLE';

DATA : 'DATA';
DATABASE : 'DATABASE';
DATE : 'DATE' ;
DATETIME : 'DATETIME' ;
DECIMAL : 'DECIMAL' ;
DETACH : 'DETACH';
DOUBLE : 'DOUBLE' ;
DROP : 'DROP';

ENUM : 'ENUM';
EXISTS : 'EXISTS';

FLOAT : 'FLOAT' ;
FLOAT4 : 'FLOAT4' ;
FLOAT8 : 'FLOAT8' ;
FORCE : 'FORCE';
FROM : 'FROM';
FUNCTION : 'FUNCTION';

HUGEINT : 'HUGEINT' ;

IF : 'IF' ;
INCREMENT : 'INCREMENT';
INDEX: 'INDEX';
INT : 'INT' ;
INT1 : 'INT1' ;
INT2 : 'INT2' ;
INT4 : 'INT4' ;
INT8 : 'INT8' ;
INTEGER : 'INTEGER' ;
INTERVAL : 'INTERVAL' ;
IS : 'IS';

JSON : 'JSON' ;

LIST : 'LIST' ;
LOGICAL : 'LOGICAL' ;
LONG : 'LONG' ;

MACRO : 'MACRO';
MAP : 'MAP' ;
MAXVALUE : 'MAXVALUE' ;
MINVALUE : 'MINVALUE' ;

NO : 'NO';
NOT : 'NOT';
NULL : 'NULL';
NUMERIC : 'NUMERIC' ;

ON : 'ON';
OR : 'OR';

PERSISTENT : 'PERSISTENT';
REAL : 'REAL' ;
RENAME : 'RENAME';
REPLACE : 'REPLACE';
RESTRICT : 'RESTRICT';

SCHEMA : 'SCHEMA';
SECRET : 'SECRET';
SEQUENCE : 'SEQUENCE';
SHORT : 'SHORT' ;
SIGNED : 'SIGNED' ;
SMALLINT : 'SMALLINT' ;
START : 'START';
STRING : 'STRING' ;
STRUCT : 'STRUCT' ;

TABLE : 'TABLE';
TEMP : 'TEMP';
TEMPORARY : 'TEMPORARY';
TEXT : 'TEXT' ;
TIME : 'TIME' ;
TIMESTAMP : 'TIMESTAMP' ;
TIMEZONE : 'TIMEZONE' ;
TIMESTAMPTZ : 'TIMESTAMPTZ' ;
TINYINT : 'TINYINT' ;
TO : 'TO';
TYPE : 'TYPE';

UBIGINT : 'UBIGINT' ;
UHUGEINT : 'UHUGEINT' ;
UINTEGER : 'UINTEGER' ;
UNION : 'UNION' ;
UNIQUE : 'UNIQUE';
USE : 'USE';
USING : 'USING';
USMALLINT : 'USMALLINT' ;
UTINYINT : 'UTINYINT' ;
UUID : 'UUID' ;

VACUUM : 'VACUUM';
VARBINARY : 'VARBINARY' ;
VARCHAR : 'VARCHAR' ;
VIEW : 'VIEW';

WITH : 'WITH';

ZONE : 'ZONE';


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
SINGLE_QUOTED_IDENTIFER : '\'' ( '\'\'' | ~'\'' )* '\'';
ID_DIGIT : '-'? F_DIGIT+ ;
IDENTIFIER : ( [A-Z] | FULL_WIDTH_LETTER ) ( [A-Z_#$@0-9] | FULL_WIDTH_LETTER )* ;


fragment F_DIGIT : [0-9];

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