parser grammar HiveParser;

options { tokenVocab=HiveLexer; }

batch : . EOF;