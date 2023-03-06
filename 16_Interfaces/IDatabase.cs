using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal interface IDatabase
    {
        // Bu interface'de sadece metot yapılarını kodsuz olarak tanımlıyoruz. Yani şablonu oluşturuyoruz.


        int Login(string username, string password); //Database'imize giriş yapan metot..
        void Close(); //Database'i kapatan metot..
        void AddValue(string value); // Database'imize bir değer ekleyen metot ..

        void DeleteValue(); // Database'den değer silen metot ..

        void UpdateValue(string value); // Database'de değerleri güncelleye metot..

        void getValue(); // Database'den değer getirir..
    }
}
