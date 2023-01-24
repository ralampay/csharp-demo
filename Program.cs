using CSharpDemo.Models;
using System.Collections;

namespace CSharpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("A", "B", "C");
            CheckingAccount checkingAccount = new CheckingAccount("060081", c);

            Console.WriteLine("Account Number: " + checkingAccount.GetAccountNumber());
            Console.WriteLine("Num of Checks: " + checkingAccount.CheckBook.Count);

            foreach(Check check in checkingAccount.CheckBook)
            {
                Console.WriteLine(check.CheckNumber + ": " + check.Amount);
            }

            BankAccount bankAccount = new BankAccount("060082", c);

            checkingAccount.DisplayBalance();
            Console.WriteLine("=====================");
            bankAccount.DisplayBalance();
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

            // Ask user to input details of customer
            /*
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

            bool isContinue = true;

            while (isContinue)
            {
                // Create the menu
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - View Balance");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("====================");
                Console.Write("Enter Number: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    // Perform Deposit
                    Console.Write("Enter Amount: ");
                    float amount = float.Parse(Console.ReadLine());
                    string transactionType = "D";

                    bankAccount.Deposit(amount);

                    Transaction t = new Transaction(amount, transactionType);
                    bankAccount.AddTransaction(t);
                }
                else if (choice == 2)
                {
                    // Perform Withdrawal
                    Console.Write("Enter Amount: ");
                    float amount = float.Parse(Console.ReadLine());
                    string transactionType = "W";

                    bool isSuccessful = bankAccount.Withdraw(amount);

                    if (isSuccessful)
                    {
                        Transaction t = new Transaction(amount, transactionType);
                        bankAccount.AddTransaction(t);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount: " + amount);
                    }
                }
                else if (choice == 3)
                {
                    // Display Balance
                    Console.WriteLine("Account Number: " + bankAccount.GetAccountNumber());
                    Console.WriteLine("Balance: " + bankAccount.View());

                    Console.WriteLine("===================");
                    Console.WriteLine("Transactions:");
                    Console.WriteLine("===================");

                    for (int i = 0; i < bankAccount.GetTransactions().Count; i++)
                    {
                        Transaction t = bankAccount.GetTransactions()[i];
                        Console.WriteLine("Transaction Type: " + t.GetTransactionType());
                        Console.WriteLine("Amount: " + t.GetAmount());
                        Console.WriteLine("===================");
                    }
                }
                else if (choice == 4)
                {
                    isContinue = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice: " + choice);
                }

                Console.Write("Do you want to continue? [Y/N]: ");
                string willContinue = Console.ReadLine().ToLower();

                if(willContinue == "y") {
                    // Nothing to do here
                    isContinue = true;
                } else if(willContinue == "n") {
                    isContinue = false;
                } else {
                    Console.WriteLine("Invalid choice");
                }
            }

            Console.WriteLine("Done.");
            */
        }
    }
}
