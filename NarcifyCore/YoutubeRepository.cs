namespace NarcifyCore;

public struct ResearchResult
{
    public string Query { get; set; }

    public string Name { get; set; }
}

public interface IRepository
{
    IReadOnlyCollection<ResearchResult> Search(string query);
}

public class YoutubeRepository : IRepository
{
    public IReadOnlyCollection<ResearchResult> Search(string query)
    {
        throw new NotImplementedException();
    }
}