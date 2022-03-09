using BankProject2.Abstract;
using BankProject2.Entities;
using BankProject2.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject2.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient();
            var newTc = Convert.ToInt64(customer.NationalId);
            return client.TCKimlikNoDogrula(newTc, customer.Name.ToUpper(), customer.Surname, customer.BirthDate.Year);
        }
}}
