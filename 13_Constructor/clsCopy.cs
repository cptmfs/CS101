using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsCopy
    {
        int x;
        string mesaj = "Parametre geliyor olay değişiyor";
        public clsCopy(int i)
        {
            x= i;
            //Console.WriteLine($"Parametreli Constructor/Yapıcı Çağrıldı... Parametre Değeri : {i}");
        }

        public clsCopy(clsCopy copy)
        {
            x = copy.x;

        }


        public void Display()
        {

            Console.WriteLine($"X Degiskeninin degeri : {x}");
            //Console.WriteLine($"Mesaj  : {mesaj}");
        }
    }
}
