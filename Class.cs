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
            int wins;

            Random win = new Random();
            wins = win.Next(750, 17500);

            int games;

            Random game = new Random();
            games = game.Next(1500, 20000);

            int WL;

            WL = wins / games;


        }
        static void TopTens()
        {
            int tops;

            Random top = new Random();
            tops = top.Next(1250, 18000);

        }
        static void DeathandKills()
        {
            int deaths;

            Random death = new Random();
            deaths = death.Next(1000, 12000);

            int kills;

            Random kill = new Random();
            kills = kill.Next(1000, 25000);

            int KD;

            KD = kills / deaths;

        }
        
        // CODE BEYOND THIS POINT BROKEN!!
        static void Players()
        {
            var names = new[]
            {
                new
                {
                    letters = ( "Q","W","E","R","T" ),
                    bonusletters = new[] { "a","s","d","f","g" }

                },
                new
                {
                    moreletters = ( "z","x","v","c","b" ),
                    extraletters = new[] {"u","i","o","p","j" }
                
                }
            }
        }
        

        
          
            
       

        
        
        
    }
}
