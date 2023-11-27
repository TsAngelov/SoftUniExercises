namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            int targetsShot = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < targets.Count)
                {
                    if (targets[index] == -1)
                    {
                    }
                    else
                    {
                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (i != index && targets[i] != -1)
                            {
                                if (targets[i] > targets[index])
                                    targets[i] -= targets[index];
                                else if (targets[i] <= targets[index])
                                {
                                    targets[i] += targets[index];
                                }
                                    
                            }
                        }
                        targets[index] = -1;
                        targetsShot++;
                    }
                }
                else
                {
                }
            }
            Console.WriteLine($"Shot targets: {targetsShot} -> {string.Join(" ", targets)}");
        }
    }
}