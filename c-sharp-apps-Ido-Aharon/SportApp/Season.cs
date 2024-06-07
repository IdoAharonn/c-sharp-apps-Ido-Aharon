using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Ido_Aharon.SportApp
{
    public class Season
    {
        private int year;
        private string typeOfSport;
        private string league;
        private int totalRound;
        private int nextRound;
        private Team[] arr;
        private int amoutTeam;
        private bool active;

        public void DisplayTable()
        {
            for (int i = 0; i < amoutTeam; i++)
                Console.WriteLine($"{i + 1} - {arr[i].GetName()} - {arr[i].GetPoints()}");
        }

    }
}
