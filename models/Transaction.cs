namespace CSharpDemo
{
    namespace Models
    {
        public class Transaction 
        {
            private float amount;
            private string transactionType;

            public Transaction(float amount, string transactionType)
            {
                this.amount = amount;
                this.transactionType = transactionType;
            }

            public float GetAmount()
            {
                return this.amount;
            }

            public string GetTransactionType()
            {
                return this.transactionType;
            }
        }
    }
}