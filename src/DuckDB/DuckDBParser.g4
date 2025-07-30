parser grammar DuckDBParser;

options { tokenVocab=DuckDBLexer; }

batch : . EOF;