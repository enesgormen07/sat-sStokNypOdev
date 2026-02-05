using StokSatisOtomasyonu.DAL; // DAL'daki UserDAL'a ulaşmak için
using StokSatisOtomasyonu.Domain; // User nesnesi için
using System;

namespace StokSatisOtomasyonu.BLL
{
    public class UserBLL
    {
        // DAL katmanındaki sınıfımızdan bir nesne türetiyoruz
        UserDAL userDAL = new UserDAL();

        public User LoginKontrol(string username, string password)
        {
            // İŞ KURALI 1: Boş giriş kontrolü
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Kullanıcı adı veya şifre boş bırakılamaz!");
            }

            // İŞ KURALI 2: DAL katmanına git ve veritabanı sorgusunu yap
            User loginYapanUser = userDAL.Login(username, password);

            // İŞ KURALI 3: Kullanıcı bulunamadıysa uyarı ver
            if (loginYapanUser == null)
            {
                throw new Exception("Hatalı kullanıcı adı veya şifre!");
            }

            return loginYapanUser; // Her şey tamamsa kullanıcıyı döndür
        }
    }
}