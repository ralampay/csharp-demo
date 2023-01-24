namespace CSharpDemo.Models
{
    public class CheckingAccount : BankAccount
    {
        public List<Check> CheckBook { get; }
        public int DefaultNumChecks { get; }

        public CheckingAccount(string accountNumber, Customer customer, int numChecks)
            : base(accountNumber, customer)
        {
            this.DefaultNumChecks = numChecks;
            this.CheckBook = new List<Check>();

            for(int i = 0; i < numChecks; i++)
            {
                Check check = new Check("#" + (i+1));
                this.CheckBook.Add(check);
            }
        }
    }
}