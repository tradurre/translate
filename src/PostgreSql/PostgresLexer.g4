﻿lexer grammar PostgresLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }

ABORT : 'ABORT' ;
ABS : 'ABS' ;
ABSENT : 'ABSENT' ;
ABSOLUTE : 'ABSOLUTE' ;
ACCESS : 'ACCESS' ;
ACCORDING : 'ACCORDING' ;
ACOS : 'ACOS' ;
ACTION : 'ACTION' ;
ADA : 'ADA' ;
ADD : 'ADD' ;
ADMIN : 'ADMIN' ;
AFTER : 'AFTER' ;
AGGREGATE : 'AGGREGATE' ;
ALL : 'ALL' ;
ALLOCATE : 'ALLOCATE' ;
ALSO : 'ALSO' ;
ALTER : 'ALTER' ;
ALWAYS : 'ALWAYS' ;
ANALYSE : 'ANALYSE' ;
ANALYZE : 'ANALYZE' ;
AND : 'AND' ;
ANY : 'ANY' ;
ANY_VALUE : 'ANY_VALUE' ;
ARE : 'ARE' ;
ARRAY : 'ARRAY' ;
ARRAY_AGG : 'ARRAY_AGG' ;
ARRAY_MAX_CARDINALITY : 'ARRAY_MAX_CARDINALITY' ;
AS : 'AS' ;
ASC : 'ASC' ;
ASENSITIVE : 'ASENSITIVE' ;
ASIN : 'ASIN' ;
ASSERTION : 'ASSERTION' ;
ASSIGNMENT : 'ASSIGNMENT' ;
ASYMMETRIC : 'ASYMMETRIC' ;
AT : 'AT' ;
ATAN : 'ATAN' ;
ATOMIC : 'ATOMIC' ;
ATTACH : 'ATTACH' ;
ATTRIBUTE : 'ATTRIBUTE' ;
ATTRIBUTES : 'ATTRIBUTES' ;
AUTHORIZATION : 'AUTHORIZATION' ;
AVG : 'AVG' ;

BACKWARD : 'BACKWARD' ;
BASE64 : 'BASE64' ;
BEFORE : 'BEFORE' ;
BEGIN : 'BEGIN' ;
BEGIN_FRAME : 'BEGIN_FRAME' ;
BEGIN_PARTITION : 'BEGIN_PARTITION' ;
BERNOULLI : 'BERNOULLI' ;
BETWEEN : 'BETWEEN' ;
BIGINT : 'BIGINT' ;
BINARY : 'BINARY' ;
BIT : 'BIT' ;
BIT_LENGTH : 'BIT_LENGTH' ;
BLOB : 'BLOB' ;
BLOCKED : 'BLOCKED' ;
BOM : 'BOM' ;
BOOLEAN : 'BOOLEAN' ;
BOTH : 'BOTH' ;
BREADTH : 'BREADTH' ;
BTRIM : 'BTRIM' ;
BY : 'BY' ;

