// <copyright file="SerialDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SERIAL (4 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />.
/// </remarks>
public sealed class SerialDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SerialDataType"/> class.
    /// </summary>
    public SerialDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SerialDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SerialDataType(Source source)
        : base(source)
    {
    }
}