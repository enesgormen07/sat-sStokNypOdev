using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatisOtomasyonu.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } // Kapsülleme (Encapsulation) 
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}
