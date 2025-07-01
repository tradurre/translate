// <copyright file="LogSequenceNumberDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Log Sequence Number (LSN) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-pg-lsn.html" />
/// </remarks>
public sealed class LogSequenceNumberDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogSequenceNumberDataType"/> class.
    /// </summary>
    public LogSequenceNumberDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogSequenceNumberDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public LogSequenceNumberDataType(Source source)
        : base(source)
    {
    }
}