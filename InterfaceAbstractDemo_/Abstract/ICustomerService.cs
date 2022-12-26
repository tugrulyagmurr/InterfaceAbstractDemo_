using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo_.Entities;

namespace InterfaceAbstractDemo_.Abstract
{
    public interface ICustomerService
    {
        void save(Customer customer);
    }
}
