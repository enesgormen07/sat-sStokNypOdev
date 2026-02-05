using System;

namespace StokSatisOtomasyonu.Domain
{
    public class Sale : BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}