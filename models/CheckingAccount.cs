namespace CSharpDemo.Models
{
    public class CheckingAccount : BankAccount
    {
        public List<Check> CheckBook { get; }

        public static int DEFAULT_NUM_CHECKS = 10;

        // Use base to invoke the parent constructor
        public CheckingAccount(string accountNumber, Customer customer)
            : base(accountNumber, customer)
        {
            this.CheckBook = new List<Check>();

            for(int i = 0; i < CheckingAccount.DEFAULT_NUM_CHECKS; i++)
            {
                Check check = new Check("#" + (i+1));
                this.CheckBook.Add(check);
            }
        }

        // Example of Overriding by overriding the DisplayBalance() of parent BankAccount
        public void DisplayBalance()
        {
            base.DisplayBalance();  // Calls the DisplayBalance() method of parent BankAccount via base keyword
            Console.WriteLine("# of Checks: " + this.CheckBook.Count);
        }
    }
}