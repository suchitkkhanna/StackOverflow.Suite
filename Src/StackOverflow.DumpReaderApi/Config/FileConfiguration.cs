

namespace StackOverflow.DumpReaderApi.Config
{
    public class FileConfiguration : IConfiguration
    {

        public FileConfiguration(string resourceUri, string userName, string credentials)
        {
            ResourceUri = resourceUri;
            UserName = userName;
            Credential = credentials;
        }

        public string ResourceUri { get; }

        public string UserName { get; }

        public string Credential { get; }

        public override string ToString() => $"{ResourceUri}";
    }
}