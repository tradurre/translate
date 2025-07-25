// <copyright file="DropSchemaOption.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Options for a DROP SCHEMA statement
/// </summary>
/// <remarks>
/// PostgreSQL : DROP SCHEMA https://www.postgresql.org/docs/current/sql-dropschema.html
/// <list type="bullet">
/// <item>CASCADE
/// <para>Automatically drop objects (tables, functions, etc.) that are contained in the schema, and in turn all objects that depend on those objects.</para>
/// </item>
/// <item>RESTRICT
/// <para>Refuse to drop the schema if it contains any objects. This is the default.</para>
/// </item>
/// </list>
///
/// IBM DB2: DROP DATABASE https://www.ibm.com/docs/en/db2/12.1.0?topic=commands-drop-database
/// <list type="bullet">
/// <item><para>AT DBPARTITIONNUM</para>
/// <para>Specifies that the database is to be deleted only on the database partition that issued the DROP DATABASE command.This parameter is used by
/// utilities supplied with IBM Db2® Warehouse, can be used in partitioned database environments, and is not intended for general use. Improper use of this parameter can cause
/// inconsistencies in the system, so it should only be used with caution.</para></item>
/// </list>
/// </remarks>
public enum DropSchemaOption
{
    Cascade,

    Restrict
}