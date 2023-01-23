namespace CSharpDemo
{
    namespace Models
    {
        public class BankAccount
        {
            private float balance;
            private string accountNumber;
            private Customer customer;

            public BankAccount(string accountNumber, Customer customer)
            {
                this.accountNumber = accountNumber;
                this.customer = customer;
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
        }
    }
}
