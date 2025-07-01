// <copyright file="RegNamespaceDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Namespace Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegNamespaceDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegNamespaceDataType"/> class.
    /// </summary>
    public RegNamespaceDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegNamespaceDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegNamespaceDataType(Source source)
        : base(source)
    {
    }
}