parser grammar FlinkParser;

options { tokenVocab=FlinkLexer; }

batch : . EOF;