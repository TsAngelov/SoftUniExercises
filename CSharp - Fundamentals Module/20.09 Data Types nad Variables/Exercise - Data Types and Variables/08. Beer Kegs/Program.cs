namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestVolume = 0;
            for (int i = 1; i <= n; i++)
            {
                string currentKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radius * radius * height;
                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestKeg = currentKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}