// <copyright file="RegClassDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Relation Name Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegClassDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegClassDataType"/> class.
    /// </summary>
    public RegClassDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegClassDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegClassDataType(Source source)
        : base(source)
    {
    }
}