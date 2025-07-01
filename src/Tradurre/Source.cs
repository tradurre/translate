// <copyright file="Source.cs">
// All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace Tradurre;

/// <summary>
/// The source of a fragment or statement for translation.
/// </summary>
public sealed class Source
{
    public Source(string value = "")
    {
        LineNumber = -1;
        Value = value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="line_number"></param>
    /// <param name="value"></param>
    public Source(int line_number, string value)
    {
        LineNumber = line_number;
        Value = value;
    }

    /// <summary>
    /// Gets or sets the source name for the <see cref="Source"/>.
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// Gets or sets the source line number.
    /// </summary>
    public int LineNumber { get; set; }

    /// <summary>
    /// Gets or sets the original text for the <see cref="Source"/>.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Returns the <see cref="Source"/> as JSON.
    /// </summary>
    /// <returns>JSON representation of the <see cref="Source"/>.</returns>
    public string ToJson()
    {
        JsonSerializerSettings settings = new()
        {

#if DEBUG
            Formatting = Formatting.Indented,
#endif
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        return JsonConvert.SerializeObject(this, settings);
    }
    /* TODO: Move to System.Text.Json when Serialize polymorphic types in .NET isn't dumb.
    public virtual string ToJson()
    {
        JsonSerializerOptions options = new()
        {
            MaxDepth = 0,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver(),
            PropertyNameCaseInsensitive = true,
#if DEBUG
            WriteIndented = true,
#endif
        };

        return JsonSerializer.Serialize<Entity<T>>(this, options);
    }*/
}