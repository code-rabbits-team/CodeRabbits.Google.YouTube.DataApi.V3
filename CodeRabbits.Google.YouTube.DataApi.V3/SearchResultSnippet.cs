// Licensed to the CodeRabbits under one or more agreements.
// The CodeRabbits licenses this file to you under the MIT license.

namespace CodeRabbits.Google.YouTube.DataApi.V3;

/// <summary>
/// The snippet object contains basic details about a search result,
/// such as its title or description. For example, if the search result is a video,
/// then the title will be the video's title and the description will be the video's description.
/// </summary>
public class SearchResultSnippet
{
    /// <summary>
    /// The creation date and time of the resource that the search result identifies.
    /// The value is specified in <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format.
    /// </summary>
    public DateTime? PublishedAt { get; set; }

    /// <summary>
    /// The value that YouTube uses to uniquely identify the channel
    /// that published the resource that the search result identifies.
    /// </summary>
    public string? ChannelId { get; set; }

    /// <summary>
    /// The title of the search result.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// The description of the search result.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// A map of thumbnail images associated with the search result.
    /// For each object in the map, the key is the name of the thumbnail image,
    /// and the value is an object that contains other information about the thumbnail.
    /// </summary>

    public Dictionary<string, Thumbnail>? Thumbnails { get; set; }

    /// <summary>
    /// The title of the channel that published the resource that the search result identifies.
    /// </summary>
    public string? ChannelTitle { get; set; }

    /// <summary>
    /// An indication of whether a <b>video</b> or <b>channel</b> resource has live broadcast content. Valid property values are <b>upcoming</b>, <b>live</b>live, and <b>none</b>. <br />
    /// <br />
    /// For a <b>video</b> resource, a value of <b>upcoming</b> indicates that the video is a live broadcast that has not yet started,
    /// while a value of live indicates that the video is an active live broadcast. <br />
    /// For a <b>channel</b> resource, a value of <b>upcoming</b> indicates that the channel has a scheduled broadcast that has not yet started,
    /// while a value of <b>live</b> indicates that the channel has an active live broadcast. <br />
    /// </summary>
    public string? LiveBroadcastContent { get; set; }
}
