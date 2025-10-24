// <copyright file="DataTypeVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using System.Diagnostics.Eventing.Reader;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the data_type rule.
/// </summary>
internal class DataTypeVisitor : SqlVisitor<DataType>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DataTypeVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DataTypeVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override DataType VisitData_type(Data_typeContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        if (context.ARRAY() is not null)
            return new ArrayDataType(context.Source());

        else if (context.BIGINT() is not null)
            return new BigIntegerDataType(context.Source());
        else if (context.BINARY() is not null)
            return new BinaryDataType(context.Source());
        else if (context.BIT() is not null)
            return new BitDataType(context.Source());
        else if (context.BITSTRING() is not null)
            return new BitDataType(context.Source());
        else if (context.BLOB() is not null)
            return new BinaryLargeObjectDataType(context.Source());
        else if (context.BOOL() is not null)
            return new BooleanDataType(context.Source());
        else if (context.BOOLEAN() is not null)
            return new BooleanDataType(context.Source());
        else if (context.BPCHAR() is not null)
        {
            BlankPaddedCharacterDataType type = new(context.Source());
            AddPrecision(type, context.precision_only());
            return type;
        }
        else if (context.BYTEA() is not null)
            return new ByteADataType(context.Source());

        else if (context.CHAR() is not null)
        {
            CharacterDataType type = new(context.Source());
            AddPrecision(type, context.precision_only());
            return type;
        }


        else if (context.DATE() is not null)
            return new DateDataType(context.Source());
        else if (context.DATETIME() is not null)
            return new DateTimeDataType(context.Source());
        else if (context.DECIMAL() is not null)
        {
            DecimalDataType type = new(context.Source());
            AddPrecisionAndScale(type, context.precision_scale());
            return type;
        }
        else if (context.DOUBLE() is not null)
            return new DoublePrecsionDataType(context.Source());

        else if (context.FLOAT() is not null)
            return new FloatDataType(context.Source());
        else if (context.FLOAT4() is not null)
            return new FloatDataType(context.Source());
        else if (context.FLOAT8() is not null)
            return new DoublePrecsionDataType(context.Source());

        else if (context.HUGEINT() is not null)
            throw new NotImplementedException();

        else if (context.INT() is not null)
            return new IntegerDataType(context.Source());
        else if (context.INT1() is not null)
            return new TinyIntegerDataType(context.Source());
        else if (context.INT2() is not null)
            return new SmallIntegerDataType(context.Source());
        else if (context.INT4() is not null)
            return new IntegerDataType(context.Source());
        else if (context.INT8() is not null)
            return new BigIntegerDataType(context.Source());
        else if (context.INTEGER() is not null)
            return new IntegerDataType(context.Source());
        else if (context.INTERVAL() is not null)
        {
            throw new NotImplementedException();
            // TODO: return new IntervalDataType(context.Source());
        }

        else if (context.JSON() is not null)
            return new JsonDataType(context.Source());

        else if (context.LIST() is not null)
            throw new NotImplementedException();
        else if (context.LOGICAL() is not null)
            return new BooleanDataType(context.Source());
        else if (context.LONG() is not null)
            return new BigIntegerDataType(context.Source());

        else if (context.MAP() is not null)
            throw new NotImplementedException();

        else if (context.NUMERIC() is not null)
        {
            NumericDataType type = new(context.Source());

            if (context.precision_scale() is not null)
                AddPrecisionAndScale(type, context.precision_scale());

            return type;
        }

        else if (context.REAL() is not null)
            return new RealDataType(context.Source());

        else if (context.SHORT() is not null)
            return new SmallIntegerDataType(context.Source());
        else if (context.SIGNED() is not null)
            return new IntegerDataType(context.Source());
        else if (context.SMALLINT() is not null)
            return new SmallIntegerDataType(context.Source());
        else if (context.STRING() is not null)
        {
            CharacterVaryingDataType type = new(context.Source());
            AddPrecision(type, context.precision_only());
            return type;
        }

        else if (context.TEXT() is not null)
        {
            CharacterVaryingDataType type = new(context.Source());
            AddPrecision(type, context.precision_only());
            return type;
        }

        else if (context.VARBINARY() is not null)
            return new BinaryVaryingDataType(context.Source());

        else if (context.VARCHAR() is not null)
        {
            CharacterVaryingDataType type = new(context.Source());
            AddPrecision(type, context.precision_only());
            return type;
        }

        else
            throw new NotImplementedException();
    }

    private void AddPrecision(DataTypePrecision type, Precision_onlyContext? context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        if (context is not null)
            type.Precision = int.Parse(context.precision.Text);

        Logger.NestEnd();
    }

    private void AddPrecisionAndScale(DataTypePrecisionAndScale type, Precision_scaleContext? context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        if (context is not null)
        {
            type.Precision = int.Parse(context.precision.Text);

            if (context.scale is not null)
                type.Scale = int.Parse(context.scale.Text);
        }

        Logger.NestEnd();
    }
}