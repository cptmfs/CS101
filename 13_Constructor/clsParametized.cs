using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsParametized
    {

        int x;
        public clsParametized(int i)
        {
            Console.WriteLine($"Parametreli Constructor/Yapıcı Çağrıldı... Parametre Değeri : {i}");
        }
    }
}
