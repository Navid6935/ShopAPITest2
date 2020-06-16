﻿using System;
using System.Collections.Generic;

namespace ShopAPITest2.Models
{
    public partial class OrdersItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Products Product { get; set; }
    }
}
