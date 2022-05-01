using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }

        public List<string> TeamMembers = new List<string>();
        public Team(string user, string name)
        {
            TeamName = name;
            TeamCreator = user;
        }
        public override string ToString()
        {
            return $"Team {TeamName} has been created by {TeamCreator}!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                var data = Console.ReadLine().Split("-");
                var creator = data[0];
                var teamName = data[1];

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.TeamCreator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creator, teamName);
                    Console.WriteLine(team.ToString());
                    teams.Add(team);
                }

                //bool createTeam = true;
                //for (int j = 0; j < teams.Count; j++)
                //{
                //    if (teams[j].TeamName == teamName)
                //    {
                //        Console.WriteLine($"Team {teamName} was already created!");
                //        createTeam = false;
                //        break;
                //    }
                //    else if (teams[j].TeamCreator == creator)
                //    {
                //        Console.WriteLine($"{creator} cannot create another team!");
                //        createTeam = false;
                //        break;
                //    }
                //}
                //if (createTeam)
                //{
                //    Team team = new Team(creator, teamName);
                //    Console.WriteLine(team.ToString());
                //    teams.Add(team);
                //}
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split("->");

                if (cmd[0] == "end of assignment")
                {
                    break;
                }

                var user = cmd[0];
                var teamName = cmd[1];

                if (!teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(team => team.TeamMembers.Contains(user) 
                || teams.Any(team => team.TeamCreator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    var currentTeam = teams.First(teams => teams.TeamName == teamName);
                    currentTeam.TeamMembers.Add(user);
                }
                //bool teamExist = false;
                //for (int i = 0; i < teams.Count; i++)
                //{
                //    if (teams[i].TeamName == teamName)
                //    {
                //        teamExist = true;
                //        break;
                //    }                   
                //}
                //if (!teamExist)
                //{
                //    Console.WriteLine($"Team {teamName} does not exist!");
                //}
                //else
                //{
                //    bool addToTeam = true;
                //    for (int i = 0; i < teams.Count; i++)
                //    {
                //        if (teams[i].TeamCreator == user)
                //        {
                //            Console.WriteLine($"Member {user} cannot join team {teamName}!");
                //            addToTeam = false;
                //            break;
                //        }
                //        if (teams[i].TeamMembers.Count < 1)
                //        {
                //            continue;
                //        }
                //        for (int j = 0; j < teams[i].TeamMembers.Count; j++)
                //        {
                //            if (teams[i].TeamMembers[j] == user)
                //            {
                //                Console.WriteLine($"Member {user} cannot join team {cmd[1]}!");
                //                addToTeam = false;
                //                break;
                //            }
                //        }
                //    }
                //    if (addToTeam)
                //    {
                //        for (int i = 0; i < teams.Count; i++)
                //        {
                //            if (teams[i].TeamName == teamName)
                //            {
                //                teams[i].TeamMembers.Add(user);
                //            }
                //        }
                //    }
                //}
            }

            //var finalTeams = teams.Where(team => team.TeamMembers.Count > 0);
            //var disbandedTeams = teams.Where(team => team.TeamMembers.Count == 0);

            //foreach (Team team in finalTeams.OrderByDescending(team => team.TeamMembers.Count)
            //    .ThenBy(team => team.TeamName))
            //{
            //    Console.WriteLine(team.TeamName);
            //    Console.WriteLine($"- {team.TeamCreator}");
            //    foreach (var member in team.TeamMembers)
            //    {
            //        Console.WriteLine($"-- {member}");
            //    }
            //}

            List<string> teamsToDisband = new List<string>();
            List<Team> orderedTeams = new List<Team>();
            orderedTeams = teams.OrderByDescending(x => x.TeamMembers.Count).ThenBy(x => x.TeamName).ToList();
            foreach (var team in orderedTeams)
            {
                team.TeamMembers.Sort();
                if (team.TeamMembers.Count < 1)
                {
                    teamsToDisband.Add(team.TeamName);
                }
                else
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine($"- {team.TeamCreator}");
                    foreach (var member in team.TeamMembers)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            teamsToDisband.Sort();
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team);
            }
        }
    }
}
