parser grammar MariaDBParser;

options { tokenVocab=MariaDBLexer; }

batch : . EOF;