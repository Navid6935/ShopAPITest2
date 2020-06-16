﻿using System;
using System.Collections.Generic;

namespace ShopAPITest2.Models
{
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            Orders = new HashSet<Orders>();
        }

        public int SalesPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}