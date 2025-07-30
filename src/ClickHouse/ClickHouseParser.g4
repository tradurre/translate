parser grammar ClickHouseParser;

options { tokenVocab=ClickHouseLexer; }

batch : . EOF;