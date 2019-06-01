using System;
using System.Data;

namespace DDD1.Infra.Context
{
    public interface IDB : IDisposable
    {
        IDbConnection GetConnection();
    }
}
