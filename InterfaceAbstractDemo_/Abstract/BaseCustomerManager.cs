using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo_.Entities;

namespace InterfaceAbstractDemo_.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("Saved to Database : "+customer.FirstName);
        }
    }
}
