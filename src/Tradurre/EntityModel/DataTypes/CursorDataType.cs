// <copyright file="CursorDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CURSOR (variable byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/cursor-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class CursorDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CursorDataType"/> class.
    /// </summary>
    public CursorDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CursorDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CursorDataType(Source source)
        : base(source)
    {
    }

    // TODO: Implement the CURSOR data type.
}