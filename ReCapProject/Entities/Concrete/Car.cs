using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

        public void Display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Araba Id: " + this.Id);
            Console.WriteLine("Araba Brand Id: " + this.BrandId);
            Console.WriteLine("Araba Color Id: " + this.ColorId);
            Console.WriteLine("Araba Model Year: " + this.ModelYear);
            Console.WriteLine("Araba Daily Price: " + this.DailyPrice);
            Console.WriteLine("Araba Description: " + this.Description);
            Console.WriteLine("\n\n");
        }
    }
}
