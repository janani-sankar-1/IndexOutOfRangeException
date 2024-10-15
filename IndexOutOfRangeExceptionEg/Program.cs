using System;
using System.Collections.Generic;

namespace IndexOutOfRangeExceptionEg
{
     class Program
    {
        class BankAccount
        {
            public string AccountHolderName { get; set; } 
            public int AccountNumber { get; set; }
            public double CurrentBalance { get; set; }
        }
        static void Main(string[] args)
        {
            try
            {
                BankAccount[] bankaccount = new BankAccount[]{
                new BankAccount(){AccountNumber=101,AccountHolderName="John",CurrentBalance=1200},
                new BankAccount(){AccountNumber=102,AccountHolderName="Maya",CurrentBalance=2300},
            };
                for (int i = 0; i < bankaccount.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{bankaccount[i].AccountNumber},{bankaccount[i].AccountHolderName},{bankaccount[i].CurrentBalance}");
                }
                int serialNumber;
                Console.Write("Enter account serial number to print:");
                serialNumber = int.Parse(Console.ReadLine());
                serialNumber--;
                //if (serialNumber < 0 || serialNumber >= bankaccount.Length)
                //{
                  //  Console.WriteLine("Invalid serial number");
                //}
                //else
                {

                    BankAccount selectedBankAccount = bankaccount[serialNumber];
                    Console.WriteLine("selected bank account details");
                    Console.WriteLine("Account number:" + selectedBankAccount.AccountNumber);
                    Console.WriteLine("Account holder name:" + selectedBankAccount.AccountHolderName);
                    Console.WriteLine("Current Balance:" + selectedBankAccount.CurrentBalance);

                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
