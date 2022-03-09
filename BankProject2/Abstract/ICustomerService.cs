using BankProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject2.Abstract
{
    public interface ICustomerService
    {
         void Add(Customer customer);

         void DepositMoney(Customer customer);
    }
}
