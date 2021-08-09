using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", -17.50);
            
            Console.Write(benben.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
