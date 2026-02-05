using System;
using System.Data;
using StokSatisOtomasyonu.DAL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu.BLL
{
    public class CustomerBLL
    {
        CustomerDAL cDal = new CustomerDAL();

        public DataTable TumMusterileriGetir()
        {
            return cDal.GetAll();
        }

        // --- ANA SAYFA İSTATİSTİĞİ İÇİN EKLEDİĞİMİZ METOD ---
        public int ToplamMusteriSayisi()
        {
            DataTable dt = cDal.GetAll();
            return dt.Rows.Count;
        }

        public void YeniMusteriEkle(Customer c)
        {
            if (string.IsNullOrEmpty(c.FullName))
                throw new Exception("Müşteri adı boş olamaz!");

            cDal.Add(c);
        }

        // SİLME METODU
        public void MusteriSil(int id)
        {
            cDal.Delete(id);
        }

        // GÜNCELLEME METODU
        public void MusteriGuncelle(Customer c)
        {
            if (string.IsNullOrEmpty(c.FullName))
                throw new Exception("Müşteri adı boş olamaz!");

            cDal.Update(c);
        }
    }
}