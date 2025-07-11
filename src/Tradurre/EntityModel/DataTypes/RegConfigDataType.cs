﻿// <copyright file="RegConfigDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Text Search Configuration Object Identifier (OID) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-oid.html" />
/// </remarks>
public sealed class RegConfigDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegConfigDataType"/> class.
    /// </summary>
    public RegConfigDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegConfigDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RegConfigDataType(Source source)
        : base(source)
    {
    }
}