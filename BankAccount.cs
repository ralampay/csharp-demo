public class BankAccount
{
    private float balance;
    private string accountNumber;

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