using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatisOtomasyonu.Domain
{
    // BaseEntity'den miras alarak OOP kurallarını uyguluyoruz
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Yönetici, Satış Personeli veya Depo Görevlisi
    }
}
