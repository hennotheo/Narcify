using Google.Apis.YouTube.v3.Data;

namespace NarcifyCore.Models;

public readonly struct ResearchResult
{
    public readonly string? Name;
    public readonly ResearchType Type;

    public ResearchResult(SearchResult searchResult)
    {
        Name = searchResult.Snippet?.Title;
        Type = searchResult.Id.Kind switch
        {
            "youtube#video" => ResearchType.Video,
            "youtube#channel" => ResearchType.Channel,
            "youtube#playlist" => ResearchType.Playlist,
            _ => ResearchType.None
        };
    }
}