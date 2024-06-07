using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Ido_Aharon.SportApp
{
    public class Team
    {
        private string name;
        private string city;
        private string liga;
        private int howMachGame;
        private int gamesHappened;
        private int win;
        private int lose;
        private int point;
        private int goalsFor;
        private int goalAgainst;
        private int goalDifferential;

        public Team (string name, string city)
        {
            this.name = name; 
            this.city = city;

        }
        public string GetName() { return name; }
        public string GetCity() { return city; }
        public string GetLiga() { return liga; }
        public int GethowMachGame() { return howMachGame; }
        public int GamesHappened() { return gamesHappened; }
        public int GetWin() { return win; }
        public int GetPoints() { return point; }
    }
}
