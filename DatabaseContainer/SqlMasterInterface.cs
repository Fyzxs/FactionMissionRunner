using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContainer
{
    internal class SqlMasterInterface
    {
        private const string ConnectionString = @"Data Source=mydb.db;Version=3;";

        public static SQLiteConnection GetNewConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}
