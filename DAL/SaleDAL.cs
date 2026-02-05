using MySql.Data.MySqlClient;
using System.Data;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.DAL
{
    public class SaleDAL
    {
        // Yeni Satış Ekleme ve Stoktan Düşme
        public void Add(Sale s)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // 1. ADIM: Sales tablosuna kayıt ekle
                string query = "INSERT INTO Sales (ProductId, CustomerId, Quantity, TotalPrice) VALUES (@pid, @cid, @qty, @total)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", s.ProductId);
                cmd.Parameters.AddWithValue("@cid", s.CustomerId);
                cmd.Parameters.AddWithValue("@qty", s.Quantity);
                cmd.Parameters.AddWithValue("@total", s.TotalPrice);
                cmd.ExecuteNonQuery();

                // 2. ADIM: Stok güncelleme (Azaltma)
                string updateStock = "UPDATE Products SET StockQuantity = StockQuantity - @qty WHERE Id = @pid";
                MySqlCommand cmdUpdate = new MySqlCommand(updateStock, conn);
                cmdUpdate.Parameters.AddWithValue("@qty", s.Quantity);
                cmdUpdate.Parameters.AddWithValue("@pid", s.ProductId);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        // SATIŞ SİLME VE STOĞU GERİ YÜKLEME (YENİ)
        public void Delete(int satisId, int urunId, int miktar)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // 1. İşlem: Satış kaydını veritabanından sil
                string deleteQuery = "DELETE FROM Sales WHERE Id = @sid";
                MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn);
                cmdDelete.Parameters.AddWithValue("@sid", satisId);
                cmdDelete.ExecuteNonQuery();

                // 2. İşlem: Silinen satışın miktarını ürün stoğuna geri ekle
                string updateStock = "UPDATE Products SET StockQuantity = StockQuantity + @qty WHERE Id = @pid";
                MySqlCommand cmdUpdate = new MySqlCommand(updateStock, conn);
                cmdUpdate.Parameters.AddWithValue("@qty", miktar);
                cmdUpdate.Parameters.AddWithValue("@pid", urunId);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        // Tüm Satışları Listeleme
        public DataTable GetAllSales()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                // ProductId'yi de çekiyoruz ki silme yaparken hangi ürünün stoğunu artıracağımızı bilelim
                string query = @"SELECT s.Id, s.ProductId, c.FullName AS 'Müşteri', p.ProductName AS 'Ürün', 
                                 s.Quantity AS 'Adet', s.TotalPrice AS 'Toplam Tutar' 
                                 FROM Sales s 
                                 JOIN Customers c ON s.CustomerId = c.Id 
                                 JOIN Products p ON s.ProductId = p.Id";

                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }
    }
}