CACHE : 'CACHE' ;
CALL : 'CALL' ;
CALLED : 'CALLED' ;
CARDINALITY : 'CARDINALITY' ;
CASCADE : 'CASCADE' ;
CASCADED : 'CASCADED' ;
CASE : 'CASE' ;
CAST : 'CAST' ;
CATALOG : 'CATALOG' ;
CATALOG_NAME : 'CATALOG_NAME' ;
CEIL : 'CEIL' ;
CEILING : 'CEILING' ;
CHAIN : 'CHAIN' ;
CHAINING : 'CHAINING' ;
CHAR : 'CHAR' ;
CHAR_LENGTH : 'CHAR_LENGTH' ;
CHARACTER : 'CHARACTER' ;
CHARACTER_LENGTH : 'CHARACTER_LENGTH' ;
CHARACTER_SET_CATALOG : 'CHARACTER_SET_CATALOG' ;
CHARACTER_SET_NAME : 'CHARACTER_SET_NAME' ;
CHARACTER_SET_SCHEMA : 'CHARACTER_SET_SCHEMA' ;
CHARACTERISTICS : 'CHARACTERISTICS' ;
CHARACTERS : 'CHARACTERS' ;
CHECK : 'CHECK' ;
CHECKPOINT : 'CHECKPOINT' ;
CLASS : 'CLASS' ;
CLASS_ORIGIN : 'CLASS_ORIGIN' ;
CLASSIFIER : 'CLASSIFIER' ;
CLOB : 'CLOB' ;
CLOSE : 'CLOSE' ;
CLUSTER : 'CLUSTER' ;
COALESCE : 'COALESCE' ;
COBOL : 'COBOL' ;
COLLATE : 'COLLATE' ;
COLLATION : 'COLLATION' ;
COLLATION_CATALOG : 'COLLATION_CATALOG' ;
COLLATION_NAME : 'COLLATION_NAME' ;
COLLATION_SCHEMA : 'COLLATION_SCHEMA' ;
COLLECT : 'COLLECT' ;
COLUMN : 'COLUMN' ;
COLUMN_NAME : 'COLUMN_NAME' ;
COLUMNS : 'COLUMNS' ;
COMMAND_FUNCTION : 'COMMAND_FUNCTION' ;
COMMAND_FUNCTION_CODE : 'COMMAND_FUNCTION_CODE' ;
COMMENT : 'COMMENT' ;
COMMENTS : 'COMMENTS' ;
COMMIT : 'COMMIT' ;
COMMITTED : 'COMMITTED' ;
COMPRESSION : 'COMPRESSION' ;
CONCURRENTLY : 'CONCURRENTLY' ;
CONDITION : 'CONDITION' ;
CONDITION_NUMBER : 'CONDITION_NUMBER' ;
CONDITIONAL : 'CONDITIONAL' ;
CONFIGURATION : 'CONFIGURATION' ;
CONFLICT : 'CONFLICT' ;
CONNECT : 'CONNECT' ;
CONNECTION : 'CONNECTION' ;
CONNECTION_NAME : 'CONNECTION_NAME' ;
CONSTRAINT : 'CONSTRAINT' ;
CONSTRAINT_CATALOG : 'CONSTRAINT_CATALOG' ;
CONSTRAINT_NAME : 'CONSTRAINT_NAME' ;
CONSTRAINT_SCHEMA : 'CONSTRAINT_SCHEMA' ;
CONSTRAINTS : 'CONSTRAINTS' ;
CONSTRUCTOR : 'CONSTRUCTOR' ;
CONTAINS : 'CONTAINS' ;
CONTENT : 'CONTENT' ;
CONTINUE : 'CONTINUE' ;
CONTROL : 'CONTROL' ;
CONVERSION : 'CONVERSION' ;
CONVERT : 'CONVERT' ;
COPARTITION : 'COPARTITION' ;
COPY : 'COPY' ;
CORR : 'CORR' ;
CORRESPONDING : 'CORRESPONDING' ;
COS : 'COS' ;
COSH : 'COSH' ;
COST : 'COST' ;
COUNT : 'COUNT' ;
COVAR_POP : 'COVAR_POP' ;
COVAR_SAMP : 'COVAR_SAMP' ;
CREATE : 'CREATE' ;
CROSS : 'CROSS' ;
CSV : 'CSV' ;
CUBE : 'CUBE' ;
CUME_DIST : 'CUME_DIST' ;
CURRENT : 'CURRENT' ;
CURRENT_CATALOG : 'CURRENT_CATALOG' ;
CURRENT_DATE : 'CURRENT_DATE' ;
CURRENT_DEFAULT_TRANSFORM_GROUP : 'CURRENT_DEFAULT_TRANSFORM_GROUP' ;
CURRENT_PATH : 'CURRENT_PATH' ;
CURRENT_ROLE : 'CURRENT_ROLE' ;
CURRENT_ROW : 'CURRENT_ROW' ;
CURRENT_SCHEMA : 'CURRENT_SCHEMA' ;
CURRENT_TIME : 'CURRENT_TIME' ;
CURRENT_TIMESTAMP : 'CURRENT_TIMESTAMP' ;
CURRENT_TRANSFORM_GROUP_FOR_TYPE : 'CURRENT_TRANSFORM_GROUP_FOR_TYPE' ;
CURRENT_USER : 'CURRENT_USER' ;
CURSOR : 'CURSOR' ;
CURSOR_NAME : 'CURSOR_NAME' ;
CYCLE : 'CYCLE' ;

DATA : 'DATA' ;
DATABASE : 'DATABASE' ;
DATALINK : 'DATALINK' ;
DATE : 'DATE' ;
DATETIME_INTERNAL_CODE : 'DATETIME_INTERNAL_CODE' ;
DATETIME_INTERVAL_PRECISION : 'DATETIME_INTERVAL_PRECISION' ;
DAY : 'DAY' ;
DB : 'DB' ;
DEALLOCATE : 'DEALLOCATE' ;
DEC : 'DEC' ;
DECFLOAT : 'DECFLOAT' ;
DECIMAL : 'DECIMAL' ;
DECLARE : 'DECLARE' ;
DEFAULT : 'DEFAULT' ;
DEFAULTS : 'DEFAULTS' ;
DEFERRABLE : 'DEFERRABLE' ;
DEFERRED : 'DEFERRED' ;
DEFINE : 'DEFINE' ;
DEFINED : 'DEFINED' ;
DEFINER : 'DEFINER' ;
DEGREE : 'DEGREE' ;
DELETE : 'DELETE' ;
DELIMITER : 'DELIMITER' ;
DELIMITERS : 'DELIMITERS' ;
DENSE_RANK : 'DENSE_RANK' ;
DEPENDS : 'DEPENDS' ;
DEPTH : 'DEPTH' ;
DEREF : 'DEREF' ;
DERIVED : 'DERIVED' ;
DESC : 'DESC' ;
DESCRIBE : 'DESCRIBE' ;
DESCRIPTOR : 'DESCRIPTOR' ;
DETACH : 'DETACH' ;
DETERMINISTIC : 'DETERMINISTIC' ;
DIAGNOSTICS : 'DIAGNOSTICS' ;
DICTIONARY : 'DICTIONARY' ;
DISABLE : 'DISABLE' ;
DISCARD : 'DISCARD' ;
DISCONNECT : 'DISCONNECT' ;
DISPATCH : 'DISPATCH' ;
DISTINCT : 'DISTINCT' ;
DLNEWCOPY : 'DLNEWCOPY' ;
DLPREVIOUSCOPY : 'DLPREVIOUSCOPY' ;
DLURLCOMPLETE : 'DLURLCOMPLETE' ;
DLURLCOMPLETEONLY : 'DLURLCOMPLETEONLY' ;
DLURLCOMPLETEWRITE : 'DLURLCOMPLETEWRITE' ;
DLURLPATH : 'DLURLPATH' ;
DLURLPATHONLY : 'DLURLPATHONLY' ;
DLURLPATHWRITE : 'DLURLPATHWRITE' ;
DLURLSCHEME : 'DLURLSCHEME' ;
DLURLSERVER : 'DLURLSERVER' ;
DLVALUE : 'DLVALUE' ;
DO : 'DO' ;
DOCUMENT : 'DOCUMENT' ;
DOMAIN : 'DOMAIN' ;
DOUBLE : 'DOUBLE' ;
DROP : 'DROP' ;
DYNAMIC : 'DYNAMIC' ;
DYNAMIC_FUNCTION : 'DYNAMIC_FUNCTION' ;
DYNAMIC_FUNCTION_CODE : 'DYNAMIC_FUNCTION_CODE' ;

