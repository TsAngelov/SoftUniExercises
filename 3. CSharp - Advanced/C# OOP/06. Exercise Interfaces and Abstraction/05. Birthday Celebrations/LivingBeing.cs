namespace BirthdayCelebrations
{
    public abstract class LivingBeing : IBirthable
    {
        public LivingBeing(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
