parser grammar DatabricksParser;

options { tokenVocab=DatabricksLexer; }

batch : . EOF;