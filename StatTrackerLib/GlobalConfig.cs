using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatTrackerLib.DataAccess;

namespace StatTrackerLib.Models
{
    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default:
                    break;
            }

            if (db == DatabaseType.Sql)
            {
                // Set up SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            
            else if (db == DatabaseType.TextFile)
            {
                // Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
