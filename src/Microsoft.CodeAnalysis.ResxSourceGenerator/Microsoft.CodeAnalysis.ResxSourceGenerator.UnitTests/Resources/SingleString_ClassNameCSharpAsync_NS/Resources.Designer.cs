﻿// <auto-generated/>

#nullable enable
using System.Reflection;

namespace TestProject
{
    internal static class Resources { }
}

/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
internal static partial class NS
{
    private static global::System.Resources.ResourceManager? s_resourceManager;
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    public static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(TestProject.Resources)));
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    public static global::System.Globalization.CultureInfo? Culture { get; set; }
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    [return: global::System.Diagnostics.CodeAnalysis.NotNullIfNotNull("defaultValue")]
    internal static string? GetResourceString(string resourceKey, string? defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture) ?? defaultValue;
    /// <summary>value</summary>
    public static string @Name => GetResourceString("Name")!;

}

