using NarcifyCore.Models;

namespace NarcifyCore.Interfaces;

public interface IRepository
{
    Task<IReadOnlyCollection<ResearchResult>> Search(string query, int maxResults = 5);
}