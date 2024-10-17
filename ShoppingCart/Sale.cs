using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Sale
    {
        public List<(Product product, int quantity)> Items { get; private set; }

        public Sale()
        {
            Items = new List<(Product product, int quantity)>(); 
        }
        public void AddProduct(Product product, int quantity)
        {
            Items.Add((product, quantity));
        }
        public decimal GetTotal()
        {
            return Items.Sum(item => item.product.Price * item.quantity);
        }
    }
}
