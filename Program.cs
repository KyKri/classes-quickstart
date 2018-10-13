using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Xelyk", 10000000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance:C} initial balance.");

            Console.ReadKey();
        }
    }
}
