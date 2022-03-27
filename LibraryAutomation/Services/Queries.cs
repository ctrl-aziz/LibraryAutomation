using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Services
{
    internal class Queries
    {
        public List<string> keys = new List<string>();
        public List<string> values = new List<string>();

        public Queries(List<string> keys, List<string> values)
        {
            this.keys = keys;
            this.values = values;
        }

        public Queries()
        {
        }

        public string GetInsertQuery(string tableName)
        {
            return $"insert into {tableName} ({string.Join(",", keys)}) values({string.Join(",", values)});";
        }

        public string GetUpdateQuery(string tableName, string fieldName, int id)
        {
            string updateText = "";
            for (int i = 0; i < keys.Count; i++)
            {
                updateText += $"{keys[i]}={values[i]}";
            }
            return $"Update {tableName} set {updateText} where {fieldName}={id};";
        }

        public string GetDeleteQuery(string tableName, string fieldName, int id)
        {
            return $"Delete from {tableName} where {fieldName}={id}";
        }


        public string GetDataQuery(string tableName, string fieldName, int id)
        {
            return $"Select * from {tableName} where {fieldName}={id}";
        }

        public string GetAllDataQuery(string tableName)
        {
            return $"Select * from {tableName}";
        }


    }
}
