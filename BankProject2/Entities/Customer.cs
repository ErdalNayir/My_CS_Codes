using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject2.Entities
{
    public class Customer : IEntities
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String NationalId { get; set; }
        public DateTime BirthDate { get; set; }
        public double Balance { get; set; }
        public float CreditCardLimit { get; set; }

        void  ToString()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Date of Birth: " + BirthDate.ToString());
            Console.WriteLine("Balance: " + Balance);

        }
    }


}
