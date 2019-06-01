using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD1.Infra.Context
{
    public interface IDBCofiguration
    {
        string ConnectionString { get; }
    }
}
