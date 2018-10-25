using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();//private set - only methods inside of the GlobalConfig class can change the value of Connection but everyone can read the value of Connection
                                                                                //start from c# 6.0 we can initialize this list here
                    
        public static void InitializeConnection(bool dataBase, bool textFiles) //in future we can easy extend connection sources in this method
        {
            //Connections = new List<IDataConnection>(); // - initialing list before c# 6.0
            if (true == dataBase)
            {
                // TODO - Set up SQL connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if(true == textFiles)
            {
                //TODO - Create the Text Connextion
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        //static class which take connectionnString(database adress and access data) from App.config
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
