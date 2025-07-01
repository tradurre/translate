// <copyright file="RegTypeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Data Type Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegTypeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegTypeDataType"/> class.
    /// </summary>
    public RegTypeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegTypeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegTypeDataType(Source source)
        : base(source)
    {
    }
}