// <copyright file="RegOperatorDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an Operator with argument types Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegOperatorDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegOperatorDataType"/> class.
    /// </summary>
    public RegOperatorDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegOperatorDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegOperatorDataType(Source source)
        : base(source)
    {
    }
}