using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace StokSatisOtomasyonu.DAL
{
    public class ReportDAL
    {
        // 1. Aylık Satış Raporu
        public DataTable GetMonthlySales()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"SELECT COUNT(*) as ToplamSatis, SUM(TotalPrice) as ToplamCiro 
                                 FROM Sales 
                                 WHERE MONTH(SaleDate) = MONTH(CURDATE()) 
                                 AND YEAR(SaleDate) = YEAR(CURDATE())";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // 2. En Çok Satılan Ürünler
        public DataTable GetTopSellingProducts()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"SELECT p.ProductName, SUM(s.Quantity) as ToplamAdet 
                                 FROM Sales s 
                                 JOIN Products p ON s.ProductId = p.Id 
                                 GROUP BY s.ProductId 
                                 ORDER BY ToplamAdet DESC LIMIT 5";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // 3. Müşteri Bazlı Satış
        public DataTable GetCustomerReport()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"SELECT c.FullName, SUM(s.TotalPrice) as HarcananTutar 
                                 FROM Sales s 
                                 JOIN Customers c ON s.CustomerId = c.Id 
                                 GROUP BY s.CustomerId 
                                 ORDER BY HarcananTutar DESC LIMIT 5";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // 4. Toplam Kâr Raporu
        public object GetTotalProfit()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT SUM((s.TotalPrice / s.Quantity - p.CostPrice) * s.Quantity) 
                                 FROM Sales s 
                                 JOIN Products p ON s.ProductId = p.Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }

        // 5. Kritik Stok Raporu
        public DataTable GetCriticalStock()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT ProductName, StockQuantity FROM Products WHERE StockQuantity < 10 ORDER BY StockQuantity ASC";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // --- ANASAYFA İÇİN YENİ EKLENEN SORGULAR ---

        // 6. Toplam Stok Miktarı (Anasayfa için)
        public object GetTotalStockAmount()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(StockQuantity) FROM Products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }

        // 7. Günlük Kazanç (Anasayfa için bugün yapılan satışlar)
        public object GetDailyEarnings()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(TotalPrice) FROM Sales WHERE DATE(SaleDate) = CURDATE()";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }
    }
}