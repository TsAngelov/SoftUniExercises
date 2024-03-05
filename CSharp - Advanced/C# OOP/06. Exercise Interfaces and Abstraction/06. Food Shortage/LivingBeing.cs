namespace FoodShortage
{
    public abstract class LivingBeing : IBuyer
    {
        public LivingBeing(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual int Food { get; set; }

        public virtual void BuyFood()
        {
        }
    }
}
