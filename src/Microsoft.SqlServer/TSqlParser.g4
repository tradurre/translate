parser grammar TSqlParser;

options { tokenVocab=TSqlLexer; }

batch : statement* EOF;

statement : 
    ddl_clause
    | go_statement
    | SEMICOLON
;

go_statement : GO count=DIGIT_IDENTIFIER? ;

ddl_clause
    : alter_clause
    | create_clause
    | drop_clause
    ;

alter_clause :
    alter_application_role
    | alter_server_role
    ;

alter_application_role : ALTER APPLICATION ROLE identifier WITH application_role_action ( ',' application_role_action )* ;
alter_server_role : ALTER SERVER ROLE role_name server_role_action ;

create_clause :
    // TODO: create_aggregate
    // TODO: create_rule
    create_synonym
    ;

// TODO: create_aggregate : CREATE AGGREGATE aggregate_name '(' VARIABLE_IDENTIFIER data_type ( ',' VARIABLE_IDENTIFIER data_type )* ')' RETURNS data_type EXTERNAL NAME external_name=qualified_identifier ;
// TODO: create_rule : CREATE RULE rule_name  AS search_condition ;
create_synonym : CREATE SYNONYM synonym_name FOR 
    (
        ( server=identifier '.' database=identifier? '.' schema=identifier? '.' )
        | ( database=identifier '.' schema=identifier? '.' )
        | ( schema=identifier '.' )
    )

    object_name=identifier
 ;

drop_clause :
    drop_aggregate
    | drop_application_role
    | drop_assembly
    | drop_asymmetric_key    
    | drop_availability_group
    | drop_broker_priority
    | drop_certificate
    | drop_column_encryption_key
    | drop_column_master_key
    | drop_contract
    | drop_credential
    | drop_cryptographic_provider
    | drop_database_audit_specification
    | drop_database_encryption_key
    | drop_database_scoped_credential
    | drop_database
    | drop_default
    | drop_endpoint
    | drop_event_notification
    | drop_event_session
    | drop_external_data_source
    | drop_external_file_format
    | drop_external_language
    | drop_external_library
    | drop_external_resource_pool
    | drop_external_table
    | drop_fulltext_catalog
    | drop_fulltext_index
    | drop_function
    // TODO: | drop_index_selective_xml
    | drop_index
    | drop_login
    | drop_master_key
    | drop_message_type
    | drop_partition_function
    | drop_partition_scheme
    | drop_procedure
    | drop_queue
    | drop_remote_service_binding
    | drop_resource_pool
    | drop_role
    | drop_route
    | drop_rule
    | drop_schema
    | drop_search_property_list
    | drop_security_policy
    | drop_sensitivity_classification
    | drop_sequence
    | drop_server_audit_specification
    | drop_server_audit
    | drop_server_role
    | drop_service
    | drop_signature
    | drop_statistics
    | drop_symmetric_key
    | drop_synonym
    | drop_table
    | drop_trigger
    | drop_type
    | drop_user
    | drop_view
    | drop_workload_group
    | drop_xml_schema_collection
    ;

