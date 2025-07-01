// <copyright file="OidDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class OidDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OidDataType"/> class.
    /// </summary>
    public OidDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OidDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public OidDataType(Source source)
        : base(source)
    {
    }
}