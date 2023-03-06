using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // Abstract yapısını daha dogru bir sekilde  kullanmak ve programı daha esnek bir hale getirebilmek icin clsCreateEmployeeManager isminde ekleme islemlerinin yonetileceği genel bir sınıf tanımlaması gerceklestirelim ve gerekli tanımlamaları olusturalım..

    // Burası elemanı olusturacağımız.. Personel listesi olusturma gibi..
    internal class clsCreateEmployeeManager
    {
        public clsEmployeeBaseManager employeeBaseManager;

        private string name, surName;
        private double salary;

        public void Create()
        {
            Console.WriteLine($"<Create Employee Manager>\n\nÇalışanın Adı : ");
            name = Console.ReadLine();
            Console.WriteLine($"<Create Employee Manager>\n\nÇalışanın Soyadı : ");
            surName = Console.ReadLine();
            Console.WriteLine($"<Create Employee Manager>\n\nÇalışanın Maaşı : ");
            salary = Convert.ToDouble(Console.ReadLine());

            employeeBaseManager.setInfo(name, surName, salary);
        }

        public void GetInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void doRaise()
        {
            employeeBaseManager.doRaise();  // Normal Çalışan için zam metodunu çağırıyoruz..
            Console.WriteLine($"<Zam Uygulandı>\n\n-> Yeni Maaş : {employeeBaseManager.getSalary()} PNG Kina");
        }
        public void doRaise(double _RaiseRate) //  Primli zam uygulayacağımız metodu çağırıyoruz..
        {
            employeeBaseManager.doRaise(_RaiseRate); 
            Console.WriteLine($"<Primli Zam Uygulandı>\n\n-> Yeni Maaş : {employeeBaseManager.getSalary()} PNG Kina");

        }



    }
}
