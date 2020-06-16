using System;
using System.Collections.Generic;

namespace ShopAPITest2.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public DateTime? Date { get; set; }
        public double? Total { get; set; }
        public string Status { get; set; }
        public int CutomerId { get; set; }
        public int SalesPersonId { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
    }
}
