namespace Yukari.Core.Sources;

/// <summary>
/// Provides identifying metadata for a <see cref="IComicSource"/> plugin implementation.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class ComicSourceMetadataAttribute : Attribute
{
    /// <summary>
    /// Gets the unique display name of the comic source.
    /// Cannot be <c>"Local"</c> (case-insensitive), which is reserved by the host for local comics.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the version string of the comic source plugin, typically formatted as
    /// <c>"{pluginVersion}+core{coreVersion}"</c> (for example, <c>"2.6.0+core2.6.0"</c>).
    /// </summary>
    public string Version { get; }

    /// <summary>
    /// Gets the optional URL of the plugin's GitHub releases page used for automatic update checks.
    /// </summary>
    public string? ReleasesPage { get; }

    /// <summary>
    /// Gets the optional URL of the source's logo image, fetched via <see cref="IComicSource.GetImageBytesAsync"/> and cached locally on install.
    /// </summary>
    public string? LogoUrl { get; }

    /// <summary>
    /// Gets an optional short description of the comic source.
    /// </summary>
    public string? Description { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ComicSourceMetadataAttribute"/> class.
    /// </summary>
    /// <param name="name">The unique display name of the comic source (cannot be <c>"Local"</c>).</param>
    /// <param name="version">The version string of the comic source plugin (for example, <c>"2.6.0+core2.6.0"</c>).</param>
    /// <param name="releasesPage">The optional URL of the plugin's GitHub releases page.</param>
    /// <param name="logoUrl">The optional URL of the source's logo image.</param>
    /// <param name="description">An optional short description of the comic source.</param>
    public ComicSourceMetadataAttribute(
        string name,
        string version,
        string? releasesPage = null,
        string? logoUrl = null,
        string? description = null
    )
    {
        Name = name;
        Version = version;
        ReleasesPage = releasesPage;
        LogoUrl = logoUrl;
        Description = description;
    }
}
