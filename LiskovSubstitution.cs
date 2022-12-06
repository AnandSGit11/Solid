using System;
using System.Collections.Generic;
using System.Text;

namespace solid
{
    public abstract class Transaction
    {
        public abstract string Admit();
    }
    public class ValidTransaction : Transaction
    {
        public override string Admit()
        {
            return "valid";
        }

    }
    public class InvalidTransaction : Transaction
    {
        public override string Admit()
        {
            return "Invalid";
        }

    }
}
