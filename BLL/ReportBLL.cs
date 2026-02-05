using System;
using System.Data;
using StokSatisOtomasyonu.DAL;

namespace StokSatisOtomasyonu.BLL
{
    public class ReportBLL
    {
        ReportDAL rDal = new ReportDAL();

        public DataTable AylikSatisGetir()
        {
            return rDal.GetMonthlySales();
        }

        public DataTable EnCokSatanUrunleriGetir()
        {
            return rDal.GetTopSellingProducts();
        }

        public DataTable MusteriRaporuGetir()
        {
            return rDal.GetCustomerReport();
        }

        public string ToplamKarGetir()
        {
            object kar = rDal.GetTotalProfit();
            // Eğer veritabanı boşsa 0 döndür, doluysa ₺ simgesiyle metin olarak döndür
            return (kar != DBNull.Value && kar != null) ? Convert.ToDecimal(kar).ToString("C2") : "0,00 ₺";
        }

        public DataTable KritikStokGetir()
        {
            return rDal.GetCriticalStock();
        }

        // --- ANASAYFA İÇİN YENİ EKLENEN METODLAR ---

        public string ToplamStokSayisiGetir()
        {
            // Tüm ürünlerin toplam stok adedini döndürür
            object toplam = rDal.GetTotalStockAmount();
            return (toplam != DBNull.Value && toplam != null) ? toplam.ToString() : "0";
        }

        public string GunlukKazancGetir()
        {
            // Sadece bugüne ait toplam ciroyu döndürür
            object kazanc = rDal.GetDailyEarnings();
            return (kazanc != DBNull.Value && kazanc != null) ? Convert.ToDecimal(kazanc).ToString("C2") : "0,00 ₺";
        }
    }
}