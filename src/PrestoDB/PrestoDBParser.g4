parser grammar PrestoDBParser;

options { tokenVocab=PrestoDBLexer; }

batch : . EOF;