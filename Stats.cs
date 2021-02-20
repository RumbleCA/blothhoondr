using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blothhoondr
{
    public class Scoreboard
    {
        static void GamesWon()
        {
             Decimal wins;

            Random win = new Random();
            wins = win.Next(750, 15000);

            Decimal games;

            Random game = new Random();
            games = game.Next(1500, 20000);

            Decimal WL;

            WL = wins / games;
            Convert.ToDecimal(WL);

            decimal b = Convert.ToDecimal(WL);

            WL = Math.Round(WL, 1, MidpointRounding.ToEven);



        }
        
        static void TopTens()
        {
            int tops;

            Random top = new Random();
            tops = top.Next(1500, 18000);

        }
       
        static void DeathandKills()
        {
            Decimal deaths;

            Random death = new Random();
            deaths = death.Next(1500, 12000);

            Decimal kills;

            Random kill = new Random();
            kills = kill.Next(12000, 25000);

            Decimal KD;

            KD = kills / deaths;
            Convert.ToDecimal(KD);

            decimal b = Convert.ToDecimal(KD);

            KD = Math.Round(KD, 1, MidpointRounding.ToEven);


        } 
        
    }
}
