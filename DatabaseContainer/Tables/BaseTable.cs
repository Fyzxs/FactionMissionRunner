using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContainer.Tables
{
    abstract class BaseTable
    {
        protected abstract string GetCreateStatement();

        public void Create()
        {
            using (var connection = SqlMasterInterface.GetNewConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = GetCreateStatement();
                    command.ExecuteNonQuery();
                }
            }
        }


        protected SQLiteDataReader GetInternal(string selectStatement)
        {
            using (var connection = SqlMasterInterface.GetNewConnection())
            {
                connection.Open();

                var strSqlCommand = selectStatement;

                using (var cmd = new SQLiteCommand(strSqlCommand, connection))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        connection.Close();
                        return rdr;
                    }
                }
            }
        }
    }
}
