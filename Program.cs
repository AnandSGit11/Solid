using solid;
using Solid;
using System;
namespace Solid
{
    public class main
    {


        public static void Main(string[] args)
        {
            //single responsibility prinicple

            Customerdetails customer = new Customerdetails();
            customer.bankCustomerId(1);
            customer.bankCustomerName("Subha");
            AccountCreate accreate = new AccountCreate();
            accreate.Create("111");

            //open closed principle

            Account acc = new Account();
            Account Deposit = new Deposit();
            Account Withdrawn = new Withdrawn();

            acc.GetAccount(10000);
            Deposit.GetAccount(10000);
            Withdrawn.GetAccount(10000);



            //liskov substitution principle

            Transaction transaction = new ValidTransaction();
            Console.WriteLine(transaction.Admit());
            transaction = new InvalidTransaction();
            Console.WriteLine(transaction.Admit());
            Console.ReadLine();


            //interface segregation principle

            TransactionAccount ta = new TransactionAccount();
            ta.Active("Account is active. Transaction can be made");
            ta.InActive("Account is inactive. Transaction cannot be made");
            Console.ReadLine();
            /* //dependency 

             IBank activity = new Savings();
             Bankactivity acctype = new Bankactivity(activity);
             acctype.Displayacctype() ; */



        }
    }
}