EACH : 'EACH' ;
ELEMENT : 'ELEMENT' ;
ELSE : 'ELSE' ;
EMPTY : 'EMPTY' ;
ENABLE : 'ENABLE' ;
ENCODING : 'ENCODING' ;
ENCRYPTED : 'ENCRYPTED' ;
END : 'END' ;
END_EXEC : 'END-EXEC' ;
END_FRAME : 'END_FRAME' ;
END_PARTITION : 'END_PARTITION' ;
ENFORCED : 'ENFORCED' ;
ENUM : 'ENUM' ;
EQUALS : 'EQUALS' ;
ERROR : 'ERROR' ;
ESCAPE : 'ESCAPE' ;
EVENT : 'EVENT' ;
EVERY : 'EVERY' ;
EXCEPT : 'EXCEPT' ;
EXCEPTION : 'EXCEPTION' ;
EXCLUDE : 'EXCLUDE' ;
EXCLUDING : 'EXCLUDING' ;
EXCLUSIVE : 'EXCLUSIVE' ;
EXEC : 'EXEC' ;
EXECUTE : 'EXECUTE' ;
EXISTS : 'EXISTS' ;
EXP : 'EXP' ;
EXPLAIN : 'EXPLAIN' ;
EXPRESSION : 'EXPRESSION' ;
EXTENSION : 'EXTENSION' ;
EXTERNAL : 'EXTERNAL' ;
EXTRACT : 'EXTRACT' ;

FALSE : 'FALSE' ;
FAMILY : 'FAMILY' ;
FETCH : 'FETCH' ;
FILE : 'FILE' ;
FILTER : 'FILTER' ;
FINAL : 'FINAL' ;
FINALIZE : 'FINALIZE' ;
FINISH : 'FINISH' ;
FIRST : 'FIRST' ;
FIRST_VALUE : 'FIRST_VALUE' ;
FLAG : 'FLAG' ;
FLOAT : 'FLOAT' ;
FLOOR : 'FLOOR' ;
FOLLOWING : 'FOLLOWING' ;
FOR : 'FOR' ;
FORCE : 'FORCE' ;
FOREIGN : 'FOREIGN' ;
FORMAT : 'FORMAT' ;
FORTRAN : 'FORTRAN' ;
FORWARD : 'FORWARD' ;
FOUND : 'FOUND' ;
FRAME_ROW : 'FRAME_ROW' ;
FREE : 'FREE' ;
FREEZE : 'FREEZE' ;
FROM : 'FROM' ;
FS : 'FS' ;
FULFILL : 'FULFILL' ;
FULL : 'FULL' ;
FUNCTION : 'FUNCTION' ;
FUNCTIONS : 'FUNCTIONS' ;
FUSION : 'FUSION' ;

GENERAL : 'GENERAL' ;
GENERATED : 'GENERATED' ;
GET : 'GET' ;
GLOBAL : 'GLOBAL' ;
GO : 'GO' ;
GOTO : 'GOTO' ;
GRANT : 'GRANT' ;
GRANTED : 'GRANTED' ;
GREATEST : 'GREATEST' ;
GROUP : 'GROUP' ;
GROUPING : 'GROUPING' ;
GROUPS : 'GROUPS' ;

HANDLER : 'HANDLER' ;
HAVING : 'HAVING' ;
HEADER : 'HEADER' ;
HEX : 'HEX' ;
HIERARCHY : 'HIERARCHY' ;
HOLD : 'HOLD' ;
HOUR : 'HOUR' ;

