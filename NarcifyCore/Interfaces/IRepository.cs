using NarcifyCore.Models;

namespace NarcifyCore.Interfaces;

public interface IRepository
{
    IReadOnlyCollection<ResearchResult> Search(string query);
}