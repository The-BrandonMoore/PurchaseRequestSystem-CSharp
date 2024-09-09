

namespace PurchaseRequestSystem.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string VendorId { get; set; }
        public string PartNumber { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

        public Product(int id, string vendorid, string partnumber, string productName, decimal price, string unit)
        {
            Id = id;
            VendorId = vendorid;
            PartNumber = partnumber;
            ProductName = productName;
            Price = price;
            Unit = unit;
        }
    }
}
