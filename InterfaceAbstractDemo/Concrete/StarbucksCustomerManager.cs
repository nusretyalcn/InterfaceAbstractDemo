using InterfaceAbstractDemo.Abstact;
using InterfaceAbstractDemo.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : Abstact.BaseCustomerManager
    {


        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }



        //ICustomerCheckService costumerCheckService = new CustomerCheckManager();
        //public override void Save(Customer customer)
        //{
        //    if (costumerCheckService.CheckIfRealPerson(customer))
        //    {
        //        base.Save(customer);
        //    }
        //    else
        //    {
        //        throw new Exception("Not a valid person");
        //    }

        //}


        //***********************************************************************************************

        //***********************************************************************************************

        //new CustomerCheckManager customerCheck = new CustomerCheckManager();

        //public override void Save(Customer customer)
        //{
        //    if (customerCheck.CheckIfRealPerson(customer))
        //    {
        //        base.Save(customer);
        //    }
        //    else
        //    {
        //        throw new Exception("Not a valid person");
        //    }
        //}
    }

}
