using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BestBuyBestPractices
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

    }
}
