using NarcifyCore.Interfaces;
using NarcifyCore.Models;

namespace NarcifyCore.Repository;

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