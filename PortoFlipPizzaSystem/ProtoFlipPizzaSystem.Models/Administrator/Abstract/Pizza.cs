﻿using System.Collections.Generic;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;
using ProtoFlipPizzaSystem.Models.Administrator.Structures;

namespace ProtoFlipPizzaSystem.Models.Administrator.Abstract
{
    public abstract class Pizza : Food, IPizza
    {
        public Pizza(string name, List<ProductItem> ingredients)
            : base(name, ingredients)
        {
        }

        public decimal PizzaPremium { get; private set; } = 1.2M;

        public decimal Coeff { get; protected set; } = 0;

        public void SetPizzaPremium(decimal pizzaPremium)
        {
            this.PizzaPremium = pizzaPremium;
        }

        public void SetCoeff(decimal coeff)
        {
            this.Coeff = coeff;
        }

        public override decimal CalculatePrice()
        {
            decimal price = 0;

            foreach (var productItem in this.Ingredients)
            {
                price += productItem.Igredient.CalculatePrice() * productItem.Quantity;
            }

            price += price * (this.PizzaPremium + this.Coeff);

            return price;
        }
    }
}
