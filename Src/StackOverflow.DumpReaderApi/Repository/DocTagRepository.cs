using System;
using System.Collections.Generic;
using System.Linq;
using StackOverflow.DumpReaderApi.Dao;

namespace StackOverflow.DumpReaderApi.Repository
{
    public class DocTagRepository : IRepository<DocTag>
    {
        private readonly IDao _dao;
        private readonly IList<DocTag> _docTags = new List<DocTag>();

        public DocTagRepository(IDao dao)
        {
            _dao = dao;
        }

        public IEnumerable<DocTag> QueryAll()
        {
            if (!_docTags.Any())
            {
                IEnumerable<DocTag> result = _dao.Read<DocTag>("doctags.json");
                foreach (var docTag in result)
                {
                    _docTags.Add(docTag);
                }
            }

            return _docTags;
        }

        public IEnumerable<DocTag> Query<TT>(Predicate<TT> queryCriteria)
        {
            throw new NotImplementedException();
        }

        public void Insert(DocTag dataObject)
        {
            throw new NotImplementedException();
        }

        public void InsertAll(IList<DocTag> dataObjects)
        {
            throw new NotImplementedException();
        }
    }
}