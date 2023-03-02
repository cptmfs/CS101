using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiers
{
    internal class clsStudent
    {
        private string name = "Ferit"; // Private oldugu için program cs den erişemiyoruz..

        public void getName() //  // Private oldugu için program cs den erişemiyoruz..

        {
            Console.WriteLine($"Adınız :  {name}");
        }
    }
}
