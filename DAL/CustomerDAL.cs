using MySql.Data.MySqlClient;
using System.Data;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.DAL
{
    public class CustomerDAL
    {
        // Tüm müşterileri listelemek için
        public DataTable GetAll()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Customers";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // Yeni müşteri eklemek için
        public void Add(Customer c)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customers (FullName, PhoneNumber, Email, Address) VALUES (@name, @phone, @email, @address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", c.FullName);
                cmd.Parameters.AddWithValue("@phone", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.ExecuteNonQuery();
            }
        }

        // Müşteri silmek için (YENİ EKLENDİ)
        public void Delete(int id)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Customers WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Müşteri güncellemek için (YENİ EKLENDİ)
        public void Update(Customer c)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Customers SET FullName=@name, PhoneNumber=@phone, Email=@email, Address=@address WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", c.FullName);
                cmd.Parameters.AddWithValue("@phone", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}