// <copyright file="Fragment.cs">
// All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace Tradurre;

/// <summary>
/// Represents a SQL fragment.
/// </summary>
public abstract class Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Fragment"/> class.
    /// </summary>
    public Fragment()
    {
        Source = new();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Fragment"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public Fragment(Source source)
    {
        Source = source;
    }

    /// <summary>
    /// Gets or sets the <see cref="Source"/> for the fragment.
    /// </summary>
    public Source Source { get; set; }

    /// <summary>
    /// Returns the <see cref="Fragment"/> as JSON.
    /// </summary>
    /// <returns>JSON representation of the <see cref="Fragment"/>.</returns>
    public string ToJson()
    {
        JsonSerializerSettings settings = new()
        {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
#if DEBUG
            ,
            TypeNameHandling = TypeNameHandling.Objects
#endif
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