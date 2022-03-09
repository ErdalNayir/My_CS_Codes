using BankProject2.Abstract;
using BankProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject2.Concrete
{
    class CustomerService : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerService(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Kullanıcı Eklendi");
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
            
        }

        public void DepositMoney(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                double moneyForDeposit;

                Console.WriteLine("How much money do you want to deposit to your bank account?: ");
                moneyForDeposit = Convert.ToDouble(Console.ReadLine());

                customer.Balance += moneyForDeposit;
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
