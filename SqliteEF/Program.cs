using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using DataLayer.Context;

namespace SqliteEF
{
    class Program
    {
        private static SqliteContext _dbSqliteContext;

        static void Main(string[] args)
        {
            String connectionString = "Sqlite Path";
            InitializeContext(connectionString);

            var examplesList = _dbSqliteContext.ModelOne.ToList();
        }

        public static bool InitializeContext(string connectionString)
        {
            try
            {
                SQLiteConnectionStringBuilder sqConn = new SQLiteConnectionStringBuilder();
                sqConn.DataSource = connectionString;
                _dbSqliteContext = new SqliteContext(sqConn.ConnectionString);
                return true;
            }
            catch (Exception exception)
            {
                throw;
                return false;
            }
        }
    }
}
