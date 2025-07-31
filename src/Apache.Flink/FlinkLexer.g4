lexer grammar FlinkLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }


// Catch all for undefined rules
UNRECOGNIZED : . ;