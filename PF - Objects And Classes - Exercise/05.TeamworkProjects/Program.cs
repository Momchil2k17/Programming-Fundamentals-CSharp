using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("-").ToArray();
                string creator = info[0];
                string teamName = info[1];

                Team team = new Team(teamName, creator);
                Team sameTeamCreator = teams.Find(x => x.Creator == creator);
                Team sameTeamName = teams.Find(x => x.Name == teamName);

                if (sameTeamName != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (sameTeamCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] info = command.Split("->").ToArray();
                string member = info[0];
                string teamName = info[1];

                Team foundTeam = teams.Find(x => x.Name == teamName);
                Team teamExistMember = teams.Find(x => x.Members.Contains(member));

                if (teamExistMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }
                if (foundTeam != null)
                {
                    if (foundTeam.Creator == member)
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                    else
                    {
                        foundTeam.Members.Add(member);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<Team> validTeams = teams.FindAll(x => x.Members.Count > 0);
            validTeams = validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            List<Team> invalidTeams = teams.FindAll(x => x.Members.Count == 0);
            invalidTeams = invalidTeams.OrderBy(x => x.Name).ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.ToString());
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.Name);
            }


        }
    }
    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public override string ToString()
        {
            Members.Sort();
            string result = string.Empty;
            result += Name + "\n";
            result += $"- {Creator}\n";
            foreach (string member in Members)
            {
                result += $"-- {member}\n";
            }
            return result.Trim();
        }
    }
}
