namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                list.Add(article);
            }
            Console.WriteLine(string.Join("\n", list));
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}