using System;
using System.Collections.Generic;
using System.Text;
using solid;

namespace solid
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(String name);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()    //Constructor
        {
        }

        public string GetCustomerName(string name)
        {
            return "Customer Name";
        }
    }

    public class CustomerDataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    public class CustomerLogic
    {
        ICustomerDataAccess _customerDataAccess;

        public CustomerLogic()
        {
            _customerDataAccess = CustomerDataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(String name)
        {
            return _customerDataAccess.GetCustomerName(name);
        }
    }
}
