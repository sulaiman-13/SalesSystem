using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.DiscountStrategy
{
    public interface ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice);
    }
}
