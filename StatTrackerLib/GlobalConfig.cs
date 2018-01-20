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

        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database)
            {
                // Set up SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }
            
            else if (textFiles)
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
