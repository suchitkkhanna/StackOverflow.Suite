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
        public void ShouldQueryAllContributorTypes()
        {
            Assert.That(DumpReaderApiTestConfiguration.Resolve<IRepository<ContributorType>>().QueryAll().Count(), Is.EqualTo(2));
        }

        [Test]
        public void ShouldQueryAllDocTags()
        {
            Assert.That(DumpReaderApiTestConfiguration.Resolve<IRepository<DocTag>>().QueryAll().Count(), Is.EqualTo(1145));
        }

        [Test]
        public void ShouldQueryAllDocTagVersion()
        {
            Assert.That(DumpReaderApiTestConfiguration.Resolve<IRepository<DocTagVersion>>().QueryAll().Count(), Is.EqualTo(5956));
        }
    }
}