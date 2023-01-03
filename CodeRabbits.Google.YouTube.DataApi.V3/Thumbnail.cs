// Licensed to the CodeRabbits under one or more agreements.
// The CodeRabbits licenses this file to you under the MIT license.

namespace CodeRabbits.Google.YouTube.DataApi.V3;

/// <summary>
/// A thumbnail is an image representing a YouTube resource.
/// </summary>
public class Thumbnail
{
    /// <summary>
    /// The image's URL.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// The image's width.
    /// </summary>
    public uint? Widht { get; set; }

    /// <summary>
    /// The image's height.
    /// </summary>
    public uint? Height { get; set; }
}
