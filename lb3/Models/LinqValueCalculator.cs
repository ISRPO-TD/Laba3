using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb3.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private static int _counter = 0;
        private IDiscountHelper _discountHelper;
        public LinqValueCalculator(IDiscountHelper discountHelper)
        {
            _discountHelper = discountHelper;
            System.Diagnostics.Debug.WriteLine(
                string.Format("Instance {0} created", ++_counter));
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return _discountHelper.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}