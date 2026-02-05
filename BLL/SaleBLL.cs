using System;
using System.Data;
using StokSatisOtomasyonu.DAL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.BLL
{
    public class SaleBLL
    {
        SaleDAL sDal = new SaleDAL();

        public DataTable TumSatislariGetir()
        {
            return sDal.GetAllSales();
        }

        public int ToplamSatisSayisi()
        {
            DataTable dt = sDal.GetAllSales();
            return dt.Rows.Count;
        }

        public void SatisYap(Sale s)
        {
            if (s.Quantity <= 0)
                throw new Exception("Satış adedi 1 veya daha fazla olmalıdır!");

            sDal.Add(s);
        }

        // --- SATIŞ SİLME İÇİN EKLEDİĞİMİZ METOD (YENİ) ---
        public void SatisSil(int satisId, int urunId, int miktar)
        {
            if (satisId <= 0)
                throw new Exception("Geçerli bir satış seçilmedi!");

            // DAL katmanındaki Delete metodunu çağırarak hem kaydı siliyoruz hem stoğu artırıyoruz
            sDal.Delete(satisId, urunId, miktar);
        }
    }
}