drop_aggregate : DROP AGGREGATE if_exists? aggregate_name ;
drop_application_role : DROP APPLICATION ROLE application_role_name ;
drop_assembly : DROP ASSEMBLY if_exists? assembly_name ( ',' assembly_name )* ( WITH NO DEPENDENTS )? ;
drop_asymmetric_key : DROP ASYMMETRIC KEY asymmetric_key_name ( REMOVE PROVIDER KEY )? ;
drop_availability_group : DROP AVAILABILITY GROUP group_name ;
drop_broker_priority : DROP BROKER PRIORITY conversation_name ; 
drop_certificate : DROP CERTIFICATE certificate_name ;
drop_column_encryption_key : DROP COLUMN ENCRYPTION KEY key_name ;
drop_column_master_key : DROP COLUMN MASTER KEY key_name ;
drop_contract : DROP CONTRACT contract_name ;
drop_credential : DROP CREDENTIAL credential_name ;
drop_cryptographic_provider : DROP CRYPTOGRAPHIC PROVIDER provider_name ;
drop_database_audit_specification : DROP DATABASE AUDIT SPECIFICATION audit_specification_name ;
drop_database_encryption_key : DROP DATABASE ENCRYPTION KEY ;
drop_database_scoped_credential : DROP DATABASE SCOPED CREDENTIAL credential_name ;
drop_database : DROP DATABASE if_exists? database_name ( ',' database_name )* ;
drop_default : DROP DEFAULT if_exists? default_name ( ',' default_name )* ;
drop_endpoint : DROP ENDPOINT endpoint_name ;
drop_event_notification : DROP EVENT NOTIFICATION event_notification_name ( ',' event_notification_name )* ON ( SERVER | DATABASE | ( QUEUE queue_name ) ) ;
drop_event_session : DROP EVENT SESSION event_session_name ON SERVER ;
drop_external_data_source : DROP EXTERNAL DATA SOURCE data_source_name ;
drop_external_file_format : DROP EXTERNAL FILE FORMAT file_format_name ;
drop_external_language : DROP EXTERNAL LANGUAGE language_name ;
drop_external_library : DROP EXTERNAL LIBRARY library_name owner_name? ;
drop_external_resource_pool : DROP EXTERNAL RESOURCE POOL pool_name ;
drop_external_table : DROP EXTERNAL TABLE external_table_name ;
drop_fulltext_catalog : DROP FULLTEXT CATALOG catalog_name ;
drop_fulltext_index : DROP FULLTEXT INDEX ON table_name ;
drop_fulltext_stoplist : DROP FULLTEXT STOPLIST stoplist_name ;
drop_function : DROP FUNCTION if_exists? function_name ( ',' function_name )* ;
drop_index : DROP INDEX if_exists? ( index_on_clause | index_name ) ( ',' ( index_on_clause | index_name ) )* ;
drop_index_selective : DROP INDEX index_name ON table_name ( WITH drop_index_option (',' drop_index_option )* )? ;
drop_login : DROP LOGIN logon_name ;
drop_master_key : DROP MASTER KEY ;
drop_message_type : DROP MESSAGE TYPE message_type_name ;
drop_partition_function : DROP PARTITION FUNCTION partition_function_name ;
drop_partition_scheme : DROP PARTITION SCHEME partition_scheme_name ;
drop_procedure : DROP ( PROC | PROCEDURE ) if_exists? procedure_name ( ',' procedure_name )* ;
drop_queue : DROP QUEUE queue_name ;
drop_remote_service_binding : DROP REMOTE SERVICE BINDING binding_name ;
drop_resource_pool : DROP RESOURCE POOL pool_name ;
drop_role : DROP ROLE if_exists? role_name ;
drop_route : DROP ROUTE route_name ;
drop_rule : DROP RULE if_exists? rule_name ( ',' rule_name )* ;
drop_schema : DROP SCHEMA if_exists? schema_name ;
drop_search_property_list : DROP SEARCH PROPERTY LIST search_list_name ;
drop_security_policy : DROP SECURITY POLICY if_exists? security_policy_name ;
drop_sensitivity_classification : DROP SENSITIVITY CLASSIFICATION FROM ( schemaname=identifier )? tablename=identifier '.' column_name ;
drop_sequence : DROP SEQUENCE if_exists? sequence_name ( ',' sequence_name )* ;
drop_server_audit_specification : DROP SERVER AUDIT SPECIFICATION audit_specification_name ;
drop_server_audit : DROP SERVER AUDIT audit_specification_name ;
drop_server_role : DROP SERVER ROLE role_name ;
drop_service : DROP SERVICE service_name ;
drop_signature : DROP COUNTER? SIGNATURE FROM ( assembly_name | function_name | procedure_name | trigger_name ) BY ( ( CERTIFICATE certificate_name ) | ( ASYMMETRIC KEY key_name ) ) ( ',' ( ( CERTIFICATE certificate_name ) | ( ASYMMETRIC KEY key_name ) ) )* ;
drop_statistics : DROP STATISTICS statistics_name ( ',' statistics_name )* ;
drop_symmetric_key : DROP SYMMETRIC KEY key_name ( REMOVE PROVIDER KEY )? ;
drop_synonym : DROP SYNONYM if_exists? synonym_name ;
drop_table : DROP TABLE if_exists? table_name ( ',' table_name )* ;
drop_trigger : DROP TRIGGER if_exists? trigger_name ( ',' trigger_name )* ( ON ( DATABASE | ( ALL SERVER ) ) )? ;
drop_type : DROP TYPE if_exists? type_name ;
drop_user : DROP USER if_exists? user_name ;
drop_view : DROP VIEW if_exists view_name ( ',' view_name )* ;
drop_workload_group : DROP WORKLOAD GROUP group_name ;
drop_xml_schema_collection : DROP XML SCHEMA COLLECTION collection_name ;


data_type
    : BIGINT
    | BIT
    | CURSOR
    | DATE
    | DATETIME
    | ( DOUBLE PRECISION )
    | GEOGRAPHY
    | GEOMETRY
    | HIERARCHYID 
    | IMAGE
    | INT
    | INTEGER
    | JSON
    | MONEY
    | ( ( NATIONAL TEXT) | NTEXT )
    | ROWVERSION
    | SMALLDATETIME
    | SMALLINT
    | SMALLMONEY
    | SQL_VARIANT
    | TEXT
    | TIMESTAMP
    | TINYINT
    | UNIQUEIDENTIFIER

    // DATATYPE [( precision )]
    | ( ( BINARY | CHAR | CHARACTER | DATETIME2 | DATETIMEOFFSET | FLOAT 
            | ( NATIONAL ( CHAR | CHARACTER ) VARYING? ) | NCHAR | NVARCHAR
            | REAL | TIME | VECTOR ) precision_clause? )
    
    // DATATYPE [( precision, [scale] )]
    | ( ( DEC | DECIMAL | NUMERIC ) precision_and_scale_clause? )

    // DATATYPE [( precision | MAX )]
    | ( ( ( BINARY VARYING ) | ( ( CHAR | CHARACTER ) VARYING )
            | VARBINARY | VARCHAR ) precision_or_max_clause? )

    | TABLE // TODO:

    | ( XML ( ( CONTENT | DOCUMENT )? ( schema=identifier '.' )? name=identifier )? )
    ;


precision_clause : '(' prec=DIGIT_IDENTIFIER ')' ;
precision_or_max_clause : '(' prec=DIGIT_IDENTIFIER | MAX ')' ;
precision_and_scale_clause : '(' prec=DIGIT_IDENTIFIER ( ',' scale=DIGIT_IDENTIFIER )? ')' ;

