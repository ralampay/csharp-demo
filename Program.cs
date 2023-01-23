public class Program
{
    static void Main(string[] args) {
        Customer c = new Customer();

        c.SetCustomerInfo("Raphael", "Alampay", "B");

        BankAccount bankAccount = new BankAccount();
        bankAccount.SetAccountNumber("060081");
        bankAccount.SetCustomer(c);

        Console.WriteLine("Bank Account: " + bankAccount.GetAccountNumber());
        Console.WriteLine("Customer: " + bankAccount.GetCustomer().FullName());
    }
}