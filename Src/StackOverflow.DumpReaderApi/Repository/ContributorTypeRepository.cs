using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using StackOverflow.Domain;
using StackOverflow.DumpReaderApi.Dao;

namespace StackOverflow.DumpReaderApi.Repository
{
    public class ContributorTypeRepository : IRepository<ContributorType>
    {
        private readonly IDao _dao;
        private readonly IList<ContributorType> _contributorTypes = new List<ContributorType>();

        public ContributorTypeRepository(IDao dao)
        {
            _dao = dao;
        }

        public IEnumerable<ContributorType> QueryAll()
        {
            if (!_contributorTypes.Any())
            {
                IEnumerable<ContributorType> result = _dao.Read<ContributorType>("contributortypes.json");
                foreach (var contributorType in result)
                {
                    _contributorTypes.Add(contributorType);
                }
            }
            return _contributorTypes;
        }

        public IEnumerable<ContributorType> Query<TT>(Predicate<TT> queryCriteria)
        {
            throw new NotImplementedException();
        }

        public void Insert(ContributorType dataObject)
        {
            _contributorTypes.Add(dataObject);
        }

        public void InsertAll(IList<ContributorType> dataObjects)
        {
            foreach (var contributorType in dataObjects)
            {
                _contributorTypes.Add(contributorType);
            }
        }
    }
}
