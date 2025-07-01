// <copyright file="HierarchyIdDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a HIERARCHYID (variable bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href=""/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class HierarchyIdDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HierarchyIdDataType"/> class.
    /// </summary>
    public HierarchyIdDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HierarchyIdDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public HierarchyIdDataType(Source source)
        : base(source)
    {
    }
}