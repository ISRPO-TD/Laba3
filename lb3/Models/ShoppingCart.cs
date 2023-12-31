﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb3.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;
        public ShoppingCart(IValueCalculator calc)
        {
            this.calc = calc;
        }
        public IEnumerable<Product> products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(products);
        }
    }
}