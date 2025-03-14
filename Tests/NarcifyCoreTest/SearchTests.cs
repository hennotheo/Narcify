using NarcifyCore;
using NarcifyCore.Interfaces;
using NarcifyCore.Repository;

namespace NarcifyCoreTest;

public class SearchTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("A")]
    public void CallingResearchFunction(string research)
    {
        IRepository repository = new YoutubeRepository();

        if (repository.Search("test").Count != 0)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }
}