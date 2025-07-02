parser grammar PostgresParser;

options { tokenVocab=PostgresLexer; }

batch : statement+ EOF;


statement : ddl_clause ;

ddl_clause : drop_clause ;

drop_clause : UESCAPE ;
    /*drop_access_method
    | drop_aggregate
    | drop_cast
    | drop_collation
    | drop_conversion
    | drop_database
    ;
    */