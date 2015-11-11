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
                                    "database=dbi333151;" +
                                    "user id=i333151;" +
                                    "password=Chuotchit1504@" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
    }
}
