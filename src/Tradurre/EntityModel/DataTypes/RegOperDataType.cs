// <copyright file="RegOperDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an Operator Name Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegOperDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegOperDataType"/> class.
    /// </summary>
    public RegOperDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegOperDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegOperDataType(Source source)
        : base(source)
    {
    }
}