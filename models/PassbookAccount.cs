namespace CSharpDemo.Models
{
    public class PassbookAccount : BankAccount
    {
        public string PassbokNumber { get; set; }

        public PassbookAccount(string accountNumber, Customer customer, string passbokNumber)
            : base(accountNumber, customer)
        {
            this.PassbokNumber = passbokNumber;
        }
    }
}