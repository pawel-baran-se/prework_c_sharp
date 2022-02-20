using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additional_excersise_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Pawel", 2500);
            Console.WriteLine($"Account {account.Number} with the balance {account.Balance}");

            //try
            //{
            //    var invalidAccount = new BankAccount("Wrong", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine(account.GetAccountHistory());

            Console.ReadKey();
        }
    }

    

}