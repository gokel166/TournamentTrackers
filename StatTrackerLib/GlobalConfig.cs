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
        public static IDataConnections Connections { get; private set; }

        public static void InitializeConnections(string connectionType)
        {
            if (connectionType == "sql")
            {
                // Set up SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }
            
            else if (connectionType == "text")
            {
                // Create the Text Connection
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
