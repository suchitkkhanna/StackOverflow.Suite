using System;
using System.Collections.Generic;

namespace StackOverflow.DumpReaderApi.Repository
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Method to query all the objects
        /// </summary>
        /// <returns>Collection of objects of type <typeparam name="T"/></returns>
        IEnumerable<T> QueryAll();

        /// <summary>
        /// Method to query objects based on criteria
        /// </summary>
        /// <typeparam name="TT">The type of query criteria</typeparam>
        /// <param name="queryCriteria">The criteria to query</param>
        /// <returns>Collection of objects of type<see cref="T"/>Collection</returns>
        IEnumerable<T> Query<TT>(Predicate<TT> queryCriteria);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataObject"></param>
        void Insert(T dataObject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataObjects"></param>
        void InsertAll(IList<T> dataObjects);
    }
}