﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsParametized
    {

        int x;
        string mesaj = "Parametre geliyor olay değişiyor";
        public clsParametized(int i)
        {
            x = i+5;
            Console.WriteLine($"Parametreli Constructor/Yapıcı Çağrıldı... Parametre Değeri : {i}");
        }

        public void Display()
        {
            
            Console.WriteLine($"X Degiskeninin degeri : {x}");
            Console.WriteLine($"Mesaj  : {mesaj}");
        }
    }
}