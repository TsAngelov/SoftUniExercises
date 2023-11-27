using System.ComponentModel.DataAnnotations;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                string[] lineTokens = Console.ReadLine().Split(": ");
                string command = lineTokens[0];
                string text = lineTokens[1];
                switch (command)
                {
                    case "Edit":
                        article.Edit(text);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(text);
                        break;
                    case "Rename":
                        article.Rename(text);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}