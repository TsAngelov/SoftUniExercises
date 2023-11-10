namespace _4._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = "";
            foreach (char character in text)
                encryptedText += (char)(character + 3);

            Console.WriteLine(encryptedText);
        }
    }
}