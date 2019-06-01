using DDD1.Infra.Context;

namespace DDD1.Application.Configuration
{
    public class MSSQLConfiguration : IDBCofiguration
    {
        public string ConnectionString { get => @"Server=ANDREW-SURFACE\ANDREW;Database=LTP5;User Id=sa;Password=123;"; }
    }
}
