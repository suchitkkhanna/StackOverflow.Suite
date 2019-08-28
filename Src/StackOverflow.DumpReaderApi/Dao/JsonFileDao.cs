using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using StackOverflow.DumpReaderApi.Config;

namespace StackOverflow.DumpReaderApi.Dao
{
    public class JsonFileDao : IDao
    {

        private readonly IConfiguration _configuration;

        public JsonFileDao(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<TT> Read<TT>(string resourceName)
        {
            string qualifiedPath = _configuration.ResourceUri + "\\" + resourceName;
            IList<TT> dataObjects = new List<TT>();
            using (var fileStream = File.Open(qualifiedPath, FileMode.Open))
            using (var bufferedStream = new BufferedStream(fileStream))
            using (var streamReader = new StreamReader(bufferedStream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                jsonTextReader.SupportMultipleContent = true;
                var serializer = new JsonSerializer();
                while (jsonTextReader.Read())
                {
                    if (jsonTextReader.TokenType != JsonToken.StartObject) continue;
                    var dataObject = serializer.Deserialize<TT>(jsonTextReader);
                    dataObjects.Add(dataObject);
                }
            }

            return dataObjects;
        }
    }
}