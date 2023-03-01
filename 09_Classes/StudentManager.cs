using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    public class StudentManager
    {

        public void Add(clsOgrenci ogrenci)
        {
            Console.WriteLine($"Öğrenci No : {ogrenci.ogrNo}\nÖğrenci Adı ve Soyadı : {ogrenci.adiSoyadi}\nÖğrenci Dersi : {ogrenci.ders}\nÖğrenci Ders Notu : {ogrenci.dersNotu}");
        }
        public void Control(int pNot)
        {
            if (pNot > 50)
            {
                Console.WriteLine("Tebrikler Geçtiniz..");
            }
            else
            {
                Console.WriteLine("Üzgünüm Kaldınız..");
            }
        }
    }
}
