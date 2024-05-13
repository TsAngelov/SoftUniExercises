using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            foreach (var ph in phones)
            {
                
                if (ph.All(char.IsDigit))
                {
                    ICaller phone = default;
                    if (ph.Length == 10)
                    {
                        phone = new SmartPhone();
                    }
                    else if (ph.Length == 7)
                    {
                        phone = new StationaryPhone();
                    }
                    phone.Call(ph);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var site in sites)
            {
                if (!site.Any(char.IsDigit))
                {
                    SmartPhone phone = new SmartPhone();
                    phone.Browse(site);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}