ID : 'ID' ;
IDENTITY : 'IDENTITY' ;
IF : 'IF' ;
IGNORE : 'IGNORE' ;
ILIKE : 'ILIKE' ;
IMMEDIATE : 'IMMEDIATE' ;
IMMEDIATELY : 'IMMEDIATELY' ;
IMMUTABLE : 'IMMUTABLE' ;
IMPLEMENTATION : 'IMPLEMENTATION' ;
IMPLICIT : 'IMPLICIT' ;
IMPORT : 'IMPORT' ;
IN : 'IN' ;
INCLUDE : 'INCLUDE' ;
INCLUDING : 'INCLUDING' ;
INCREMENT : 'INCREMENT' ;
INDENT : 'INDENT' ;
INDEX : 'INDEX' ;
INDEXES : 'INDEXES' ;
INDICATOR : 'INDICATOR' ;
INHERIT : 'INHERIT' ;
INHERITS : 'INHERITS' ;
INITIAL : 'INITIAL' ;
INITIALLY : 'INITIALLY' ;
INLINE : 'INLINE' ;
INNER : 'INNER' ;
INOUT : 'INOUT' ;
INPUT : 'INPUT' ;
INSENSITIVE : 'INSENSITIVE' ;
INSERT : 'INSERT' ;
INSTANCE : 'INSTANCE' ;
INSTANTIABLE : 'INSTANTIABLE' ;
INSTEAD : 'INSTEAD' ;
INT : 'INT' ;
INTEGER : 'INTEGER' ;
INTEGRITY : 'INTEGRITY' ;
INTERSECT : 'INTERSECT' ;
INTERSECTION : 'INTERSECTION' ;
INTERVAL : 'INTERVAL' ;
INTO : 'INTO' ;
INVOKER : 'INVOKER' ;
IS : 'IS' ;
ISNULL : 'ISNULL' ;
ISOLATION : 'ISOLATION' ;

JOIN : 'JOIN' ;
JSON : 'JSON' ;
JSON_ARRAY : 'JSON_ARRAY' ;
JSON_ARRAYAGG : 'JSON_ARRAYAGG' ;
JSON_EXISTS : 'JSON_EXISTS' ;
JSON_OBJECT : 'JSON_OBJECT' ;
JSON_OBJECTAGG : 'JSON_OBJECTAGG' ;
JSON_QUERY : 'JSON_QUERY' ;
JSON_SCALAR : 'JSON_SCALAR' ;
JSON_SERIALIZE : 'JSON_SERIALIZE' ;
JSON_TABLE : 'JSON_TABLE' ;
JSON_TABLE_PRIMITIVE : 'JSON_TABLE_PRIMITIVE' ;
JSON_VALUE : 'JSON_VALUE' ;

KEEP : 'KEEP' ;
KEY : 'KEY' ;
KEY_MEMBER : 'KEY_MEMBER' ;
KEY_TYPE : 'KEY_TYPE' ;
KEYS : 'KEYS' ;

LABEL : 'LABEL' ;
LAG : 'LAG' ;
LANGUAGE : 'LANGUAGE' ;
LARGE : 'LARGE' ;
LAST : 'LAST' ;
LAST_VALUE : 'LAST_VALUE' ;
LATERAL : 'LATERAL' ;
LEAD : 'LEAD' ;
LEADING : 'LEADING' ;
LEAKPROOF : 'LEAKPROOF' ;
LEAST : 'LEAST' ;
LEFT : 'LEFT' ;
LENGTH : 'LENGTH' ;
LEVEL : 'LEVEL' ;
LIBRARY : 'LIBRARY' ;
LIKE : 'LIKE' ;
LIKE_REGEX : 'LIKE_REGEX' ;
LIMIT : 'LIMIT' ;
LINK : 'LINK' ;
LISTAGG : 'LISTAGG' ;
LISTEN : 'LISTEN' ;
LN : 'LN' ;
LOAD : 'LOAD' ;
LOCAL : 'LOCAL' ;
LOCALTIME : 'LOCALTIME' ;
LOCALTIMESTAMP : 'LOCALTIMESTAMP' ;
LOCATION : 'LOCATION' ;
LOCATOR : 'LOCATOR' ;
LOCK : 'LOCK' ;
LOCKED : 'LOCKED' ;
LOG : 'LOG' ;
LOG10 : 'LOG10' ;
LOGGED : 'LOGGED' ;
LOWER : 'LOWER' ;
LPAD : 'LPAD' ;
LTRIM : 'LTRIM' ;

MAP : 'MAP' ;
MAPPING : 'MAPPING' ;
MATCH : 'MATCH' ;
MATCH_NUMBER : 'MATCH_NUMBER' ;
MATCH_RECOGNIZE : 'MATCH_RECOGNIZE' ;
MATCHED : 'MATCHED' ;
MATCHES : 'MATCHES' ;
MATERIALIZED : 'MATERIALIZED' ;
MAX : 'MAX' ;
MAXVALUE : 'MAXVALUE' ;
MEASURES : 'MEASURES' ;
MEMBER : 'MEMBER' ;
MERGE : 'MERGE' ;
MERGE_ACTION : 'MERGE_ACTION' ;
MESSAGE_LENGTH : 'MESSAGE_LENGTH' ;
MESSAGE_OCTET_LENGTH : 'MESSAGE_OCTET_LENGTH' ;
MESSAGE_TEXT : 'MESSAGE_TEXT' ;
METHOD : 'METHOD' ;
MIN : 'MIN' ;
MINUTE : 'MINUTE' ;
MINVALUE : 'MINVALUE' ;
MOD : 'MOD' ;
MODE : 'MODE' ;
MODIFIES : 'MODIFIES' ;
MODULE : 'MODULE' ;
MONTH : 'MONTH' ;
MORE_ : 'MORE' ;
MOVE : 'MOVE' ;
MULTISET : 'MULTISET' ;
MUMPS : 'MUMPS' ;

