using NarcifyCore;
using NarcifyCore.Interfaces;
using NarcifyCore.Models;
using NarcifyCore.Repository;
using NUnit.Framework.Legacy;

namespace NarcifyCoreTest;

public class SearchTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("A")]
    public void CallingResearchFunction(string query)
    {
        IRepository repository = new YoutubeRepository();

        if (repository.Search(query).Count != 0)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [Test]
    [TestCase("Query")]
    public void CheckResearchMatchQuery(string query)
    {
        IRepository repository = new YoutubeRepository();
        IReadOnlyCollection<ResearchResult> results = repository.Search(query);

        foreach (var result in results)
        {
            if (result.Query != query)
            {
                Assert.Fail();
            }
        }

        Assert.Pass();
    }
}