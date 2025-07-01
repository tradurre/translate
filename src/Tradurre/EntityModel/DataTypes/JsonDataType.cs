// <copyright file="JsonDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a JSON (variable length) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL:2008 standard as JSON.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/json-data-type"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class JsonDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JsonDataType"/> class.
    /// </summary>
    public JsonDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public JsonDataType(Source source)
        : base(source)
    {
    }
}