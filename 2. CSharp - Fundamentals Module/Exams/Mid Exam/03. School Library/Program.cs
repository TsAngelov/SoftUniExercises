namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();
            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] request = input.Split(" | ");
                string command = request[0];
                string bookName = request[1];
                switch (command)
                {
                    case "Add Book":
                        if (!books.Contains(bookName))
                            books.Insert(0, bookName);
                            
                        break;
                    case "Take Book":
                        books.Remove(bookName);
                        break;
                    case "Swap Books":
                        string bookName2 = request[2];
                        if (books.Contains(bookName) && books.Contains(bookName2))
                        {
                            string temp = bookName;
                            int bookIndex1 = books.IndexOf(bookName);
                            int bookIndex2 = books.IndexOf(bookName2);
                            books[bookIndex1] = bookName2;
                            books[bookIndex2] = temp;
                        }
                        break;
                    case "Insert Book":
                        if (!books.Contains(bookName))
                            books.Add(bookName);
                        break;
                    case "Check Book":
                        int index = int.Parse(request[1]);
                        if (index >= 0 && index < books.Count)
                        {
                            Console.WriteLine(books[index]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}