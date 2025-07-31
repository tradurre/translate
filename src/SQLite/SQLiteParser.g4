parser grammar SQLiteParser;

options { tokenVocab=SQLiteLexer; }

batch : . EOF;