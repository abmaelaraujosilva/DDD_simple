using System.Data;
using System.Data.SqlClient;

namespace DDD1.Infra.Context
{
    public class MSSQL : IDB
    {
        private SqlConnection DB;
        private string strcon;
        public MSSQL(IDBCofiguration config)
        {
            strcon = config.ConnectionString;
        }

        public void Dispose()
        {
            DB.Close();
            DB.Dispose();
        }

        public IDbConnection GetConnection()
        {
            DB = new SqlConnection(strcon);
            return DB;
        }
    }
}
