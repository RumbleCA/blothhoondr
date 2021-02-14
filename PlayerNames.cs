using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blothhoondr
{
    public class PlayerNames
    {
        static void Letters(int yep)
        {
            Random r = new Random();
                                   // vowels and consonants bring up errors CS0029: cannot implicity convert type  
            string[] consonants = ("qu", "w", "r", "t", "p", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m");
            string[] vowels = ("a", "e", "i", "o", "u", "y");
            string name = "";

            name += consonants[r.Next(consonants.Length)];
            name += vowels[r.Next(vowels.Length)];

            int b = 2;
            while (b < yep) ;
            {
                name += consonants[r.Next(consonants.Length)];
                b++;
                name += vowels[r.Next(vowels.Length)];
                b++;
            }
        }
    }
}
