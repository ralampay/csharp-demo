namespace CSharpDemo
{
    namespace Models
    {
        public class BankAccount
        {
            private float balance;
            private string accountNumber;
            private Customer customer;

            // Property Balance linked to attribute balance
            public float Balance
            {
                get
                {
                    return this.balance;
                }
            }

            private List<Transaction> transactions;

            public BankAccount(string accountNumber, Customer customer)
            {
                this.accountNumber = accountNumber;
                this.customer = customer;

                this.transactions = new List<Transaction>();
            }

            public List<Transaction> GetTransactions()
            {
                return this.transactions;
            }

            public void AddTransaction(Transaction t)
            {
                this.transactions.Add(t);
            }

            public Customer GetCustomer()
            {
                return customer;
            }

            public void SetCustomer(Customer customer)
            {
                this.customer = customer;
            }

            public void SetAccountNumber(string accountNumber)
            {
                this.accountNumber = accountNumber;
            }

            public string GetAccountNumber()
            {
                return this.accountNumber;
            }

            // Deposit features:
            // - Returns the updated balance
            // - Accept the amount to deposit
            public float Deposit(float amount)
            {
                this.balance = this.balance + amount;

                return this.balance;
            }

            public float View()
            {
                return this.balance;
            }

            public bool Withdraw(float amount)
            {
                if (amount > this.balance)
                {
                    return false;
                }
                else
                {
                    this.balance = this.balance - amount;

                    return true;
                }
            }

            public void DisplayBalance()
            {
                Console.WriteLine("Balance: " + this.balance);
            }
        }
    }
}
