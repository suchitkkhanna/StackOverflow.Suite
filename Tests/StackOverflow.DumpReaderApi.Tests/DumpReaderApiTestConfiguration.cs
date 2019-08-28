using Autofac;

namespace StackOverflow.DumpReaderApi.Tests
{
    public class DumpReaderApiTestConfiguration
    {
        private static IContainer _container;

        public static void SetUp()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new DumpReaderApiModule());

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}