NAME : 'NAME' ;
NAMES : 'NAMES' ;
NAMESPACE : 'NAMESPACE' ;
NATIONAL : 'NATIONAL' ;
NATURAL : 'NATURAL' ;
NCHAR : 'NCHAR' ;
NCLOB : 'NCLOB' ;
NESTED : 'NESTED' ;
NESTING : 'NESTING' ;
NEW : 'NEW' ;
NEXT : 'NEXT' ;
NFC : 'NFC' ;
NFD : 'NFD' ;
NFKC : 'NFKC' ;
NFKD : 'NFKD' ;
NIL : 'NIL' ;
NO : 'NO' ;
NONE : 'NONE' ;
NORMALIZE : 'NORMALIZE' ;
NORMALIZED : 'NORMALIZED' ;
NOT : 'NOT' ;
NOTHING : 'NOTHING' ;
NOTIFY : 'NOTIFY' ;
NOTNULL : 'NOTNULL' ;
NOWAIT : 'NOWAIT' ;
NTH_VALUE : 'NTH_VALUE' ;
NTILE : 'NTILE' ;
NULL : 'NULL' ;
NULL_ORDERING : 'NULL_ORDERING' ;
NULLABLE : 'NULLABLE' ;
NULLIF : 'NULLIF' ;
NULLS : 'NULLS' ;
NUMBER : 'NUMBER' ;
NUMERIC : 'NUMERIC' ;

OBJECT : 'OBJECT' ;
OCCURRENCE : 'OCCURRENCE' ;
OCCURRENCES_REGEX : 'OCCURRENCES_REGEX' ;
OCTET_LENGTH : 'OCTET_LENGTH' ;
OCTETS : 'OCTETS' ;
OF : 'OF' ;
OFF : 'OFF' ;
OFFSET : 'OFFSET' ;
OIDS : 'OIDS' ;
OLD : 'OLD' ;
OMIT : 'OMIT' ;
ON : 'ON' ;
ONE : 'ONE' ;
ONLY : 'ONLY' ;
OPEN : 'OPEN' ;
OPERATOR : 'OPERATOR' ;
OPTION : 'OPTION' ;
OPTIONS : 'OPTIONS' ;
OR : 'OR' ;
ORDER : 'ORDER' ;
ORDERING : 'ORDERING' ;
ORDINALITY : 'ORDINALITY' ;
OTHERS : 'OTHERS' ;
OUT : 'OUT' ;
OUTER : 'OUTER' ;
OUTPUT : 'OUTPUT' ;
OVER : 'OVER' ;
OVERFLOW : 'OVERFLOW' ;
OVERLAPS : 'OVERLAPS' ;
OVERLAY : 'OVERLAY' ;
OVERRIDING : 'OVERRIDING' ;
OWNED : 'OWNED' ;
OWNER : 'OWNER' ;

PAD : 'PAD' ;
PARALLEL : 'PARALLEL' ;
PARAMETER : 'PARAMETER' ;
PARAMETER_MODE : 'PARAMETER_MODE' ;
PARAMETER_NAME : 'PARAMETER_NAME' ;
PARAMETER_ORDINAL_POSITION : 'PARAMETER_ORDINAL_POSITION' ;
PARAMETER_SPECIFIC_CATALOG : 'PARAMETER_SPECIFIC_CATALOG' ;
PARAMETER_SPECIFIC_NAME : 'PARAMETER_SPECIFIC_NAME' ;
PARAMETER_SPECIFIC_SCHEMA : 'PARAMETER_SPECIFIC_SCHEMA' ;
PARSER : 'PARSER' ;
PARTIAL : 'PARTIAL' ;
PARTITION : 'PARTITION' ;
PASCAL : 'PASCAL' ;
PASS : 'PASS' ;
PASSING : 'PASSING' ;
PASSTHROUGH : 'PASSTHROUGH' ;
PASSWORD : 'PASSWORD' ;
PAST : 'PAST' ;
PATH : 'PATH' ;
PATTERN : 'PATTERN' ;
PER : 'PER' ;
PERCENT : 'PERCENT' ;
PERCENT_RANK : 'PERCENT_RANK' ;
PERCENTILE_CONT : 'PERCENTILE_CONT' ;
PERCENTILE_DISC : 'PERCENTILE_DISC' ;
PERIOD : 'PERIOD' ;
PERMISSION : 'PERMISSION' ;
PERMUTE : 'PERMUTE' ;
PIPE : 'PIPE' ;
PLACING : 'PLACING' ;
PLAN : 'PLAN' ;
PLANS : 'PLANS' ;
PLI : 'PLI' ;
POLICY : 'POLICY' ;
PORTION : 'PORTION' ;
POSITION : 'POSITION' ;
POSITION_REGEX : 'POSITION_REGEX' ;
POWER : 'POWER' ;
PRECEDES : 'PRECEDES' ;
PRECEDING : 'PRECEDING' ;
PRECISION : 'PRECISION' ;
PREPARE : 'PREPARE' ;
PREPARED : 'PREPARED' ;
PRESERVE : 'PRESERVE' ;
PREV : 'PREV' ;
PRIMARY : 'PRIMARY' ;
PRIOR : 'PRIOR' ;
PRIVATE : 'PRIVATE' ;
PRIVILEGES : 'PRIVILEGES' ;
PROCEDURAL : 'PROCEDURAL' ;
PROCEDURE : 'PROCEDURE' ;
PROCEDURES : 'PROCEDURES' ;
PROGRAM : 'PROGRAM' ;
PRUNE : 'PRUNE' ;
PTF : 'PTF' ;
PUBLIC : 'PUBLIC' ;
PUBLICATION : 'PUBLICATION' ;

