using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace _03._Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] cards = Console.ReadLine().Split(", ");
            List<Card> validCards = new List<Card>();

            foreach (var card in cards)
            {
                string[] splitCard = card.Split();
                try
                {
                    string face = splitCard[0];
                    char suit = char.Parse(splitCard[1]);
                    validCards.Add(CreateCard(face, suit));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid card!");
                }

            }
            validCards.ForEach(card => Console.Write(card + " "));
        }
        public static Card CreateCard(string face, char suit)
        {
            IReadOnlyCollection<string> ValidFaces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            IReadOnlyCollection<char> ValidSuits = new List<char>() { 'S', 'H', 'D', 'C' };

            if (!ValidFaces.Contains(face))
            {
                throw new ArgumentException();
            }
            else if (!ValidSuits.Contains(suit))
            {
                throw new ArgumentException();
            }
            return new Card(face, suit);
        }
    }
    public class Card
    {
        private char suit;
        public Card(string face, char suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face { get; set; }
        public char Suit
        {
            get => suit;
            set
            {
                suit = value switch
                {
                    'S' => '\u2660',
                    'H' => '\u2665',
                    'D' => '\u2666',
                    'C' => '\u2663',
                };
            }
        }
        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }
    }
}
