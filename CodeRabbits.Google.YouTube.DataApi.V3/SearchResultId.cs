// Licensed to the CodeRabbits under one or more agreements.
// The CodeRabbits licenses this file to you under the MIT license.

namespace CodeRabbits.Google.YouTube.DataApi.V3;

/// <summary>
/// The SearchResultId object contains information that can be used to uniquely identify the resource that matches the search request.
/// </summary>
public class SearchResultId
{
    /// <summary>
    /// The type of the API resource.
    /// </summary>
    public string? Kind { get; set; }

    /// <summary>
    /// If the <c>id.type</c> property's value is <c>youtube#video</c>, then this property will be present and its value will contain the ID that YouTube uses to uniquely identify a video that matches the search query.
    /// </summary>
    public string? VideoId { get; set; }

    /// <summary>
    /// If the <c>id.type</c> property's value is <c>youtube#channel</c>, then this property will be present and its value will contain the ID that YouTube uses to uniquely identify a channel that matches the search query.
    /// </summary>
    public string? ChannelId { get; set; }


    /// <summary>
    /// If the <c>id.type</c> property's value is <c>youtube#playlist</c>, then this property will be present and its value will contain the ID that YouTube uses to uniquely identify a playlist that matches the search query.
    /// </summary>
    public string? PlaylistId { get; set; }
}
