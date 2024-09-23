using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Goat : Animal
    {
        public int GiveBirth()
        {
            Random rnd = new Random();
            return rnd.Next(1, 2);
        }
        public int GiveMilk()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }
        public string Sound()
        {
            return "Meeeee";
        }
    }
}
