using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal discount);   

    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal discountSize;
        public DefaultDiscountHelper(decimal discountSize)
        {
            this.discountSize = discountSize;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountSize / 100m * totalParam));
        }
    }
}
