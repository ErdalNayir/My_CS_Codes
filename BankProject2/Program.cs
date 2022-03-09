using BankProject2.Adapters;
using BankProject2.Concrete;
using BankProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject2
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerService customerService = new CustomerService(new MernisServiceAdapter());

            customerService.Add(new Customer { Name = "Erdal", Surname = "NAYİR", BirthDate = new DateTime(Year, Month, Day), Balance = 10000, CreditCardLimit = 10000, NationalId = "TC is here" });
            Console.ReadLine();
        }
    }
}
