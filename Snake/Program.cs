using Snake.Kigyo;
using Snake.Map;
using Snake.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {

        public static int x=5;
        public static int y=5;
        public static string[,] aktualis_palya = Palya.PalyaGeneralo(x,y);
        public static Kigyorol[] aktualis_poziciok = new Kigyorol[] { new Kigyorol(0, 0) };
        static void Main(string[] args)
        {
          
            Megjelenit.FoMegjelenites();    
          
        }
    }
}
