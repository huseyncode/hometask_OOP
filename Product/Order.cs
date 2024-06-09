using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Order
    {
        private List<Product> products = new List<Product>();
        public IReadOnlyList<Product> Products => products.AsReadOnly();

        public void AddProduct(Product product)
        {
            if (products.Count >= 10)
            {
                Console.WriteLine("Order is full. Cannot add more products.");
                return;
            }
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (!products.Remove(product))
            {
                Console.WriteLine("This product is not in the order.");
            }
        }

        public void GetDetails()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
            }
        }

        public decimal GetTotalAmount()
        {
            return products.Sum(p => p.Price);
        }
    }
}