application_role_action
    : ( DEFAULT_SCHEMA '=' identifier )
    | ( NAME '=' identifier )
    | ( PASSWORD '=' SINGLE_QUOTED_IDENTIFIER )    
    ;

clustered_index_option :
    ( MAXDOP '=' DIGIT_IDENTIFIER )
    | ( MOVE TO ( ( partition_scheme_name '(' column_name ')' ) | filegroup_name | DEFAULT ) ( FILESTREAM_ON partition_scheme_name | filegroup_name | DEFAULT )? )
    | ( ONLINE '=' on_off_clause )
    ;

drop_index_option : ( MAXDOP '=' DIGIT_IDENTIFIER ) | ( ONLINE '=' on_off_clause ) ;

if_exists : IF EXISTS ;

index_on_clause : index_name ON table_name ( WITH clustered_index_option )? ;

on_off_clause : OFF | ON ;

server_role_action : ( ( ADD | DROP ) MEMBER identifier ) | ( WITH NAME '=' identifier ) ;


identifier :
    IDENTIFIER
    | BRACKETED_IDENTIFIER
    | DOUBLE_QUOTED_IDENTIFER
    | SINGLE_QUOTED_IDENTIFIER
    | TEMPORARY_IDENTIFIER
    ;

aggregate_name : ( schema=identifier '.' )? name=identifier ;
application_role_name : name=identifier ;
assembly_name : name=identifier ;
asymmetric_key_name : name=identifier ;
audit_specification_name : name=identifier ;

binding_name : name=identifier ;

catalog_name : name=identifier ;
certificate_name : name=identifier ;
collection_name : ( schema=identifier '.' )? name=identifier ;
column_name : name=identifier ;
contract_name : name=identifier ;
conversation_name : name=identifier ;
credential_name : name=identifier ;

database_name : name=identifier ;
data_source_name : name=identifier ;
default_name : ( schema=identifier '.' )? name=identifier ;

endpoint_name : name=identifier ;
event_notification_name : name=identifier ;
event_session_name : name=identifier ;
external_table_name : ( ( database=identifier '.' )? schema=identifier '.' )? name=identifier ;

file_format_name : name=identifier ;
filegroup_name : name=identifier ;
function_name : ( schema=identifier '.' )? name=identifier ;

group_name : name=identifier ;

index_name : name=identifier ;

key_name : name=identifier ;

language_name : name=identifier ;
library_name : name=identifier ;
logon_name : name=identifier ;

message_type_name : name=identifier ;

owner_name : name=identifier ;

partition_function_name : name=identifier ;
partition_scheme_name : name=identifier ;
pool_name : name=identifier ;
procedure_name : ( schema=identifier '.' )? name=identifier ;
provider_name : name=identifier ;

queue_name : ( ( database=identifier '.' )?  schema=identifier '.' )? name=identifier ;

role_name : name=identifier ;
route_name : name=identifier ;
rule_name : ( schema=identifier '.' )? name=identifier ;

schema_name : name=identifier ;
search_list_name : name=identifier ;
security_policy_name : ( schema=identifier '.' )? name=identifier ;
sequence_name : ( schema=identifier '.' )? name=identifier ;
service_name : name=identifier ;
statistics_name : name=identifier ;
stoplist_name : name=identifier ;
synonym_name : ( schema=identifier '.' )? name=identifier ;

table_name : ( ( database=identifier '.' )?  schema=identifier '.' )? name=identifier ;
trigger_name : ( schema=identifier '.' )? name=identifier ;
type_name : ( schema=identifier '.' )? name=identifier ;

view_name : ( ( database=identifier '.' )?  schema=identifier '.' )? name=identifier ;

user_name : name=identifier ;

