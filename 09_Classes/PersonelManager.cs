
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    public class PersonelManager
    {

        public void Add(clsPersonel personel)
        {

            Console.WriteLine($"Personel Adı :{personel.Adi}\nPersonel Soyadı : {personel.Soyadi}\nPersonel Bölümü : {personel.Bolumu}\nPersonel Tc Kimlik No : {personel.TcNo}\nPersonel Maaşı : {personel.Maas} $");
            
        }
    }
}
