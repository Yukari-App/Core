namespace Yukari.Core.Models;

/// <summary>
/// Specifies the publication status of a <see cref="Comic"/>.
/// </summary>
public enum ComicStatus
{
    /// <summary>
    /// The publication status is unknown or unspecified.
    /// </summary>
    Unknown,

    /// <summary>
    /// The comic is actively being published.
    /// </summary>
    Ongoing,

    /// <summary>
    /// The comic has finished publication.
    /// </summary>
    Completed,

    /// <summary>
    /// The comic is temporarily on hiatus.
    /// </summary>
    Hiatus,

    /// <summary>
    /// The comic was cancelled or discontinued before completion.
    /// </summary>
    Cancelled,
}
