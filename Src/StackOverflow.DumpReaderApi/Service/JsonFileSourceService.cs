using StackOverflow.Domain;
using StackOverflow.DumpReaderApi.Dao;
using StackOverflow.DumpReaderApi.Repository;

namespace StackOverflow.DumpReaderApi.Service
{
    public class JsonFileSourceService
    {
        private readonly IDao _dao;
        private readonly IRepository<ContributorType> _contributorTypeRepository;

        public JsonFileSourceService(JsonFileDao dao, IRepository<ContributorType> contributorTypeRepository)
        {
            _dao = dao;
            _contributorTypeRepository = contributorTypeRepository;
        }

        public int QueryContributorTypeCount()
        {
            return 0;
        }
    }
}