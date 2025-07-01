// <copyright file="XmlRestrictionType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines the XML document completeness restriction. 
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/xml/xml-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public enum XmlRestrictionType
{
    /// <summary>
    /// Restricts the xml instance to be a well-formed XML document. The XML data must have one and only one root element. Text nodes aren't allowed at the top level.
    /// </summary>
    Document,

    /// <summary>
    /// Restricts the xml instance to be a well-formed XML fragment. The XML data can contain multiple zero or more elements at the top level. Text nodes are also allowed at the top level.
    /// </summary>
    Fragment,
}