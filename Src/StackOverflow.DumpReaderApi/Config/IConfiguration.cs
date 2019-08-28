namespace StackOverflow.DumpReaderApi.Config
{
    public interface IConfiguration
    {
        /// <summary>
        /// Gets the path to resource that needs to be accessed
        /// </summary>
        string ResourceUri { get; }

        /// <summary>
        /// Gets the user identifier for accessing the resource
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// Gets the credentials for accessing the resource
        /// </summary>
        string Credential { get; }
    }
}