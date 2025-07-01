// <copyright file="UniqueIdentifierDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a UNIQUEIDENTIFIER (16 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/uniqueidentifier-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-uuid.html" />
/// </remarks>
public sealed class UniqueIdentifierDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UniqueIdentifierDataType"/> class.
    /// </summary>
    public UniqueIdentifierDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UniqueIdentifierDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public UniqueIdentifierDataType(Source source)
        : base(source)
    {
    }
}