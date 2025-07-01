// <copyright file="ByteADataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a variable length binary string data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href=""/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-binary.html" />
/// </remarks>
public sealed class ByteADataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ByteADataType"/> class.
    /// </summary>
    public ByteADataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ByteADataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public ByteADataType(Source source)
        : base(source)
    {
    }
}