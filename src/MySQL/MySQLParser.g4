parser grammar MySQLParser;

options { tokenVocab=MySQLLexer; }

batch : . EOF;