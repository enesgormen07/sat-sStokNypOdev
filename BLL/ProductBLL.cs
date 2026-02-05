using System;
using System.Data;
using StokSatisOtomasyonu.DAL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.BLL
{
    public class ProductBLL
    {
        ProductDAL pDal = new ProductDAL();

        public DataTable TumUrunleriGetir()
        {
            return pDal.GetAll();
        }

        // --- ANA SAYFA İÇİN TOPLAM SAYI METODU (YENİ) ---
        public int ToplamUrunSayisi()
        {
            DataTable dt = pDal.GetAll();
            return dt.Rows.Count;
        }

        public void YeniUrunEkle(Product p)
        {
            if (string.IsNullOrEmpty(p.ProductName))
                throw new Exception("Ürün adı boş olamaz!");

            pDal.Add(p);
        }

        public void UrunGuncelle(Product p)
        {
            if (p.Id <= 0)
                throw new Exception("Güncellenecek ürünün ID'si geçerli değil!");

            if (string.IsNullOrEmpty(p.ProductName))
                throw new Exception("Ürün adı boş olamaz!");

            pDal.Update(p);
        }

        public void UrunSil(int id)
        {
            if (id <= 0)
                throw new Exception("Silinecek ürünün ID'si geçerli değil!");

            pDal.Delete(id);
        }
    }
}