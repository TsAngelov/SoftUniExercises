using System.Diagnostics.CodeAnalysis;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                Team team = new Team(newTeam[1], newTeam[0]);

                Team sameTeamFound = teams.Find(t => t.Name == newTeam[1]);
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }

                Team sameCreatorFound = teams.Find(c => c.Creator == newTeam[0]);
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;   
                }
                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] lineTokens = input.Split("->");
                string memberAdd = lineTokens[0];
                string teamName = lineTokens[1];
                
                bool hasTeamSameName = teams.Any(t => t.Name == teamName);
                if (hasTeamSameName == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team => team.Creator == memberAdd) || teams.Any(team => team.Members.Contains(memberAdd)))
                {
                    Console.WriteLine($"Member {memberAdd} cannot join team {teamName}!");
                    continue;
                }

                teams.First(t => t.Name == teamName).Members.Add(memberAdd);
            }

            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> orderedTeams = leftTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            orderedTeams.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Teams to disband:");
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();
            disbandTeams = disbandTeams.OrderBy(t => t.Name).ToList();
            disbandTeams.ForEach(team => Console.WriteLine(team.Name));

        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            Name = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMemberString()}";
        }
        private string GetMemberString()
        {
            Members = Members.OrderBy(name => name).ToList();
            string result = string.Empty;
            for (int i = 0; i < Members.Count-1; i++)
            {
                result += $"-- {Members[i]}\n";
            }
            result += $"-- {Members[Members.Count-1]}";

            return result;
        }
    }
}