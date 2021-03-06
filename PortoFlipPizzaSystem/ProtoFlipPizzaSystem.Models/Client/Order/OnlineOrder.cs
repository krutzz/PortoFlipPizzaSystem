﻿using System;
using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Client.Structures;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
   public class OnlineOrder : Order
    {
        public OnlineOrder(List<OrderItem> products, int quantity, string comment) : base(products, quantity)
        {
            this.Comment = comment;
            this.Time = DateTime.Now;
        }

        public string Comment { get; private set; }

        public DateTime Time { get; private set; }
    }
}
