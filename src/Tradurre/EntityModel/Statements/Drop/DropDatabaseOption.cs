// <copyright file="DropDatabaseOption.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Options for a DROP DATABASE statement
/// </summary>
/// <remarks>
/// Snowflake: DROP DATABASE https://docs.snowflake.com/en/sql-reference/sql/drop-database
/// <para>Specifies whether the database can be dropped if foreign keys exist that reference any tables in the database:</para>
/// <list type="bullet">
/// <item>CASCADE drops the database and all objects in the database, including tables with primary/unique keys that are referenced by foreign keys in other tables.</item>
/// <item>RESTRICT returns a warning about existing foreign key references and does not drop the database.</item>
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
public enum DropDatabaseOption
{
    At_PartitionNumber,

    Cascade,

    Restrict
}