QUOTE : 'QUOTE' ;
QUOTES : 'QUOTES' ;

RANGE : 'RANGE' ;
RANK : 'RANK' ;
READ : 'READ' ;
READS : 'READS' ;
REAL : 'REAL' ;
REASSIGN : 'REASSIGN' ;
RECHECK : 'RECHECK' ;
RECOVERY : 'RECOVERY' ;
RECURSIVE : 'RECURSIVE' ;
REF : 'REF' ;
REFERENCES : 'REFERENCES' ;
REFERENCING : 'REFERENCING' ;
REFRESH : 'REFRESH' ;
REGR_AVGX : 'REGR_AVGX' ;
REGR_AVGY : 'REGR_AVGY' ;
REGR_COUNT : 'REGR_COUNT' ;
REGR_INTERCEPT : 'REGR_INTERCEPT' ;
REGR_R2 : 'REGR_R2' ;
REGR_SLOPE : 'REGR_SLOPE' ;
REGR_SXX : 'REGR_SXX' ;
REGR_SXY : 'REGR_SXY' ;
REGR_SYY : 'REGR_SYY' ;
REINDEX : 'REINDEX' ;
RELATIVE : 'RELATIVE' ;
RELEASE : 'RELEASE' ;
RENAME : 'RENAME' ;
REPEATABLE : 'REPEATABLE' ;
REPLACE : 'REPLACE' ;
REPLICA : 'REPLICA' ;
REQUIRING : 'REQUIRING' ;
RESET : 'RESET' ;
RESPECT : 'RESPECT' ;
RESTART : 'RESTART' ;
RESTORE : 'RESTORE' ;
RESTRICT : 'RESTRICT' ;
RESULT : 'RESULT' ;
RETURN : 'RETURN' ;
RETURNED_CARDINALITY : 'RETURNED_CARDINALITY' ;
RETURNED_LENGTH : 'RETURNED_LENGTH' ;
RETURNED_OCTET_LENGTH : 'RETURNED_OCTET_LENGTH' ;
RETURNED_SQLSTATE : 'RETURNED_SQLSTATE' ;
RETURNING : 'RETURNING' ;
RETURNS : 'RETURNS' ;
REVOKE : 'REVOKE' ;
RIGHT : 'RIGHT' ;
ROLE : 'ROLE' ;
ROLLBACK : 'ROLLBACK' ;
ROLLUP : 'ROLLUP' ;
ROUTINE : 'ROUTINE' ;
ROUTINE_CATALOG : 'ROUTINE_CATALOG' ;
ROUTINE_NAME : 'ROUTINE_NAME' ;
ROUTINE_SCHEMA : 'ROUTINE_SCHEMA' ;
ROUTINES : 'ROUTINES' ;
ROW : 'ROW' ;
ROW_COUNT : 'ROW_COUNT' ;
ROW_NUMBER : 'ROW_NUMBER' ;
ROWS : 'ROWS' ;
RPAD : 'RPAD' ;
RTRIM : 'RTRIM' ;
RULE : 'RULE' ;
RUNNING : 'RUNNING' ;

