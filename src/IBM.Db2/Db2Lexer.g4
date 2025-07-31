lexer grammar Db2Lexer;

channels { comment, whitespace }
options { caseInsensitive = true; }


// Catch all for undefined rules
UNRECOGNIZED : . ;