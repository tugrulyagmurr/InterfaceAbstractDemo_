using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo_.Abstract;
using InterfaceAbstractDemo_.Entities;

namespace InterfaceAbstractDemo_.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
            
        } 
    }
}
