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
    private readonly List<ResearchResult> m_researchResults = new()
    {
        new ResearchResult { Name = "test" },
        new ResearchResult { Name = "test2" }
    };

    public IReadOnlyCollection<ResearchResult> Search(string query)
    {
        return m_researchResults;
    }
}