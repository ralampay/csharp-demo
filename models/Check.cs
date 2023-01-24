namespace CSharpDemo.Models
{
    public class Check
    {
        public string CheckNumber { get; }
        public float Amount { get; private set; }

        public Check(string checkNumber, float amount)
        {
            this.CheckNumber = checkNumber;
            this.Amount = amount;
        }

        public Check(string checkNumber)
        {
            this.CheckNumber = checkNumber;
        }

        public bool WriteAmount(float amount)
        {
            if(Amount == 0) {
                this.Amount = amount;

                return true;
            } else {
                return false;
            }
        }
    }
}