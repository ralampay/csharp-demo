using CSharpDemo.Models;
using System.Collections;

namespace CSharpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
