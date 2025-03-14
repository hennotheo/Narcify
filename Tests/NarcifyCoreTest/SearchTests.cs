using NarcifyCore;
using NarcifyCore.Interfaces;
using NarcifyCore.Models;
using NarcifyCore.Repository;
using NUnit.Framework.Legacy;
using NUnit.Framework;

namespace NarcifyCoreTest;

public class SearchTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CallingResearchFunction()
    {
        IRepository repository = new YoutubeRepository();
        IReadOnlyCollection<ResearchResult> results = repository.Search("Cat").GetAwaiter().GetResult();

        if (results.Count == 0)
        {
            Assert.Fail();
        }

        Assert.Pass();
    }

    [Test]
    public void CheckAllResearchValid()
    {
        IRepository repository = new YoutubeRepository();
        IReadOnlyCollection<ResearchResult> results = repository.Search("Cat").GetAwaiter().GetResult();

        foreach (var result in results)
        {
            if (result.Type == ResearchType.None)
            {
                Assert.Fail();
            }
        }

        Assert.Pass();
    }
}