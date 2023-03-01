using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    public class EmployeeManager
    {
        public void Add(Employee employee)
        {
            if (employee.AdSoyad.Length<=0) // Ad Soyad boş ise Hata mesajı vermek için
            {
                Console.WriteLine("Lütfen Adınızı ve Soyadınızı girin..");
            }
            else
            {
                Console.WriteLine($"Personel Adı Soyadı : {employee.AdSoyad}\nPersonel Unvanı : {employee.Unvan}\nPersonel Maaşı : {employee.Maas} PNG Kina\nPersonel İzin Gün Sayısı : {employee.Izingunu}");
            }
            
        }

        public void UnvanKontrol(Employee employee) 
        {

            if (employee.Maas >= 2500 && employee.Maas <= 10000)
            {
                employee.Unvan = "Standart Personel";
                employee.Izingunu = 14;

            }
            else if (employee.Maas>10000 && employee.Maas<=14000)
            {
                employee.Unvan = "Kıdemli Personel";
                employee.Izingunu = 20;


            }
            else if (employee.Maas > 14000 && employee.Maas <= 15500)
            {
                employee.Unvan = "Kıdemli+ Personel";
                employee.Izingunu = 24;


            }
            else if (employee.Maas > 15500 )
            {
                employee.Unvan = "Uzman Personel";
                employee.Izingunu = 30;

            }
            else
            {
                Console.WriteLine("Şirket Çalışanı Değilsiniz..");
            }
        }

    }
}
