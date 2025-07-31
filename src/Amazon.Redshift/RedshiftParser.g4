parser grammar RedshiftParser;

options { tokenVocab=RedshiftLexer; }

batch : . EOF;