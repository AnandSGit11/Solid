using System;
using System.Collections.Generic;
using System.Text;

namespace solid
{
    public class Account
    {
        public virtual double GetAccount(double amount)
        {
            return amount - 10;
        }
    }

    public class Deposit : Account
    {
        public override double GetAccount(double amount)
        {
            return base.GetAccount(amount) + 50;
        }
    }
    public class Withdrawn : Account
    {
        public override double GetAccount(double amount)
        {
            return base.GetAccount(amount) - 50;
        }
    }

}

