namespace demo
{
    public class Person
    {
        private string name = "Ivan";
        private int age = 5;

        public string Name
        {
            get
            { 
                return name; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

    }
}
