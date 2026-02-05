using MySql.Data.MySqlClient;
using System.Data;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.DAL
{
    public class ProductDAL
    {
        public DataTable GetAll()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Products";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public void Add(Product p)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Products (ProductName, StockQuantity, UnitPrice, CostPrice) VALUES (@name, @stock, @price, @cost)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", p.ProductName);
                cmd.Parameters.AddWithValue("@stock", p.StockQuantity);
                cmd.Parameters.AddWithValue("@price", p.UnitPrice);
                cmd.Parameters.AddWithValue("@cost", p.CostPrice);
                cmd.ExecuteNonQuery();
            }
        }

        // --- GÜNCELLEME METODU ---
        public void Update(Product p)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                // Sorgunun içine CategoryId=@catId ekledik
                string query = "UPDATE Products SET ProductName=@name, StockQuantity=@stock, UnitPrice=@price, CostPrice=@cost, Id=@catId WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", p.ProductName);
                cmd.Parameters.AddWithValue("@stock", p.StockQuantity);
                cmd.Parameters.AddWithValue("@price", p.UnitPrice);
                cmd.Parameters.AddWithValue("@cost", p.CostPrice);
                cmd.Parameters.AddWithValue("@catId", p.CategoryId); // Kategori buraya geldi
                cmd.Parameters.AddWithValue("@id", p.Id);

                cmd.ExecuteNonQuery();
            }
        }

        // --- SİLME METODU ---
        public void Delete(int id)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Products WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}