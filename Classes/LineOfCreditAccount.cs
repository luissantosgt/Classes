using System;
using System.Collections.Generic;
using System.Text;
using Classes;

namespace MyBankAccount
{
   public class LineOfCreditAccount : BankAccount
    {

        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        { }
           public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Charge Monthly Interest");
            }
        }



    }
    
}
