// <copyright file="CreateStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CREATE SQL statement.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="CreateStatement"/> class with the specified
/// <see cref="Source"/>.
/// </remarks>
/// <param name="source">The <see cref="Source"/> for the statement.</param>
public abstract class CreateStatement(Source source)
    : Statement(source)
{
}