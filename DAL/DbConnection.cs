using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

   

    namespace StokSatisOtomasyonu.DAL
    {
        public class DbConnection
        {
            // Senin verdiğin sunucu bilgileri
            private static string connectionString = "Server=172.21.54.253;Database=26_132430059;Uid=26_132430059;Pwd=İnif123.;";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
