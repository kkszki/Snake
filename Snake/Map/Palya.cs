using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Map
{
    internal class Palya
    {
        public static string[,] PalyaGeneralo(int sorok, int oszlopok)
        {
            string[,] palya = new string[sorok, oszlopok];

            for (int i = 0; i < sorok; i++) // Végigmegyünk a sorokon
            {
                for (int j = 0; j < oszlopok; j++) // Végigmegyünk az oszlopokon
                {
                    // Például feltöltjük koordinátákkal vagy üres karakterrel
                    palya[i, j] = $"[{i},{j}]";
                }
            }



            return palya;
        }


        public static void PalyaUpdate()
        {

        }
    }
}
