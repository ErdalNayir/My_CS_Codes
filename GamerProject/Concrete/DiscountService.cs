using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    class DiscountService 
    {
        public void AddNewDiscount(List<Entities.Discount> discounts, Entities.Discount discount)
        {
            discounts.Add(discount);
            Console.WriteLine("Yeni kampanya Eklendi");

        }

       
    }
}
