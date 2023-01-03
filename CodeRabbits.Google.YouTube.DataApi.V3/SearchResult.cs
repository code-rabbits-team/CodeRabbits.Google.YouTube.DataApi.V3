// Licensed to the CodeRabbits under one or more agreements.
// The CodeRabbits licenses this file to you under the MIT license.

namespace CodeRabbits.Google.YouTube.DataApi.V3;

/// <summary>
/// A search result contains information about a YouTube video, channel, or playlist that matches the search
/// parameters specified in an API request. While a search result points to a uniquely identifiable resource, like a
/// video, it does not have its own persistent data.
/// </summary>
public class SearchResult
{
    /// <summary>
    /// Identifies the API resource's type. The value will be <c>>youtube#searchResult</c.
    /// </summary>
    public string? Kind { get; set; }

    /// <summary>
    /// The Etag of this resource.
    /// </summary>
    public string? ETag { get; set; }

    /// <summary>
    /// The id object contains information that can be used to uniquely identify the resource that matches the search request.
    /// </summary>
    public SearchResultId? Id { get; set; }

    /// <summary>
    /// The <c>snippet</c> object contains basic details about a search result, such as its title or description.
    /// For example, if the search result is a video, then the title will be the video's title and the description will be the video's description.
    /// </summary>
    public SearchResultSnippet? Snippet { get; set; }
}
