using InterfaceAbstractDemo.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstact
{
    public interface ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer);
        
    }
}
