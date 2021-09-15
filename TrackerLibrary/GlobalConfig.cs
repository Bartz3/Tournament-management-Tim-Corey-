using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }// only methods inside of this global class can change the value of Connections,
                                                                      // but everyone can read the value of Connections
        public static void InitializeConnections(DatabaseType db)
        {
            if (db ==DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly.
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if(db==DatabaseType.TextFile)
            {
                //TODO  CreateTextCollection
                TextConnector text = new TextConnector();
                Connection = text;            
            }
            
        }

        public static string CnnString(string name) //connectionString="Server=.\sql2019;Database=Tournaments;Trusted_Connection=True;"
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
