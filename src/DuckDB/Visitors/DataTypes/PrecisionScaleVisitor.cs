// <copyright file="PrecisionScaleVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the data_type rule.
/// </summary>
internal class PrecisionScaleVisitor : SqlVisitor<DataType>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="PrecisionScaleVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public PrecisionScaleVisitor(ILogger logger)
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
            // TODO:
            throw new NotImplementedException();
        else if (context.BLOB() is not null)
            return new BinaryLargeObjectDataType(context.Source());
        else if (context.BOOL() is not null)
            return new BooleanDataType(context.Source());
        else if (context.BOOLEAN() is not null)
            return new BooleanDataType(context.Source());
        else if (context.BPCHAR() is not null)
            return new BlankPaddedCharacterDataType(context.Source());
        else if (context.BYTEA() is not null)
            return new ByteADataType(context.Source());

        else if (context.CHAR() is not null)
            return new CharacterDataType(context.Source());


        else if (context.DATE() is not null)
            return new DateDataType(context.Source());
        else if (context.DATETIME() is not null)
            return new DateTimeDataType(context.Source());
        else if (context.DECIMAL() is not null)
        {
            DecimalDataType type = new(context.Source());
            AddPrecisionScale(type, context.precision_scale());
            return type;
        }
        else if (context.DOUBLE() is not null)
            return new DoublePrecsionDataType(context.Source());


        else
            throw new NotImplementedException();
    }

    private void AddPrecisionScale(DataTypePrecisionAndScale type, Precision_scaleContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        // TODO: type.ThrowIfNull();
        if (context is not null)
        {
            type.Precision = int.Parse(context.precision.Text);

            if (context.scale is not null)
                type.Scale = int.Parse(context.scale.Text);
        }

        Logger.NestEnd();
    }
}