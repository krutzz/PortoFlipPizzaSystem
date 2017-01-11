﻿using ProtoFlipPizzaSystem.Models.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoFlipPizzaSystem.Models.Administrator.Contacts;

namespace ProtoFlipPizzaSystem.Models.Client.Order
{
    class Order : IOrder
    {

        private IProduct product;
        private int quantity;

        public Order(IProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public IProduct Product
        {
            get
            {
                return this.product;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (quantity <= 0)
                {
                    throw new ArgumentOutOfRangeException("The quantity of product must be a positive number");
                }
                this.quantity = value;
            }
        }

        public double TotalProductPrice
        {
            get
            {
                return Product.calculatePrice() * quantity;
            }
        }

        public double CalculateTotalOrderPrice(List<IOrder> order)
        {
            double sum = 0;
            foreach (var element in order)
            {
                sum += element.TotalProductPrice;
            }
            return sum;
        }
    }
}
