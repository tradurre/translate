// <copyright file="XmlDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an XML data type.
/// </summary>
/// <remarks>
/// Defined in the SQL:2003 standard as XML.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/xml/xml-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-xml.html" />
/// </remarks>
public sealed class XmlDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="XmlDataType"/> class.
    /// </summary>
    public XmlDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public XmlDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Gets or sets the <see cref="XmlRestrictionType"/> for the data type.
    /// </summary>
    public XmlRestrictionType? Restriction { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="CollectionName"/> for the data type.
    /// </summary>
    public Identifier? SchemaCollection { get; set; }
}