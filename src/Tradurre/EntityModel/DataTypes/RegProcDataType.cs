// <copyright file="RegProcDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Function Name Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegProcDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegProcDataType"/> class.
    /// </summary>
    public RegProcDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegProcDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegProcDataType(Source source)
        : base(source)
    {
    }
}