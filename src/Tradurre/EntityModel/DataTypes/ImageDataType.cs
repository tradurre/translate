// <copyright file="ImageDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an IMAGE (variable bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class ImageDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ImageDataType"/> class.
    /// </summary>
    public ImageDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ImageDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public ImageDataType(Source source)
        : base(source)
    {
    }
}