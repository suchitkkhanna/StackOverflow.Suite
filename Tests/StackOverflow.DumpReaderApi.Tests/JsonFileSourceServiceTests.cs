using System.Linq;
using NUnit.Framework;
using StackOverflow.Domain;
using StackOverflow.DumpReaderApi.Repository;

namespace StackOverflow.DumpReaderApi.Tests
{
    public class JsonFileSourceServiceTests
    {
        [OneTimeSetUp]
        public void TestSetup()
        {
            DumpReaderApiTestConfiguration.SetUp();
        }

        [Test]
        public void ShouldCountContributorTypes()
        {
            Assert.That(DumpReaderApiTestConfiguration.Resolve<IRepository<ContributorType>>().QueryAll().Count(), Is.EqualTo(2));
        }
    }
}