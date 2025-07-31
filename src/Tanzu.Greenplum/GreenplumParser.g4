parser grammar GreenplumParser;

options { tokenVocab=GreenplumLexer; }

batch : . EOF;