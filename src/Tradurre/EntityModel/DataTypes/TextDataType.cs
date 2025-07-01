// <copyright file="TextDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a TEXT (variable bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-character.html" />
/// </remarks>
public sealed class TextDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextDataType"/> class.
    /// </summary>
    public TextDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TextDataType(Source source)
        : base(source)
    {
    }
}