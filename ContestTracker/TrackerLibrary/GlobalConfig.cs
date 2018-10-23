using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }//private set - only methods inside of the GlobalConfig class can change the value of Connection but everyone can read the value of Connection

        public static void InitializeConnection(bool dataBase, bool textFiles)
        {
            if (true == dataBase)
            {
                // TODO - Create the SQL connection
            }

            if(true == textFiles)
            {
                //TODO - Create the Text Connextion
            }
        }
    }
}