SAVEPOINT : 'SAVEPOINT' ;
SCALAR : 'SCALAR' ;
SCALE : 'SCALE' ;
SCHEMA : 'SCHEMA' ;
SCHEMA_NAME : 'SCHEMA_NAME' ;
SCHEMAS : 'SCHEMAS' ;
SCOPE : 'SCOPE' ;
SCOPE_CATALOG : 'SCOPE_CATALOG' ;
SCOPE_NAME : 'SCOPE_NAME' ;
SCOPE_SCHEMA : 'SCOPE_SCHEMA' ;
SCROLL : 'SCROLL' ;
SEARCH : 'SEARCH' ;
SECOND : 'SECOND' ;
SECTION : 'SECTION' ;
SECURITY : 'SECURITY' ;
SEEK : 'SEEK' ;
SELECT : 'SELECT' ;
SELECTIVE : 'SELECTIVE' ;
SELF : 'SELF' ;
SEMANTICS : 'SEMANTICS' ;
SENSITIVE : 'SENSITIVE' ;
SEQUENCE : 'SEQUENCE' ;
SEQUENCES : 'SEQUENCES' ;
SERIALIZABLE : 'SERIALIZABLE' ;
SERVER : 'SERVER' ;
SERVER_NAME : 'SERVER_NAME' ;
SESSION : 'SESSION' ;
SESSION_USER : 'SESSION_USER' ;
SET : 'SET' ;
SETOF : 'SETOF' ;
SETS : 'SETS' ;
SHARE : 'SHARE' ;
SHOW : 'SHOW' ;
SIMILAR : 'SIMILAR' ;
SIMPLE : 'SIMPLE' ;
SIN : 'SIN' ;
SINH : 'SINH' ;
SIZE : 'SIZE' ;
SKIP_ : 'SKIP' ;
SMALLINT : 'SMALLINT' ;
SNAPSHOT : 'SNAPSHOT' ;
SOME : 'SOME' ;
SORT_DIRECTION : 'SORT_DIRECTION' ;
SOURCE : 'SOURCE' ;
SPACE : 'SPACE' ;
SPECIFIC : 'SPECIFIC' ;
SPECIFIC_NAME : 'SPECIFIC_NAME' ;
SPECIFICTYPE : 'SPECIFICTYPE' ;
SQL : 'SQL' ;
SQLCODE : 'SQLCODE' ;
SQLERROR : 'SQLERROR' ;
SQLEXCEPTION : 'SQLEXCEPTION' ;
SQLSTATE : 'SQLSTATE' ;
SQLWARNING : 'SQLWARNING' ;
SQRT : 'SQRT' ;
STABLE : 'STABLE' ;
STANDALONE : 'STANDALONE' ;
START : 'START' ;
STATE : 'STATE' ;
STATEMENT : 'STATEMENT' ;
STATIC : 'STATIC' ;
STATISTICS : 'STATISTICS' ;
STDDEV_POP : 'STDDEV_POP' ;
STDDEV_SAMP : 'STDDEV_SAMP' ;
STDIN : 'STDIN' ;
STDOUT : 'STDOUT' ;
STORAGE : 'STORAGE' ;
STORED : 'STORED' ;
STRICT : 'STRICT' ;
STRING : 'STRING' ;
STRIP : 'STRIP' ;
STRUCTURE : 'STRUCTURE' ;
STYLE : 'STYLE' ;
SUBCLASS_ORIGIN : 'SUBCLASS_ORIGIN' ;
SUBMULTISET : 'SUBMULTISET' ;
SUBSCRIPTION : 'SUBSCRIPTION' ;
SUBSET : 'SUBSET' ;
SUBSTRING : 'SUBSTRING' ;
SUBSTRING_REGEX : 'SUBSTRING_REGEX' ;
SUCCEEDS : 'SUCCEEDS' ;
SUM : 'SUM' ;
SUPPORT : 'SUPPORT' ;
SYMMETRIC : 'SYMMETRIC' ;
SYSID : 'SYSID' ;
SYSTEM : 'SYSTEM' ;
SYSTEM_TIME : 'SYSTEM_TIME' ;
SYSTEM_USER : 'SYSTEM_USER' ;

TABLE : 'TABLE' ;
TABLE_NAME : 'TABLE_NAME' ;
TABLES : 'TABLES' ;
TABLESAMPLE : 'TABLESAMPLE' ;
TABLESPACE : 'TABLESPACE' ;
TAN : 'TAN' ;
TANH : 'TANH' ;
TARGET : 'TARGET' ;
TEMP : 'TEMP' ;
TEMPLATE : 'TEMPLATE' ;
TEMPORARY : 'TEMPORARY' ;
TEXT : 'TEXT' ;
THEN : 'THEN' ;
THROUGH : 'THROUGH' ;
TIES : 'TIES' ;
TIME : 'TIME' ;
TIMESTAMP : 'TIMESTAMP' ;
TIMEZONE_HOUR : 'TIMEZONE_HOUR' ;
TIMEZONE_MINUTE : 'TIMEZONE_MINUTE' ;
TO : 'TO' ;
TOKEN : 'TOKEN' ;
TOP_LEVEL_COUNT : 'TOP_LEVEL_COUNT' ;
TRAILING : 'TRAILING' ;
TRANSACTION : 'TRANSACTION' ;
TRANSACTION_ACTIVE : 'TRANSACTION_ACTIVE' ;
TRANSACTIONS_COMMITTED : 'TRANSACTIONS_COMMITTED' ;
TRANSACTIONS_ROLLED_BACK : 'TRANSACTIONS_ROLLED_BACK' ;
TRANSFORM : 'TRANSFORM' ;
TRANSFORMS : 'TRANSFORMS' ;
TRANSLATE : 'TRANSLATE' ;
TRANSLATE_REGEX : 'TRANSLATE_REGEX' ;
TRANSLATION : 'TRANSLATION' ;
TREAT : 'TREAT' ;
TRIGGER : 'TRIGGER' ;
TRIGGER_CATALOG : 'TRIGGER_CATALOG' ;
TRIGGER_NAME : 'TRIGGER_NAME' ;
TRIGGER_SCHEMA : 'TRIGGER_SCHEMA' ;
TRIM : 'TRIM' ;
TRIM_ARRAY : 'TRIM_ARRAY' ;
TRUE : 'TRUE' ;
TRUNCATE : 'TRUNCATE' ;
TRUSTED : 'TRUSTED' ;
TYPE : 'TYPE' ;
TYPES : 'TYPES' ;

