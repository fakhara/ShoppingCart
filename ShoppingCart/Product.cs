using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PriceType { get; set; }

        public Product(int productId, string name, decimal price, string priceType)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            PriceType = priceType;
        }
    }
}