/*
statement
    : 
        | alter_table_statement
    
    | begin_end_statement
    | break_statement

    | create_aggregate_statement
    | create_application_role_statement
    | create_assembly_statement
    | create_asymmetric_key_statement
    | create_columnstore_index_statement
    | create_index_statement
    | create_master_key_statement
    | create_role_statement
    | create_schema_statement
    | create_server_role_statement
    | create_service_statement
    | create_symmetric_key_statement
    | create_synonym_statement
    | create_table_statement
    | create_xml_schema_collection_statement
    
    | disable_trigger_statement


    | empty_statement
    | enable_trigger_statement

    | get_conversation_group_statement
    | go_statement
    | goto_statement
    
    | if_statement
    
    | label_statement
    
    | receive_statement
    | return_statement
    
    | throw_statement
    | try_catch_statement
    
    | waitfor_statement
    | while_statement
    ;


alter_table_statement : ALTER TABLE name=qualified_identifier    
    (
        ( ALTER COLUMN ) // todo: finish
        | ( ADD 
            ( alter_table_column_constraint
            | alter_table_column_definition
            )
          )
        
        
        
        // todo: finish
        | DROP // todo: finish
        | WITH ( CHECK | NOCHECK ) // todo: finish
        | ( ( ENABLE | DISABLE ) TRIGGER ( ALL | ( trigger_name=qualified_identifier ( ',' trigger_name=qualified_identifier )* ) ) )
        | SWITCH // todo: finish
        | SET  // todo: finish
        | REBUILD  // todo: finish
        | ( SET '(' LOCK_ESCALATION '=' ( AUTO | DISABLE | TABLE ) ')' )
    ) 
;

alter_table_column_constraint : ( CONSTRAINT name=qualified_identifier )? null_notnull? column_constraint? ;

alter_table_column_definition : column_name=qualified_identifier data_type column_definition_option* ;



begin_end_statement : BEGIN statement+ END ;
break_statement : BREAK ;


create_application_role_statement : CREATE APPLICATION ROLE application_role_name=qualified_identifier WITH PASSWORD '=' password=SINGLE_QUOTED_IDENTIFIER ( DEFAULT_SCHEMA '=' schema_name=qualified_identifier )? ;
create_assembly_statement : CREATE ASSEMBLY assembly_name=qualified_identifier
    authorization_clause?
    FROM ( SINGLE_QUOTED_IDENTIFIER | BINARY_IDENTIFIER )
    ( WITH PERMISSION_SET '=' ( EXTERNAL_ACCESS | SAFE | UNSAFE ) )?
    ;
create_asymmetric_key_statement : CREATE ASYMMETRIC KEY key_name=qualified_identifier
    ( AUTHORIZATION database_principal_name=qualified_identifier )?
    ( FROM asssembly_key_source )?
    ( WITH assembly_key_option )?
    ( ENCRYPTION BY PASSWORD '=' SINGLE_QUOTED_IDENTIFIER )?
 ;

create_columnstore_index_statement : CREATE clustered_non_clause? COLUMNSTORE INDEX name=qualified_identifier ON target=qualified_identifier ( '(' source_column=qualified_identifier (',' source_column=qualified_identifier )* ')' )?
    ( 
        ( ON ( DOUBLE_QUOTED_IDENTIFIER | particion_schema_name=qualified_identifier ( '(' column=qualified_identifier ')' )? ) )
        | ( ORDER '(' column=qualified_identifier (',' column=qualified_identifier )* ')')
        | ( WITH '(' column_store_index_options ( ',' column_store_index_options )* ')' )        
    )*
    ;

create_index_statement : CREATE UNIQUE? clustered_non_clause? INDEX name=qualified_identifier
    ON qualified_identifier 
    // TODO: FINISH
    ;


create_master_key_statement : CREATE MASTER KEY ( ENCRYPTION BY PASSWORD '=' SINGLE_QUOTED_IDENTIFIER )? ';'? ;
create_role_statement : CREATE ROLE qualified_identifier authorization_with_name? ;
create_schema_statement : CREATE SCHEMA ( qualified_identifier | qualified_identifier | ( qualified_identifier AUTHORIZATION qualified_identifier ) ) ';'? ; //TODO: schema_elements ;
create_server_role_statement : CREATE SERVER ROLE role_name=qualified_identifier authorization_clause? ;
create_service_statement : CREATE SERVICE service_name=qualified_identifier authorization_clause? ON QUEUE queue_name=qualified_identifier ( ( contract_name=qualified_identifier ( ',' contract_name=qualified_identifier )* ) | DEFAULT )? ;
create_symmetric_key_statement : CREATE SYMMETRIC KEY key_name=qualified_identifier
    authorization_clause?
    ( FROM PROVIDER provider_name=qualified_identifier )?
    WITH ( ( symmetric_key_option ( ',' symmetric_key_option )* ) | ( ENCRYPTION BY symmetric_key_encryption_option ( ',' symmetric_key_encryption_option )* ) )
 ;
create_synonym_statement : CREATE SYNONYM synonym_name=qualified_identifier FOR targe_name=qualified_identifier ;
create_table_statement : CREATE TABLE table_name=qualified_identifier ( AS FILETABLE )?
    '(' table_column_clause ( ',' table_column_clause )* ( PERIOD FOR SYSTEM_TIME '(' start_column_name=qualified_identifier ',' end_column_name=qualified_identifier ')' )? ')'
    table_configuration_option*
    ;
create_xml_schema_collection_statement : CREATE XML SCHEMA COLLECTION qualified_identifier AS expression ;

disable_trigger_statement : DISABLE TRIGGER ( ( trigger_name=qualified_identifier ( ',' trigger_name=qualified_identifier )* ) | ALL ) ON ( qualified_identifier | DATABASE | ( ALL SERVER ) ) ;



empty_statement : ';' ;
enable_trigger_statement : ENABLE TRIGGER ( ( trigger_name=qualified_identifier ( ',' trigger_name=qualified_identifier )* ) | ALL ) ON ( qualified_identifier | DATABASE | ( ALL SERVER ) ) ;

get_conversation_group_statement : GET CONVERSATION GROUP ( SINGLE_QUOTED_IDENTIFIER | VARIABLE_IDENTIFIER ) FROM qualified_identifier ;
goto_statement : GOTO label=identifier ;

if_statement : IF search_condition THEN ( statement ';'? ) else_if_statement* else_statement? END IF ;

label_statement : label=identifier ':' ;

receive_statement : RECEIVE ( TOP '(' DIGIT_IDENTIFIER ')' )? // TODO: Complete
    ;
return_statement : RETURN expression? ;

throw_statement
    : THROW
    (
        ( ( DIGIT_IDENTIFIER | VARIABLE_IDENTIFIER )
        ',' ( SINGLE_QUOTED_IDENTIFIER | VARIABLE_IDENTIFIER )
        ',' ( DIGIT_IDENTIFIER | VARIABLE_IDENTIFIER )
        )
    )?
    ;

try_catch_statement
    : BEGIN TRY
        statement+
    END TRY
    BEGIN CATCH
        statement+
    END CATCH ;

waitfor_statement : WAITFOR 
    (
        ( DELAY SINGLE_QUOTED_IDENTIFIER )
        | ( TIME SINGLE_QUOTED_IDENTIFIER )
        | ( ( receive_statement | get_conversation_group_statement ) ( ',' TIMEOUT DIGIT_IDENTIFIER )? )
    )
    ;

while_statement : WHILE ( statement+ | break_statement | CONTINUE ) ;


asc_desc_clause : ASC | DESC ;
assembly_key_option
    : ( ALGORITHM '=' ( RSA_4096 | RSA_3072 | RSA_2048 | RSA_1024 | RSA_512 ) )
    | ( CREATION_DISPOSITION '=' ( ( CREATE NEW ) | OPEN_EXISTING ) )
    | ( PROVIDER_KEY_NAME '=' SINGLE_QUOTED_IDENTIFIER )    
    ;
asssembly_key_source
    :  ( ASSEMBLY assembly_name=qualified_identifier )
    | ( EXECUTABLE FILE '=' SINGLE_QUOTED_IDENTIFIER )
    | ( FILE '=' SINGLE_QUOTED_IDENTIFIER )
    | ( PROVIDER provider_name=qualified_identifier )
    ;
authorization_clause : AUTHORIZATION owner_name=qualified_identifier ;
authorization_with_name : AUTHORIZATION qualified_identifier ;

cascade_action_clause : ( CASCADE | ( NO ACTION ) | ( SET DEFAULT ) | ( SET NULL ) );
case_expression : CASE expression? when_clause+ ( ELSE expression )? END ;
check_constraint : CHECK not_for_replication? '(' expression ')' ;
clustered_non_clause : CLUSTERED | NONCLUSTERED ;
coalesce_expression : COALESCE '(' expressions ')' ;
column_constraint : ( CONSTRAINT constraint_name=qualified_identifier )?
    check_constraint
    | column_foreign_constraint_clause
    | column_primary_unique_constraint_clause
    ;

column_definition : column_name=qualified_identifier data_type column_definition_option* ;

column_definition_option
    : ( COLLATE collation_name=qualified_identifier )
    | column_constraint
    | column_index
    | ( ( CONSTRAINT constraint_name=qualified_identifier )? DEFAULT expression )
    | ( ( CONSTRAINT constraint_name=qualified_identifier )? null_notnull )
    | ( ENCRYPTED WITH '(' COLUMN_ENCRYPTION_KEY '=' key_name=qualified_identifier ',' ENCRYPTION_TYPE '=' ( DETERMINISTIC | RANDOMIZED ) ',' ALGORITHM '=' 'AEAD_AES_256_CBC_HMAC_SHA_256' ')' )
    | FILESTREAM
    | ( GENERATED ALWAYS AS ( ROW | TRANSACTION_ID | SEQUENCE_NUMBER) ( START | END)  HIDDEN_? )
    | identity_clause
    | ( MASKED WITH '(' FUNCTION '=' SINGLE_QUOTED_IDENTIFIER ')' )
    | ( NOT FOR REPLICATION )
    | ROWGUIDCOL
    | SPARSE
    ;

column_foreign_constraint_clause : ( FOREIGN KEY )? REFERENCES table_name=qualified_identifier ( '(' column_name=qualified_identifier ')' )? ( not_for_replication | on_delete_action | on_update_action )* ;

column_index
    : INDEX index_name=qualified_identifier clustered_non_clause?
    ( WITH '(' index_option ( ',' index_option )*   ')' )?
    ( ON ( ( partition_scheme_name=qualified_identifier '(' column_name=qualified_identifier ')' ) | filegroup_name=qualified_identifier | DEFAULT ) )?
    filestream_on_clause?
    ;
column_primary_unique_constraint_clause : ( ( PRIMARY KEY ) | UNIQUE ) clustered_non_clause?
    ( column_name=qualified_identifier ( ',' column_name=qualified_identifier )* )?
    with_fill_factor_clause?
    on_partition_clause?
    ;

column_set_definition : column_set_name=qualified_identifier XML COLUMN_SET FOR ALL_SPARSE_COLUMNS ;

column_store_index_options
    : ( DATA_COMPRESSION '=' ( COLUMNSTORE | COLUMNSTORE_ARCHIVE ) on_partition_clause? )
    | ( DROP_EXISTING '=' on_off_clause )
    | ( COMPRESSION_DELAY '=' ( DIGIT_IDENTIFIER MINUTES? ) )
    | ( MAXDOP '=' DIGIT_IDENTIFIER )
    | ( ONLINE '=' on_off_clause )
    ;

computed_column_definition : column_name=qualified_identifier AS expression ( PERSISTED ( NOT NULL )? )?
    ( CONSTRAINT constraint_name=qualified_identifier )?
    ( table_constraint_primary_unique | table_constraint_foreign | check_constraint )?
    ;

constant
    : EMPTY_IDENTIFIER
    | SINGLE_QUOTED_IDENTIFIER
    // TODO: | ID_DOUBLE_QUOTE
    // TODO: | ID_BINARY
    | DIGIT_IDENTIFIER
    // TODO: | sign? ID_REAL
    // TODO: | sign? ID_FLOAT
    // TODO: | sign? ID_MONEY
    ;

constant_expression
    : '(' constant_expression ')'
    | constant
    | NULL
    ;

data_type
    : BIGINT
    | BIT
    | ( BINARY precision_clause? )
    | ( ( ( BINARY VARYING ) | VARBINARY ) ( precision_clause | max_clause )? )
    | ( ( CHAR | CHARACTER ) precision_clause? )
    | ( ( ( ( CHARACTER | CHAR )  VARYING ) | VARCHAR ) ( precision_clause | max_clause )? )
    // TODO: CURSOR
    | DATE
    | DATETIME
    | DATETIME2
    | ( DATETIMEOFFSET precision_clause? )
    | ( ( ( DEC | DECIMAL | NUMBER | NUMERIC ) ) precision_scale_class? )
    | ( DOUBLE PRECISION precision_clause? )
    | ( FLOAT precision_clause? )
    | GEOGRAPHY
    | GEOMETRY
    | HIERARCHYID
    | IMAGE
    | ( INTEGER | INT )
    | JSON
    | MONEY
    | ( ( ( NATIONAL ( CHARACTER | CHAR ) ) | NCHAR ) precision_clause? )
    | ( ( ( NATIONAL ( CHARACTER | CHAR ) VARYING ) | NVARCHAR ) ( precision_clause | max_clause )? )
    | ( NATIONAL TEXT | NTEXT )
    | REAL
    | ROWVERSION
    | SMALLDATETIME
    | SMALLINT
    | SMALLMONEY
    | SQL_VARIANT
    | TABLE // TODO: Finish the table type 
    | TEXT
    | ( TIME precision_clause? )
    | TIMESTAMP
    | TINYINT
    | UNIQUEIDENTIFIER
    | ( VECTOR '(' dimension=DIGIT_IDENTIFIER ')' )
    | XML ( '(' ( CONTENT | DOCUMENT )? qualified_identifier ')' )?
    ;

else_statement : ELSE ( statement ';'? ) ;

else_if_statement : ELSEIF search_condition THEN ( statement ';'? ) ;

expression  :
    (
        case_expression
        | coalesce_expression
        | constant
        | nullif_expression
        //constant_expression
        // TODO: | functions
        //| column_name
        //| ID_VARIABLE
        //| '(' expression ')'
        // TODO: | '(' subquery ')'
        //| urninary_operators expression
        //| expression arithmetic_operators expression
        //| expression bitwise_operators expression
        //| expression comparison_operators expression
        //| expression logical_operators expression
    )
    //( COLLATE collation_name )?
    ;

expressions : expression ( COMMA expression )* ;

filestream_on_clause : ( FILESTREAM_ON ( DOUBLE_QUOTED_IDENTIFIER | SINGLE_QUOTED_IDENTIFIER | partition_scheme_name=qualified_identifier ) ) ;

identity_clause : IDENTITY ( '(' seed=DIGIT_IDENTIFIER ',' increment=DIGIT_IDENTIFIER ')' )?;

index_option
    : ( ALLOW_PAGE_LOCKS '=' on_off_clause )
    | ( ALLOW_ROW_LOCKS '=' on_off_clause )
    | ( COMPRESSION_DELAY '=' DIGIT_IDENTIFIER MINUTES? )
    | ( DATA_COMPRESSION '=' ( NONE | ROW | PAGE | COLUMNSTORE | COLUMNSTORE_ARCHIVE ) on_partition_clause? )
    | ( FILLFACTOR '=' DIGIT_IDENTIFIER )
    | ( IGNORE_DUP_KEY '=' on_off_clause )
    | ( OPTIMIZE_FOR_SEQUENTIAL_KEY '=' on_off_clause )
    | ( PAD_INDEX '=' on_off_clause )
    | ( STATISTICS_INCREMENTAL '=' on_off_clause )
    | ( STATISTICS_NORECOMPUTE '=' on_off_clause )
    | ( XML_COMPRESSION '=' on_off_clause on_partition_clause? )
    ;

ledger_option : LEDGER_VIEW '=' ledger_view_name=qualified_identifier ( '(' ledger_view_option ( ',' ledger_view_option )* ')' )?  ( APPEND_ONLY '=' on_off_clause )? ;
ledger_view_option
    : ( OPERATION_TYPE_COLUMN_NAME '=' column_name=qualified_identifier )
    | ( OPERATION_TYPE_DESC_COLUMN_NAME '=' column_name=qualified_identifier )
    | ( SEQUENCE_NUMBER_COLUMN_NAME '=' column_name=qualified_identifier )
    | ( TRANSACTION_ID_COLUMN_NAME '=' column_name=qualified_identifier )
    ;

max_clause : '(' MAX ')' ;

not_for_replication : NOT FOR REPLICATION ;
null_notnull : NOT? NULL ;
nullif_expression : NULLIF '(' expression ',' expression ')' ;

on_delete_action : ON DELETE cascade_action_clause ;

on_partition_clause : ON PARTITIONS '(' ( DIGIT_IDENTIFIER | partition_range_clause ) ( ',' ( DIGIT_IDENTIFIER | partition_range_clause ) )* ')' ;
on_update_action : ON UPDATE cascade_action_clause ;
ordered_column : column_name=qualified_identifier asc_desc_clause? ;

partition_range_clause : DIGIT_IDENTIFIER TO DIGIT_IDENTIFIER ;
precision_clause : '(' precision=DIGIT_IDENTIFIER ')';
precision_scale_class : '(' precision=DIGIT_IDENTIFIER ( ',' scale=DIGIT_IDENTIFIER )? ')' ;
predicate : 
    // TODO: EXISTS '(' subquery ')'
    // TODO: | 
    expression comparison_operators expression ( '(' CASESPECIFIC ')' )?
    | expression NOT? BETWEEN expression AND expression
    // TODO: | expression IS? NOT? IN '(' ( subquery | expressions ) ')'
    // TODO: | '(' select_elements ')' IS? NOT? IN '(' subquery ')'
    | expression NOT? LIKE ( expression | ( ( ALL | ANY | SOME )? '(' expressions ')' ) ) ( ESCAPE expression )?
    | expression IS null_notnull
    // TODO: | predicate_overlaps
    // TODO: | function_end
    | '(' search_condition ')' 
    ;
search_condition : search_condition_and ( OR search_condition_and )* ;
search_condition_and : search_condition_not ( AND search_condition_not )* ;
search_condition_not : NOT? predicate ;
symmetric_key_encryption_option
    : ( ASYMMETRIC KEY assymmetric_key_name=qualified_identifier )
    | ( CERTIFICATE certificate_name=qualified_identifier )
    | ( PASSWORD '=' SINGLE_QUOTED_IDENTIFIER )
    | ( SYMMETRIC KEY symmetric_key_name=qualified_identifier )
    ;
symmetric_key_option
    : ( ALGORITHM '=' ( DES | TRIPLE_DES | TRIPLE_DES_3KEY | RC2 | RC4 | RC4_128 | DESX | AES_128 | AES_192 | AES_256 ) )
    | ( CREATION_DISPOSITION '=' ( CREATE_NEW | OPEN_EXISTING ) )
    | ( IDENTITY_VALUE '=' SINGLE_QUOTED_IDENTIFIER )
    | ( KEY_SOURCE '=' SINGLE_QUOTED_IDENTIFIER )
    | ( PROVIDER_KEY_NAME '=' SINGLE_QUOTED_IDENTIFIER )
    ;

table_column_clause
    :  column_definition
    | computed_column_definition
    | column_set_definition
    | table_constraint
    | table_index
    ;

table_configuration_option :
    ( ON ( DOUBLE_QUOTED_IDENTIFIER | SINGLE_QUOTED_IDENTIFIER | ( partition_scheme_name=qualified_identifier '(' partition_column_name=qualified_identifier ')' ) ) )
    | filestream_on_clause
    | ( TEXTIMAGE_ON ( DOUBLE_QUOTED_IDENTIFIER | SINGLE_QUOTED_IDENTIFIER ) )
    | ( WITH '(' table_option ( ',' table_option )* ')' )
    ;

table_constraint : ( CONSTRAINT constraint_name=qualified_identifier )? ( table_constraint_primary_unique | table_constraint_foreign | check_constraint ) ;

table_constraint_foreign : 
    FOREIGN KEY '(' column_name=qualified_identifier ( ',' column_name=qualified_identifier )* ')'
        REFERENCES table_name=qualified_identifier '(' column_name=qualified_identifier ( ',' column_name=qualified_identifier )* ')'
        ( on_delete_action | on_update_action )*
    ;

table_constraint_primary_unique
    : ( ( PRIMARY KEY ) | UNIQUE ) clustered_non_clause? '(' ordered_column ( ',' ordered_column )* ')'
        ( WITH ( ( FILLFACTOR '=' fill_factor=DIGIT_IDENTIFIER ) | ( '(' index_option ( ',' index_option )* ')' ) ) )?
        ( ON qualified_identifier '(' ( partition_column_name=qualified_identifier | DOUBLE_QUOTED_IDENTIFIER | DIGIT_IDENTIFIER ) ')' )
        ;

table_index
    : INDEX index_name=qualified_identifier
    (
        ( UNIQUE? clustered_non_clause? '(' ordered_column ( ',' ordered_column )* ')' )
        | ( CLUSTERED COLUMNSTORE ( ORDER '(' column_name=qualified_identifier ( ',' column_name=qualified_identifier )* ')' )? )
        | ( NONCLUSTERED? COLUMNSTORE '(' column_name=qualified_identifier ( ',' column_name=qualified_identifier )* ')' )
    )
    table_index_option*
    ;

table_index_option
    : ( INCLUDE '(' column_name=qualified_identifier ( ',' column_name=qualified_identifier )* ')' )
    | ( WHERE search_condition )
    | ( WITH '(' index_option (',' index_option )* ')' )
    | on_partition_clause
    | filestream_on_clause
    ;

table_option
    : ( DATA_COMPRESSION '=' ( NONE | ROW | PAGE ) on_partition_clause? )
    | ( DATA_DELETION '=' ON '(' FILTER_COLUMN '=' qualified_identifier ',' RETENTION_PERIOD '=' ( ( DIGIT_IDENTIFIER ( DAY | DAYS | WEEK | WEEKS | MONTH | MONTHS | YEAR | YEARS ) ) | INFINITE ) ')' )
    | ( FILETABLE_COLLATE_FILENAME '=' qualified_identifier )
    | ( FILETABLE_DIRECTORY '=' director_name=qualified_identifier )
    | ( FILETABLE_FULLPATH_UNIQUE_CONSTRAINT_NAME '=' qualified_identifier )
    | ( FILETABLE_PRIMARY_KEY_CONSTRAINT_NAME '=' qualified_identifier )
    | ( FILETABLE_STREAMID_UNIQUE_CONSTRAINT_NAME '=' qualified_identifier )
    | ( LEDGER '=' ( OFF | ON ( '(' ledger_option (',' ledger_option )* ')' )?  ) )
    | ( REMOTE_DATA_ARCHIVE '=' ( ( OFF '(' MIGRATION_STATE '=' PAUSED ')' ) | ( ON ('(' table_stretch_option (',' table_stretch_option )* ')') ) ) )
    | ( SYSTEM_VERSIONING '=' ON ( '(' HISTORY_TABLE '=' qualified_identifier ( ',' DATA_CONSISTENCY_CHECK '=' on_off_clause )? ')' )? )
    | ( XML_COMPRESSION '=' on_off_clause on_partition_clause? )
    ;

table_stretch_option :  ( FILTER_PREDICATE '=' ( NULL | predicate ) ',' )? MIGRATION_STATE '=' ( INBOUND | OUTBOUND | PAUSED ) ;

when_clause : WHEN ( expression | search_condition ) THEN expression ;
with_fill_factor_clause : WITH ( ( FILLFACTOR '=' DIGIT_IDENTIFIER ) | ( '(' index_option ( ',' index_option )* ')' ) ) ;


comparison_operators : EQ | GT | GTE | LT | LTE | NEQ | NLT | NGT ;


qualified_identifier : identifier ( '.' identifier )* ;

identifier
    : IDENTIFIER
    | BRACKETED_IDENTIFIER
    | DOUBLE_QUOTED_IDENTIFIER
    | SINGLE_QUOTED_IDENTIFIER
    | ( BRACKET_L reserved_keywords BRACKET_R )
    ;

reserved_keywords
    : ADD | ALL | ALTER | AND | ANY | AS | ASC | AUTHORIZATION
    | BACKUP | BEGIN | BETWEEN | BREAK | BROWSE | BULK | BY
    | CASCADE | CASE | CHECK | CHECKPOINT | CLOSE | CLUSTERED | COALESCE | COLLATE | COLUMN | COMMIT | COMPUTE | CONSTRAINT | CONTAINS | CONTAINSTABLE | CONTINUE | CONVERT
        | CREATE | CROSS | CURRENT | CURRENT_DATE | CURRENT_TIME | CURRENT_TIMESTAMP | CURRENT_USER | CURSOR
    | DATABASE | DBCC | DEALLOCATE | DECLARE | DEFAULT | DELETE | DENY | DESC | DISK | DISTINCT | DISTRIBUTED | DOUBLE | DROP | DUMP
    | ELSE | END | ERRLVL | ESCAPE | EXCEPT | EXEC | EXECUTE | EXISTS | EXIT | EXTERNAL
    | FETCH | FILE | FILLFACTOR | FOR | FOREIGN | FREETEXT | FREETEXTTABLE | FROM | FULL | FUNCTION
    | GOTO | GRANT | GROUP
    | HAVING | HOLDLOCK
    | IDENTITY | IDENTITY_INSERT | IDENTITYCOL | IF | IN | INDEX | INNER | INSERT | INTERSECT | INTO | IS
    | JOIN
    | KEY | KILL
    | LEFT | LIKE | LINENO | LOAD
    | MERGE
    | NATIONAL | NOCHECK | NONCLUSTERED | NOT | NULL | NULLIF
    | OF | OFF | OFFSETS | ON | OPEN | OPENDATASOURCE | OPENQUERY | OPENROWSET | OPENXML | OPTION | OR | ORDER | OUTER | OVER
    | PERCENT | PIVOT | PLAN | PRECISION | PRIMARY | PRINT | PROC | PROCEDURE | PUBLIC
    | RAISERROR | READ | READTEXT | RECONFIGURE | REFERENCES | REPLICATION | RESTORE | RESTRICT | RETURN | REVERT | REVOKE | RIGHT | ROLLBACK | ROWCOUNT | ROWGUIDCOL | RULE | SAVE
    | SCHEMA | SECURITYAUDIT | SELECT | SEMANTICKEYPHRASETABLE | SEMANTICSIMILARITYDETAILSTABLE | SEMANTICSIMILARITYTABLE | SESSION_USER | SET | SETUSER | SHUTDOWN | SOME | STATISTICS | SYSTEM_USER
    | TABLE | TABLESAMPLE | TEXTSIZE | THEN | TO | TOP | TRAN | TRANSACTION | TRIGGER | TRUNCATE | TRY_CONVERT | TSEQUAL
    | UNION | UNIQUE | UNPIVOT | UPDATE | UPDATETEXT | USE | USER
    | VALUES | VARYING | VIEW
    | WAITFOR | WHEN | WHERE | WHILE | WITH | WITHIN GROUP | WRITETEXT
    ;

/*

all_distinct_clause : ALL | DISTINCT ;

ignore_respect_nulls_clause : ( IGNORE | RESPECT ) NULLS ;

sorted_column_name : column_name asc_desc_clause? ;

sorted_column_names : sorted_column_name ( ',' sorted_column_name )* ;

arithmetic_operators :  '+' | '-' | '*' | '/' | '%' ;

bitwise_operators : '&' | P_AMPERSAND_EQUALS ; // TODO: | '|' | '|=' | '^' | '^=' | '~' | '>>' | '<<' ;

// TODO: compound_operators : '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '^=' | '|=' ;

logical_operators : ALL | AND | ANY | BETWEEN | EXISTS | IN | LIKE | NOT | OR | SOME ;

urninary_operators : '+' | '-' | '~' ;
 */