parser grammar ImpalaParser;

options { tokenVocab=ImpalaLexer; }

batch : . EOF;