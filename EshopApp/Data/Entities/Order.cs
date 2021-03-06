﻿using System;
using System.Collections.Generic;

namespace EshopApp.Data.Entities
{
    public class Order
    {

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public ICollection<OrderItem> Items { get; set; }

        public decimal Price { get; set; }
        public bool isComplete { get; set; }
    }
}

