using Autofac;
using StackOverflow.DumpReaderApi.Config;
using StackOverflow.DumpReaderApi.Dao;
using StackOverflow.DumpReaderApi.Repository;

namespace StackOverflow.DumpReaderApi
{
    public class DumpReaderApiModule : Autofac.Module
    {
        private const string DumpFilePath = @"C:\Users\skhanna\Downloads\documentation-dump";
        private const string DumpFileUserName = "StackDumpReader";

        protected override void Load(ContainerBuilder builder)
        { 
            builder.Register(x => new FileConfiguration(DumpFilePath, DumpFileUserName, "")).As<IConfiguration>()
                .SingleInstance();
            builder.RegisterType<JsonFileDao>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ContributorTypeRepository>().AsImplementedInterfaces().SingleInstance();

            base.Load(builder);

        }
    }
}