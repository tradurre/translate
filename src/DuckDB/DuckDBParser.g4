parser grammar DuckDBParser;

options { tokenVocab=DuckDBLexer; }

batch : statement+ EOF;

statement
    : //alter
    //| create
    //|
    drop
    | other
    //| security    
    ;

create
    : create_index
    ;

create_index : CREATE UNIQUE? INDEX if_not_exists? index_name ON table_name ;
create_schema : CREATE or_replace? SCHEMA if_not_exists? schema_name ;

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
    : empty_statement
    ;

empty_statement : ';' ;

cascade_restrict : CASCADE | RESTRICT ;
if_exists : IF EXISTS ;
if_not_exists : IF NOT EXISTS ;
or_replace : OR REPLACE ;


identifier
    : DOUBLE_QUOTED_IDENTIFER
    | IDENTIFIER 
    ;


function_name : name=identifier; // todo: 
index_name : name=identifier;
schema_name : name=identifier;
sequence_name : name=identifier; // todo: 
table_name : name=identifier; // todo:
type_name : name=identifier; // todo:
view_name : name=identifier; // todo: