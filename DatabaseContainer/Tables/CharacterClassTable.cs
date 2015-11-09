using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContainer.Tables
{
    class CharacterClassTable : BaseTable
    {
        private const string TableName = "CharacterClass";

        private const string ColumnGuid = "guid";
        private const string ColumnName = "name";
        private const string ColumnArchTypeId = "class_arch_type_id";

        protected override string GetCreateStatement()
        {
            return "CREATE TABLE IF NOT EXISTS " + TableName + " ("
                   + ColumnGuid + " BLOB PRIMARY KEY"
                   + "," + ColumnName + " TEXT"
                   + "," + ColumnArchTypeId + " BLOB"
                   + ");";
        }

        protected SQLiteDataReader Get(Guid guid)
        {
            return GetInternal("");
        }

        protected SQLiteDataReader GetForArchType(Guid guid)
        {
            return GetInternal("");
        }
    }
}
