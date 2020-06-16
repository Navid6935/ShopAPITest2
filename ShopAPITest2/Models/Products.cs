using System;
using System.Collections.Generic;

namespace ShopAPITest2.Models
{
    public partial class Products
    {
        public Products()
        {
            OrdersItem = new HashSet<OrdersItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Size { get; set; }
        public string Variently { get; set; }
        public double? Price { get; set; }
        public string Status { get; set; }

        public virtual ICollection<OrdersItem> OrdersItem { get; set; }
    }
}
