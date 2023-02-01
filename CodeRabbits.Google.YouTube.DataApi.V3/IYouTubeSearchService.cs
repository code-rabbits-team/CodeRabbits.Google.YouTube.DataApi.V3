// Licensed to the CodeRabbits under one or more agreements.
// The CodeRabbits licenses this file to you under the MIT license.

namespace CodeRabbits.Google.YouTube.DataApi.V3;

/// <summary>
/// Provides an abstraction for the YouTube search service.
/// </summary>
public interface IYouTubeSearchService
{
    /// <summary>
    /// Returns a collection of search results that match the query parameters specified in the API request.
    /// By default, a search result set identifies matching video, channel, and playlist resources, but you can also configure queries to only retrieve a specific type of resource.
    /// </summary>
    /// <param name="options">The options to use when searching.</param>
    /// <returns>A collection of search results that match the query parameters specified in the API request.</returns>
    public Task<SearchResult> GetListAsync(YouTubeSearchOptions? options);
}
