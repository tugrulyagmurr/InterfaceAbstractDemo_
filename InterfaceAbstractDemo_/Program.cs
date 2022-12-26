using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo_.Abstract;
using InterfaceAbstractDemo_.Adapters;
using InterfaceAbstractDemo_.Concrete;
using InterfaceAbstractDemo_.Entities;

namespace InterfaceAbstractDemo_
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.save(new Customer
            {
                DateOfBirth = new DateTime(1999, 4, 30), FirstName = "Tuğrul", LastName = "Yağmur",
                NationalityId = "11111111111"
            });

            Console.ReadLine();
        }
    }
}
