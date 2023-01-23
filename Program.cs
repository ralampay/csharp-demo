using CSharpDemo.Models;
using System.Collections;

namespace CSharpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**
            EXERCISE: 

            1. Create a class called Transaction with the following attributes:
            - amount (float)
            - transactionType (string) --> W for Withdraw or D for Deposit

            2. Inside BankAccount class, create a private attribute called transactions which is a List of Transactions:

            private List<Transaction> transactions;

            Make sure to instantiate it in the constructor of BankAccount class.

            3. In Program.cs, create an instance of a customer and bank account.

            4. Display a menu that contains the following:

            1 - Deposit
            2 - Withdraw
            3 - View Balance
            ==================
            Enter Number: 

            5. Ask the user to enter a number. Depending on the input of the user:
                - if 1 then ask user for amount to deposit and perform deposit. Add a new transaction object in the bank account's transactions list.
                - if 2 then ask user for amount to withdraw and perform withdraw. Add a new transaction object in the bank account's transactions list.
                - if 3 then display the user's current balance.

            6. Before the program ends, display the transactions of the bank account.

            **/
            /*
            List<BankAccount> bankAccounts = new List<BankAccount>();

            // Ask user to input details of customer
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Middle Name: ");
            string middleName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            // Create an instance of a customer
            Customer c = new Customer(firstName, middleName, lastName);

            Console.WriteLine("Customer created: " + c.FullName());

            // Ask user to input account number
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            // Create a bank account and assign created customer
            BankAccount bankAccount = new BankAccount(accountNumber, c);
            Console.WriteLine("Bank Account " + bankAccount.GetAccountNumber() + " created for customer " + bankAccount.GetCustomer().FullName());
        
            // Inserts a bankAccount which is of type BankAccount into bankAccounts
            bankAccounts.Add(bankAccount);
            */
        }
    }
}
