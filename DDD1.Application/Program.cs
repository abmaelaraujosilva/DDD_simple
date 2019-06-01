using DDD1.Application.Configuration;
using DDD1.Domain.Commands.Handles;
using DDD1.Domain.Repository;
using DDD1.Infra.Context;
using DDD1.Infra.Repository;
using SimpleInjector;

namespace DDD1.Application
{
    class Program
    {
        private static Container container;
        static void Main(string[] args)
        {
            Bootstrap();
        }
        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<IDB, MSSQL>(Lifestyle.Scoped);
            container.Register<ICustomerRepository, CustomerRepository>(Lifestyle.Transient);
            container.Register<IDBCofiguration, MSSQLConfiguration>(Lifestyle.Transient);
            container.Register<CustomerCommandHandler>(Lifestyle.Transient);
        }
    }
}