UESCAPE : 'UESCAPE' ;
UNBOUNDED : 'UNBOUNDED' ;
UNCOMMITTED : 'UNCOMMITTED' ;
UNCONDITIONAL : 'UNCONDITIONAL' ;
UNDER : 'UNDER' ;
UNENCRYPTED : 'UNENCRYPTED' ;
UNION : 'UNION' ;
UNIQUE : 'UNIQUE' ;
UNKNOWN : 'UNKNOWN' ;
UNLINK : 'UNLINK' ;
UNLISTEN : 'UNLISTEN' ;
UNLOGGED : 'UNLOGGED' ;
UNMATCHED : 'UNMATCHED' ;
UNNAMED : 'UNNAMED' ;
UNNEST : 'UNNEST' ;
UNTIL : 'UNTIL' ;
UNTYPED : 'UNTYPED' ;
UPDATE : 'UPDATE' ;
UPPER : 'UPPER' ;
URI : 'URI' ;
USAGE : 'USAGE' ;
USER : 'USER' ;
USER_DEFINED_TYPE_CATALOG : 'USER_DEFINED_TYPE_CATALOG' ;
USER_DEFINED_TYPE_CODE : 'USER_DEFINED_TYPE_CODE' ;
USER_DEFINED_TYPE_NAME : 'USER_DEFINED_TYPE_NAME' ;
USER_DEFINED_TYPE_SCHEMA : 'USER_DEFINED_TYPE_SCHEMA' ;
USING : 'USING' ;
UTF16 : 'UTF16' ;
UTF32 : 'UTF32' ;
UTF8 : 'UTF8' ;

VACUUM : 'VACUUM' ;
VALID : 'VALID' ;
VALIDATE : 'VALIDATE' ;
VALIDATOR : 'VALIDATOR' ;
VALUE : 'VALUE' ;
VALUE_OF : 'VALUE_OF' ;
VALUES : 'VALUES' ;
VAR_POP : 'VAR_POP' ;
VAR_SAMP : 'VAR_SAMP' ;
VARBINARY : 'VARBINARY' ;
VARCHAR : 'VARCHAR' ;
VARIADIC : 'VARIADIC' ;
VARYING : 'VARYING' ;
VERBOSE : 'VERBOSE' ;
VERSION : 'VERSION' ;
VERSIONING : 'VERSIONING' ;
VIEW : 'VIEW' ;
VIEWS : 'VIEWS' ;
VOLATILE : 'VOLATILE' ;

WHEN : 'WHEN' ;
WHENEVER : 'WHENEVER' ;
WHERE : 'WHERE' ;
WHITESPACE : 'WHITESPACE' ;
WIDTH_BUCKET : 'WIDTH_BUCKET' ;
WINDOW : 'WINDOW' ;
WITH : 'WITH' ;
WITHIN : 'WITHIN' ;
WITHOUT : 'WITHOUT' ;
WORK : 'WORK' ;
WRAPPER : 'WRAPPER' ;
WRITE : 'WRITE' ;

XML : 'XML' ;
XMLAGG : 'XMLAGG' ;
XMLATTRIBUTES : 'XMLATTRIBUTES' ;
XMLBINARY : 'XMLBINARY' ;
XMLCAST : 'XMLCAST' ;
XMLCOMMENT : 'XMLCOMMENT' ;
XMLCONCAT : 'XMLCONCAT' ;
XMLDECLARATION : 'XMLDECLARATION' ;
XMLDOCUMENT : 'XMLDOCUMENT' ;
XMLELEMENT : 'XMLELEMENT' ;
XMLEXISTS : 'XMLEXISTS' ;
XMLFOREST : 'XMLFOREST' ;
XMLITERATE : 'XMLITERATE' ;
XMLNAMESPACES : 'XMLNAMESPACES' ;
XMLPARSE : 'XMLPARSE' ;
XMLPI : 'XMLPI' ;
XMLQUERY : 'XMLQUERY' ;
XMLROOT : 'XMLROOT' ;
XMLSCHEMA : 'XMLSCHEMA' ;
XMLSERIALIZE : 'XMLSERIALIZE' ;
XMLTABLE : 'XMLTABLE' ;
XMLTEXT : 'XMLTEXT' ;
XMLVALIDATE : 'XMLVALIDATE' ;

YEAR : 'YEAR' ;
YES : 'YES' ;

ZONE : 'ZONE' ;


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