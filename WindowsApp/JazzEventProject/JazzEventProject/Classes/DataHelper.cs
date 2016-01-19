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
            String connectionInfo = "server=athena01.fhict.local;" +
                                   "database=dbi333702;" +
                                   "user id=dbi333702;" +
                                   "password=iQL8odhdQk;" +
                                   "connect timeout=30;";

           // String connectionInfo = "server=localhost;" +
             //                      "database=prop;" +
               //                    "Uid = root;" +
                 //                  "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
    }
}
