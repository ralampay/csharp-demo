namespace CSharpDemo
{
    namespace Models
    {
        public class Customer
        {
            private string firstName;
            private string lastName;
            private string middleName;

            public Customer(string firstName, string middleName, string lastName)
            {
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;
            }

            public Customer()
            {
                // Customer c = new Customer()
            }

            public string CustomerInfo()
            {
                string info = this.lastName + ", " + this.firstName + " " + this.middleName;

                return info;
            }

            public string FullName()
            {
                string fullName = this.firstName + " " + this.middleName + " " + this.lastName;

                return fullName;
            }

            public void SetCustomerInfo(string firstName, string lastName, string middleName)
            {
                this.SetFirstName(firstName);
                this.SetLastName(lastName);
                this.SetMiddleName(middleName);
            }

            public void SetFirstName(string firstName)
            {
                this.firstName = firstName;
            }

            public void SetLastName(string lastName)
            {
                this.lastName = lastName;
            }

            public void SetMiddleName(string middleName)
            {
                this.middleName = middleName;
            }

            public void SetName(string firstName)
            {
                this.firstName = firstName;
            }

            public void SetName(string firstName, string middleName)
            {
                this.firstName = firstName;
                this.middleName = middleName;
            }

            public void SetName(string firstName, string middleName, string lastName)
            {
                this.SetName(firstName);
                this.middleName = middleName;
                this.lastName = lastName;
            }
        }
    }
}
