namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }
                foreach (var clothe in clothes)
                {
                    if (!wardrobe[input[0]].ContainsKey(clothe))
                    {
                        wardrobe[input[0]].Add(clothe, 0);
                    }
                    wardrobe[input[0]][clothe]++;
                }
            }

            string[] clothingSearched = Console.ReadLine().Split();
            string colorSearched = clothingSearched[0];
            string clotheSearched = clothingSearched[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in color.Value)
                {
                    if (colorSearched == color.Key && clotheSearched == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
