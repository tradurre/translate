// <copyright file="RegCollationDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Collation Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegCollationDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegCollationDataType"/> class.
    /// </summary>
    public RegCollationDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegCollationDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegCollationDataType(Source source)
        : base(source)
    {
    }
}