using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace JazzEventProject.Classes
{
    class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            //Athena server
            //String connectionInfo = "server=athena01.fhict.local;" +
            //                       "database=dbi333702;" +
            //                       "user id=dbi333702;" +
            //                       "password=iQL8odhdQk;" +
            //                       "connect timeout=30;";

            //Local host
            //String connectionInfo = "server=localhost;" +
            //                       "database=prop;" +
            //                       "Uid = root;" +
            //                       "connect timeout=30;";

            //Amazon web service server
            String connectionInfo = "host = ec2-54-152-33-198.compute-1.amazonaws.com;" +
                                    "port = 3306;" +
                                    "database = ProP;" +
                                    "Uid = root;" +
                                    "password = prop;";
            connection = new MySqlConnection(connectionInfo);
        }
    }
}
