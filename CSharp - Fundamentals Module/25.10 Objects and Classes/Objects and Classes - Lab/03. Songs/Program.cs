namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < n; i++) 
            {
                string[] lineTokens = Console.ReadLine().Split('_');
                string listType = lineTokens[0];
                string songName = lineTokens[1];
                string songTime = lineTokens[2];

                Song song = new Song()
                {
                    Name = songName,
                    TypeList = listType,
                    Time = songTime
                };
                playlist.Add(song);
            }
            string filter = Console.ReadLine();
            if (filter != "all")
            {
                for (int i = 0; i < playlist.Count; i++)
                {
                    Song currentSong = playlist[i];
                    if (currentSong.TypeList != filter)
                    {
                        playlist.RemoveAt(i);
                    }
                }
            }
        } 

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }

    }
}