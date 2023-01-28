using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split('-');
                string c = command[0];
                string t = command[1];
                List<string> m = new List<string>();
                Team team = new Team(t, c, m);
                bool OK = true;
                if (!CheckAvailableName(team, teams))
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    OK = false;
                }
                if (!CheckAvailableCreator(team, teams))
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    OK = false;
                }
                if (OK)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split("->");
                string m = command[0];
                if (m == "end of assignment")
                {
                    break;
                }
                string t = command[1];
                bool OK = true;
                if (!CheckAvailableMember(m, teams))
                {
                    OK = false;
                    Console.WriteLine($"Member {m} cannot join team {t}!");
                }
                if (!CheckAvailableTeam(t, teams))
                {
                    OK = false;
                    Console.WriteLine($"Team {t} does not exist!");
                }
                if (OK)
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (t == teams[i].TeamName)
                        {
                            teams[i].Members.Add(m);
                        }
                    }
                }
            }
            foreach (Team team in teams.Where(m => m.Members.Any()).OrderByDescending(m=>m.Members.Count).ThenBy(m=>m.TeamName))
            {
                Console.WriteLine(team);
                team.PrintMembers();
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams.Where(m => !m.Members.Any()).OrderBy(m => m.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
        static bool CheckAvailableName(Team t, List<Team> ts)
        {
            foreach (Team team in ts)
            {
                if (team.TeamName == t.TeamName)
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckAvailableCreator(Team t, List<Team> ts)
        {
            foreach (Team team in ts)
            {
                if (team.Creator == t.Creator)
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckAvailableMember(string member, List<Team> ts)
        {
            foreach (Team team in ts)
            {
                if (team.Creator == member)
                {
                    return false;
                }
                for (int i = 0; i < team.Members.Count; i++)
                {
                    if (member == team.Members[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static bool CheckAvailableTeam(string teamName, List<Team> ts)
        {
            foreach (Team team in ts)
            {
                if (team.TeamName == teamName)
                {
                    return true;
                }
            }
            return false;
        }
        class Team
        {
            string teamName;
            string creator;
            List<string> members;
            public Team(string teamName, string creator, List<string> members)
            {
                TeamName = teamName;
                Creator = creator;
                Members = members;
            }
            public string TeamName { get => teamName; set => teamName = value; }
            public string Creator { get => creator; set => creator = value; }
            public List<string> Members { get => members; set => members = value; }
            public Team()
            {
                Members = new List<string>();
            }
            public override string ToString()
            {
                return $"{TeamName}\n- {Creator}";
            }
            public void PrintMembers()
            {
                foreach (string member in this.Members.OrderBy(m=>m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
