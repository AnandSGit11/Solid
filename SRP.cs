using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Customerdetails
    {
        public void bankCustomerId(int customerId)
        {
            Console.WriteLine(customerId);
        }



        public void bankCustomerName(String customername)
        {
            Console.WriteLine(customername);
        }
    }

    public class AccountCreate
    {
        public void Create(String accno)
        {
            Console.WriteLine("Accno is:" + accno);
        }


    }
}

