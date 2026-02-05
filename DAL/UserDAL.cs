using MySql.Data.MySqlClient;
using StokSatisOtomasyonu.Domain; // User sınıfını kullanabilmek için
using System;
using System.Data;

namespace StokSatisOtomasyonu.DAL
{
    public class UserDAL
    {
        public User Login(string username, string password)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                // Veritabanında kullanıcı adı ve şifreyi sorguluyoruz
                string query = "SELECT * FROM Users WHERE Username=@user AND Password=@pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Eşleşme varsa yeni bir User nesnesi oluşturup dolduruyoruz
                        return new User
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Username = dr["Username"].ToString(),
                            Role = dr["Role"].ToString() // Hocanın istediği Rol bilgisi burada geliyor [cite: 16]
                        };
                    }
                }
            }
            return null; // Kullanıcı bulunamazsa null döner
        }
    }
}