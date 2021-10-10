using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank.csharpCertification
{
    public class Team
    {
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }
        public Team(string _teamName, int _noOfPaleyers)
        {
            teamName = _teamName;
            noOfPlayers = _noOfPaleyers;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            int diff = noOfPlayers - count;
            if (diff < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers = diff;
                return true;
            }
        }
    }

    public class Subteam : Team
    {
        public Subteam(string _teamName, int _noOfPaleyers) : base(_teamName, _noOfPaleyers)
        {

        }

        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
}
