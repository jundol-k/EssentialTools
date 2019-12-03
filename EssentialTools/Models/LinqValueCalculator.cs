using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper _discountHelper;
        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            _discountHelper = discountParam;
            Console.WriteLine(string.Format("instance {0} created", ++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return _discountHelper.ApplyDiscount(products.Sum(x => x.Price));
        }
    }
}