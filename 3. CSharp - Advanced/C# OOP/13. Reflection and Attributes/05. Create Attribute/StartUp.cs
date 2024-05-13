using System.Diagnostics;

namespace AuthorProblem
{
    public class StartUp
    {
        [Author("Victor")]
        public static void Main(string[] args)
        {
        }

        [Author("Patrona")]
        [Author("Petar")]
        [Author("Tiras")]
        public void NewMethod()
        {

        }
    }
}
