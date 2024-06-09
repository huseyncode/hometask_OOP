using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        public string Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public decimal CostCalculation(bool needEdv)
        {
            decimal total = Price * Quantity;
            if (needEdv)
            {
                total += total * 0.18m;
            }
            return total;
        }
    }
}
