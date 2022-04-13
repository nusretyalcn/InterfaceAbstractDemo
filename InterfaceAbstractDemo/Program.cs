
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entitiy;
using System;

namespace InterfaceAbstractDemo
{

    class Program
    {
        static void Main(string[] args)
        {

            Abstact.BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { DateOfBirth=new DateTime(1998,1,27 ),Name="Nusret",LastName="Yalçın",NationalityId="12345678912"});
           
        }
    }
}
