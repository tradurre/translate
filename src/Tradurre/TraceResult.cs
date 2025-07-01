// <copyright file="TraceResult.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The result of a logging trace.
/// </summary>
/// <param name="MemberName">The calling memeber name.</param>
/// <param name="SourcePath">The calling member source file path.</param>
/// <param name="LineNumber">The calling member source line number.</param>
public record TraceResult(string MemberName, string SourcePath, int LineNumber);