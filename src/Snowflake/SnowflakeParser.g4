parser grammar SnowflakeParser;

options { tokenVocab=SnowflakeLexer; }

batch : . EOF;