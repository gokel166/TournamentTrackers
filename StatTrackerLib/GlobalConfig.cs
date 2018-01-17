using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTrackerLib
{
    public class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database)
            {
                // Create the SQL Connection
            }

            if (textFiles)
            {
                // Create the Text Connection
            }
        }
    }
}
