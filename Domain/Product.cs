using System;

namespace StokSatisOtomasyonu.Domain
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int CategoryId { get; set; }
    }
}