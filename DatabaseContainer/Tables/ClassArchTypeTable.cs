using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContainer.Tables
{
    class ClassArchTypeTable : BaseTable
    {
        private const string TableName = "ClassArchType";

        private const string ColumnGuid = "Guid";
        private const string ColumnName = "Name";

        protected override string GetCreateStatement()
        {
            return "CREATE TABLE IF NOT EXISTS " + TableName + " ("
                   + ColumnGuid + " BLOB PRIMARY KEY"
                   + "," + ColumnName + " TEXT"
                   + ");";
        }

        public SQLiteDataReader Get(string guid)
        {
            return GetInternal("SELECT * FROM " + TableName + " WHERE " + ColumnGuid + "=" + guid);
        }
    }
}
