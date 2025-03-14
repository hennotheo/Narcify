using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NarcifyCore.Interfaces;
using NarcifyCore.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace NarcifyCore.Repository;

public class YoutubeRepository : IRepository
{
    private static readonly string API_KEY = Environment.GetEnvironmentVariable("YOUTUBE_API_KEY");

    public async Task<IReadOnlyCollection<ResearchResult>> Search(string query, int maxResults = 5)
    {
        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = API_KEY,
            ApplicationName = this.GetType().ToString()
        });

        var searchListRequest = youtubeService.Search.List("snippet");
        searchListRequest.Q = query;
        searchListRequest.MaxResults = 5;
        
        var searchListResponse = await searchListRequest.ExecuteAsync();

        List<ResearchResult> results = new List<ResearchResult>();
        
        foreach (SearchResult searchResult in searchListResponse.Items)
        {
            results.Add(new ResearchResult(searchResult));
        }

        return results;
    }
}