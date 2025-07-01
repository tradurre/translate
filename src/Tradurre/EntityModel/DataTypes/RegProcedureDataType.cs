// <copyright file="RegProcedureDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Function Name with arguments Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegProcedureDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegProcedureDataType"/> class.
    /// </summary>
    public RegProcedureDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegProcedureDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegProcedureDataType(Source source)
        : base(source)
    {
    }
}