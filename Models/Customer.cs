﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerLastName { get; set; }
        public string customerFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }

        public ICollection<Order> Order { get; set; }

    }
}