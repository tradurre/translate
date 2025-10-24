parser grammar DuckDBParser;

options { tokenVocab=DuckDBLexer; }

batch : statement+ EOF;

statement
    : alter
    | create
    | drop
    | other
    //| security    
    ;

alter
    : alter_database
    | alter_table
    | alter_view
    ;

alter_database : ALTER DATABASE if_exists? database_name RENAME TO database_name ;
alter_table : ALTER TABLE table_name ; // TODO: 
alter_view : ALTER VIEW view_name RENAME TO view_name ;

create
    : create_index
    | create_macro
    | create_schema
    | create_secret
    | create_sequence
    | create_table
    | create_type
    ;

create_index : CREATE UNIQUE? INDEX if_not_exists? index_name ON table_name
    // TODO: ( USING index_type )?
    '(' column_name ( ',' column_name )* ')'
    // TODO: '( WITH index_option ( ',' index_option )* )?
    ;
 create_macro : CREATE or_replace? temp_temporary? ( FUNCTION | MACRO ) macro_name 
    // TODO: '(' parameter_name (':=' default_value )? ( ',' parameter_name (':=' default_value )? )* ')'
    AS TABLE? // TODo: expression
    ;
create_schema : CREATE or_replace? SCHEMA if_not_exists? schema_name ;
create_secret : CREATE or_replace? ( PERSISTENT | TEMPORARY ) SECRET if_not_exists? secret_name 
    // TODO: ( IN storage_specifier )? ( TYPE secret_type ',' KEY_n VALUE_n ) ?
    ;
create_sequence : CREATE or_replace? temp_temporary? SEQUENCE sequence_name ( INCREMENT BY? increment=ID_DIGIT )? sequence_option*
    ( START WITH? start_value=ID_DIGIT ( NO? CYCLE )? );

create_table : CREATE or_replace? temp_temporary? TABLE if_not_exists? table_name
    // columns
    ( '(' column_definitions ')' )
    // TODO: | ( AS select ( WITH NO DATA )? )
    ;

create_type : CREATE TYPE name=type_name AS 
    (
        dt=data_type
        | type_name
        | ( ENUM '(' expression ( ',' expression )* ')')
        | ( STRUCT '(' field_name data_type ( ',' field_name data_type )* ')' )
        | ( UNION '(' field_name data_type ( ',' field_name data_type )* ')' )
    )
    ;

column_definition : ;
column_definitions : column_definition ( ',' column_definition )* ;


drop
    :
    drop_function
    | drop_index
    | drop_schema
    | drop_sequence
    | drop_table
    | drop_view
    | drop_type
    ;

drop_function : DROP FUNCTION if_exists? function_name  cascade_restrict? ;
drop_index : DROP INDEX if_exists? index_name cascade_restrict? ;
drop_schema : DROP SCHEMA if_exists? schema_name cascade_restrict? ;
drop_sequence : DROP SEQUENCE if_exists? sequence_name cascade_restrict? ;
drop_table : DROP MACRO? TABLE if_exists? table_name cascade_restrict? ;
drop_type : DROP TYPE if_exists?  type_name cascade_restrict? ;
drop_view : DROP VIEW if_exists? view_name cascade_restrict? ;

other
    :  analyze
    | attach
    | call
    | checkpoint
    | comment_on
    | copy
    | detach
    | statement_termination
    | use
    | vacuum
    ;

analyze : ANALYZE ;
attach : ATTACH or_replace? DATABASE? if_not_exists? ; // TODO:
call : CALL function_name ; // TODO:
checkpoint : FORCE? CHECKPOINT database_name ;
comment_on : COMMENT ON  ( COLUMN | INDEX | ( MACRO TABLE? ) | SEQUENCE | TABLE | TYPE | VIEW) entity_name IS ( SINGLE_QUOTED_IDENTIFER | NULL );
copy : COPY table_name ( '(' column_name ( ',' column_name )* ')' )? FROM file_name=SINGLE_QUOTED_IDENTIFER;
detach : DETACH ( DATABASE if_exists? )? database_name ;
statement_termination : ';' ;
use: USE database_name ( '.' schema_name )? ;
vacuum : VACUUM ANALYZE? ( table_name ( '(' column_name ( ',' column_name )* ')' )? )? ;

data_type
    : 
    BINARY
    | BIT
    | BITSTRING
    | BLOB
    | BOOL
    | BOOLEAN
    | BYTEA
    | DATE
    // TODO: | ( ENUM '(' SINGLE_QUOTED_IDENTIFER ( ',' SINGLE_QUOTED_IDENTIFER )* ')' )
    // TODO: | INTERVAL
    | VARBINARY
    
    
    /*ARRAY
    | BIGINT
    | ( BPCHAR precision_only? )    
    | ( CHAR precision_only? )    
    | DATETIME
    | ( DECIMAL precision_scale? )
    | DOUBLE
    | FLOAT
    | FLOAT4
    | FLOAT8
    | HUGEINT
    | INT
    | INT1
    | INT2
    | INT4
    | INT8
    | INTEGER    
    | JSON
    | LIST
    | LOGICAL
    | LONG
    | MAP
    | ( NUMERIC precision_scale? )
    | REAL
    | SHORT
    | SIGNED
    | SMALLINT
    | ( STRING precision_only? )
    | STRUCT
    | ( TEXT precision_only? )
    | TIME
    | TIMESTAMP
    | ( TIMESTAMP WITH TIME ZONE )
    | TIMESTAMPTZ
    | TINYINT
    | UBIGINT
    | UHUGEINT
    | UINTEGER
    | UNION
    | USMALLINT
    | UTINYINT
    | UUID    
    | ( VARCHAR precision_only? )*/
    ;

precision_only : '(' precision=ID_DIGIT  ')' ;
precision_scale : '(' precision=ID_DIGIT ( ',' scale=ID_DIGIT )? ')';

expression :
    SINGLE_QUOTED_IDENTIFER
    ;

operators : ;

cascade_restrict : CASCADE | RESTRICT ;
if_exists : IF EXISTS ;
if_not_exists : IF NOT EXISTS ;
or_replace : OR REPLACE ;
sequence_option : ( ( NO MAXVALUE ) | ( MAXVALUE max_value=ID_DIGIT ) ) | ( ( NO MINVALUE ) | ( MINVALUE min_value=ID_DIGIT ) ) ;
temp_temporary : TEMP | TEMPORARY ;

identifier
    : DOUBLE_QUOTED_IDENTIFER
    | IDENTIFIER 
    ;


column_name : name=identifier;
database_name : name=identifier;
entity_name : ( ( catalog=identifier '.' )? schema=identifier '.' )? name=identifier;
field_name : name=identifier;
function_name : name=identifier;
index_name : name=identifier;
macro_name : ( schema=identifier '.' )? name=identifier;
schema_name : name=identifier;
secret_name : name=identifier;
sequence_name : name=identifier;
table_name : ( ( catalog=identifier '.' )? schema=identifier '.' )? name=identifier;
type_name : ( ( catalog=identifier '.' )? schema=identifier '.' )? name=identifier;
view_name : ( ( catalog=identifier '.' )? schema=identifier '.' )? name=identifier;