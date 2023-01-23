public class Program
{
    static void Main(string[] args) {
        Customer c = new Customer();

        c.SetCustomerInfo("Raphael", "Alampay", "B");

        Console.WriteLine("Customer Info: " + c.CustomerInfo());

        c.SetFirstName("Leonardo");

        Console.WriteLine("Customer Info: " + c.CustomerInfo());
    }
}