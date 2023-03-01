using MyBankAccount;
using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("ale", 10000);
            Console.WriteLine($"The bank account number {account.Number} is from {account.Owner} with a balance of {account.Balance}");

            account.MakeWithDrawal(5000, DateTime.Now, "minus");

            account.MakeDeposit(3000, DateTime.Now, "savings");
            Console.WriteLine(account.Balance);

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            // How much is too much to borrow?
            lineOfCredit.MakeWithDrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithDrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

        }
    }
}