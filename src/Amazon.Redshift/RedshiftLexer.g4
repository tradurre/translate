lexer grammar RedshiftLexer;

channels { comment, whitespace }
options { caseInsensitive = true; }


// Catch all for undefined rules
UNRECOGNIZED : . ;