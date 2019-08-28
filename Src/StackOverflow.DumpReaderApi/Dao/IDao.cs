using System.Collections.Generic;
using StackOverflow.DumpReaderApi.Config;

namespace StackOverflow.DumpReaderApi.Dao
{
    public interface IDao
    {
        /// <summary>
        /// Method to read data from underlying source
        /// </summary>
        /// <typeparam name="TT">The type of data object</typeparam>
        /// <returns>Collection of data</returns>
        IEnumerable<TT> Read<TT>(string resourceName);
    }
}