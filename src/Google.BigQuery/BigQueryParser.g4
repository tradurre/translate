parser grammar BigQueryParser;

options { tokenVocab=BigQueryLexer; }

batch : . EOF;