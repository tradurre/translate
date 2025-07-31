parser grammar TeradataParser;

options { tokenVocab=TeradataLexer; }

batch : . EOF;