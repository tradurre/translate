// <copyright file="FileResult.cs">
// All rights reserved.
// </copyright>


namespace Tradurre;

/// <summary>
/// Initialzies a new instance of the <see cref="FileResult"/> class.
/// </summary>
public sealed class FileResult(string name)
{
    /// <summary>
    /// Gets or sets the Name of the file parsed.
    /// </summary>
    public string Name { get; set; } = name;

    public List<ParseResult> Parses { get; } = [];

    public List<WriteResult> Writes { get; } = [];

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from the translation.
    /// </summary>
    public List<Statement> Statements
    {
        get
        { 
            List<Statement> statements = new(
                Parses.SelectMany(s => s.Statements).Count()
                + Writes.SelectMany(s => s.Statements).Count()
                );

            statements.AddRange(Parses.SelectMany(s => s.Statements));
            statements.AddRange(Writes.SelectMany(s => s.Statements));

            return statements;
        }
    }

    /// <summary>
    /// Gets a collection of <see cref="Error"/> from the translation.
    /// </summary>
    public List<Error> Errors
    {
        get
        {
            List<Error> errors = new(
                Parses.SelectMany(s => s.Errors).Count()
                + Writes.SelectMany(s => s.Errors).Count()
                );

            errors.AddRange(Parses.SelectMany(e => e.Errors));
            errors.AddRange(Writes.SelectMany(e => e.Errors));

            return errors;
        }
    }

    /// <summary>
    /// Gets a collection of <see cref="Warning"/> from the translation.
    /// </summary>
    public List<Warning> Warnings
    {
        get
        {
            List<Warning> warnings = new(
                Parses.SelectMany(s => s.Warnings).Count()
                + Writes.SelectMany(s => s.Warnings).Count()
                );

            warnings.AddRange(Parses.SelectMany(e => e.Warnings));
            warnings.AddRange(Writes.SelectMany(e => e.Warnings));

            return warnings;
        }
    }
}