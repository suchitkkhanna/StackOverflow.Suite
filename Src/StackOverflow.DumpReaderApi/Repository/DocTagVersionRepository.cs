using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using StackOverflow.Domain;
using StackOverflow.DumpReaderApi.Dao;

namespace StackOverflow.DumpReaderApi.Repository
{
    public class DocTagVersionRepository : IRepository<DocTagVersion>
    {
        private readonly IDao _dao;
        private readonly IList<DocTagVersion> _docTagVersions;

        public DocTagVersionRepository(IDao dao)
        {
            _dao = dao;
            _docTagVersions = new List<DocTagVersion>();
        }

        public IEnumerable<DocTagVersion> QueryAll()
        {
            if (!_docTagVersions.Any())
            {
                IEnumerable<DocTagVersion> result = _dao.Read<DocTagVersion>("doctagversions.json");
                foreach (var docTagVersion in result)
                {
                    _docTagVersions.Add(docTagVersion);
                }
            }

            return _docTagVersions;
        }

        public IEnumerable<DocTagVersion> Query<TT>(Predicate<TT> queryCriteria)
        {
            throw new NotImplementedException();
        }

        public void Insert(DocTagVersion dataObject)
        {
            throw new NotImplementedException();
        }

        public void InsertAll(IList<DocTagVersion> dataObjects)
        {
            throw new NotImplementedException();
        }
    }
}