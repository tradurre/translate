// <copyright file="ParserExtensions.cs">
// All rights reserved.
// </copyright>

using Antlr4.Runtime;
using System.Text;

namespace Tradurre;

/// <summary>
/// A set of extensions for <see cref="ParserRuleContext"/> class.
/// </summary>
public static class ParserRuleContextExtensions
{
    /// <summary>
    /// Gets a <see cref="Source"/> for the <see cref="ParserRuleContext"/>.
    /// </summary>
    /// <param name="context">The <see cref="ParserRuleContext"/>.</param>
    /// <returns>A <see cref="Source"/>.</returns>
    public static Source Info(this ParserRuleContext context)
    {
        return new(context.StartLine(), context.PrettyPrint());
    }

    /// <summary>
    /// Prints the <see cref="ParserRuleContext"/> in its original form.
    /// </summary>
    /// <param name="context">The <see cref="ParserRuleContext"/> that contains the token pointers.</param>
    /// <returns>The original statement.</returns>
    public static string PrettyPrint(this ParserRuleContext context)
    {
        if (context is null || Translator.Tokens is null)
            return string.Empty;

        StringBuilder sb = new();

        if (context.Start.IsNotEmpty()
            && context.Stop.IsNotEmpty())
        {
            int start_index = context.Start.TokenIndex;
            int stop_index = context.Stop.TokenIndex;

            var tokens = Translator.Tokens.Get(start_index, stop_index);

            foreach(var token in tokens)
            {
                sb.Append(token.Text);
            }
        }
        else
        {
            sb.Append(context.GetText());
        }

        return sb.ToString();
    }

    /// <summary>
    /// Gets the starting line for the <see cref="ParserRuleContext"/>.
    /// </summary>
    /// <param name="context">The <see cref="ParserRuleContext"/> to evaluate.</param>
    /// <returns>The starting line of the <see cref="ParserRuleContext"/>.</returns>
    public static int StartLine(this ParserRuleContext context)
    {
        if (context is null || context.Start is null)
        {
            return -1;
        }

        return context.Start.Line;
    }
}