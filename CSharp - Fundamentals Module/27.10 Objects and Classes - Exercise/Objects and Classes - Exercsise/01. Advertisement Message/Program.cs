namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Advertisement ad = new Advertisement()
            {
                Phrases = new[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."},
                Events = new[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" },
                Authors = new[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" },
                Cities = new[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

            };
            Random random = new Random();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(ad.Phrases.Length);
                string phrase = ad.Phrases[index];

                index = random.Next(ad.Events.Length);
                string e = ad.Events[index];

                index = random.Next(ad.Authors.Length);
                string authors = ad.Authors[index];

                index = random.Next(ad.Cities.Length);
                string cities = ad.Cities[index];
                Console.WriteLine($"{phrase} {e} {authors} - {cities}.");
            }

        }
    }
    class Advertisement
    {
        public string[] Phrases { get; set; }
        public string[] Events { get; set; }
        public string[] Authors { get; set; }
        public string[] Cities { get; set; }
    }
}