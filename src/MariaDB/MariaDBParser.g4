parser grammar MariaDBParser;

options { tokenVocab=MariaDBLexer; }

batch : statement+ EOF;

statement
    : alter
    | create
    | drop
    | security
    ;

alter
    : alter_user
    ;

alter_user : ALTER USER if_exists? user_specification ( ',' user_specification )* create_user_option* ;

create
    : create_role
    | create_user
    ;

create_role : CREATE or_replace? ROLE if_not_exists? role_name ( WITH ADMIN ( CURRENT_USER | CURRENT_ROLE | user_name | role_name ) )? ;
create_user : CREATE or_replace? USER if_not_exists? user_specification ( ',' user_specification )* create_user_option* ;

drop
    : drop_role
    ;

drop_role : DROP ROLE if_exists? role_name ( ',' role_name )* ;

security
    : rename_user
    | set_default_role
    | set_password
    | set_session_authorization
    ;

rename_user : RENAME USER user_name TO user_name ( ',' user_name TO user_name )* ;
set_default_role : SET DEFAULT ROLE ( role_name | NONE ) ( FOR user_name )? ;
set_password : SET PASSWORD ( FOR user_name )? set_password_option ;
set_session_authorization : SET SESSION AUTHORIZATION user_name ;

authentication_option :
    ( IDENTIFIED BY SINGLE_QUOTED_IDENTIFIER )
    | ( IDENTIFIED BY PASSWORD SINGLE_QUOTED_IDENTIFIER )
    | ( IDENTIFIED ( VIA | WITH ) authentication_rule ( OR authentication_rule )* )
    ;
authentication_rule
    : authentication_plugin
    | authentication_plugin ( USING | AS ) SINGLE_QUOTED_IDENTIFIER
    | authentication_plugin ( USING | AS ) PASSWORD '(' SINGLE_QUOTED_IDENTIFIER ')'
    ;

authentication_plugin
    : AUTH_GSSAPI_CLIENT
    | CACHING_SHA256_PASSWORD
    | CLIENT_ED25519
    | DIALOG
    | ED25519
    | GSSAPI
    | MYSQL_CLEAR_PASSWORD
    | MYSQL_NATIVE_PASSWORD 
    | MYSQL_OLD_PASSWORD
    | NAMED_PIPE
    | PAM
    | SHA256_PASSWORD
    | UNIX_SOCKET
    ;

create_user_option :
    ( REQUIRE ( NONE | ( tls_option ( AND? tls_option )* ) ) )
    | ( WITH resource_option+ )
    | lock_option
    | password_option
    ;

if_exists : IF EXISTS ;
if_not_exists : IF NOT EXISTS ;
lock_option : ACCOUNT ( LOCK | UNLOCK ) ;
or_replace : OR REPLACE ;

password_option:
    ( PASSWORD EXPIRE )
    | ( PASSWORD EXPIRE DEFAULT )
    | ( PASSWORD EXPIRE NEVER )
    | ( PASSWORD EXPIRE INTERVAL DIGIT_IDENTIFIER DAY )
    ;

resource_option:
    ( MAX_QUERIES_PER_HOUR DIGIT_IDENTIFIER )
    | ( MAX_UPDATES_PER_HOUR DIGIT_IDENTIFIER )
    | ( MAX_CONNECTIONS_PER_HOUR DIGIT_IDENTIFIER )
    | ( MAX_USER_CONNECTIONS DIGIT_IDENTIFIER )
    | ( MAX_STATEMENT_TIME DIGIT_IDENTIFIER )
    ;

set_password_option :
    ( PASSWORD '(' SINGLE_QUOTED_IDENTIFIER ')' )
    | ( OLD_PASSWORD '(' SINGLE_QUOTED_IDENTIFIER ')' )
    | SINGLE_QUOTED_IDENTIFIER
    ;

tls_option :
    SSL
    | X509
    | ( CIPHER SINGLE_QUOTED_IDENTIFIER )
    | ( ISSUER SINGLE_QUOTED_IDENTIFIER )
    | ( SUBJECT SINGLE_QUOTED_IDENTIFIER )
    ;

user_specification : user_name authentication_option ;

identifier :
    IDENTIFIER
    | BRACKETED_IDENTIFIER
    | DOUBLE_QUOTED_IDENTIFER
    | SINGLE_QUOTED_IDENTIFIER
    ;

role_name : name=identifier ;
user_name : name=identifier ;