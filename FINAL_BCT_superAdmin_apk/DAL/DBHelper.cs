using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BCT_superAdmin_apk.DAL
{
    public class DBHelper
    {
        //DATABASE CONNECTION--->
        private MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;" +
                             "port=3306;" +
                             "database=BCT_db;" +
                             "user=root;" +
                             "password=;";
            return new MySqlConnection(connStr);
        }//<----
    }
}
