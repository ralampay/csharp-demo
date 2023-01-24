namespace CSharpDemo
{
    namespace Models
    {
        public class Branch
        {
            public int Id { get; }
            // Property with get and set
            public string Name { get; set; }

            // Default constructor
            public Branch()
            {

            }

            // Overloaded constructor that accepts a branch name
            public Branch(string name)
            {
                this.Name = name;
            }

            public Branch(int id, string name)
            {
                this.Name = name;

                // This is allowed because we are accessing
                // Id privately.
                this.Id = id;
            }
        }
    }
}