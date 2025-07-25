parser grammar PostgresParser;

options { tokenVocab=PostgresLexer; }

batch : statement+ EOF;

statement : ddl_clause ;

ddl_clause : drop_clause ;

drop_clause : 
    /*drop_access_method
    | drop_aggregate
    | drop_cast
    | drop_collation
    | drop_conversion
    | drop_database    
    */
    drop_schema
    | drop_view ;

drop_schema: DROP SCHEMA if_exists? schema_name ( ',' schema_name )* cascade_restrict? ;
drop_view: DROP VIEW if_exists? view_name ( ',' view_name )* cascade_restrict? ;

cascade_restrict : CASCADE | RESTRICT ;

if_exists : IF EXISTS ;

identifier
    : IDENTIFIER
    ;


schema_name : name=identifier ;
view_name : ( schema=identifier '.' )? name=identifier ;