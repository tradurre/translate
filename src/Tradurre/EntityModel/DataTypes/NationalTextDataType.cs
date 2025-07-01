// <copyright file="NationalTextDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a NATIONAL TEXT / NTEXT (variable bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class NationalTextDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NationalTextDataType"/> class.
    /// </summary>
    public NationalTextDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalTextDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NationalTextDataType(Source source)
        : base(source)
    {
    }
}