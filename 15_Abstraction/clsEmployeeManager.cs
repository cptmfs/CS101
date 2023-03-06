using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // İşletme içerisinde beden işçisi statüsünde çalışan kişiler için EmployeeManager isminde bir sınıf olusturarak bu sınıfı kalıtım yolu ile üst sınıfını clsEmployeeBaseManager secerek gerekli kodları yazalım..
    internal class clsEmployeeManager : clsEmployeeBaseManager
    {

        // Abstract bir class dan kalıtım aldıgımız için orada boş olarak sadece tanımladıgımız metotları implement'e etmemizi istedi ( Onların içini doldurmamız gerekiyor burada )
        public clsEmployeeManager() // bu class/nesne ilk olustugunda default en taban title tanımını olusturmak için ..
        {
            setTitle("Gemici");
        }
        public override void doRaise()  // Çalışana zam yapacağımız metot.
        {
            double salary= getSalary(); // Oluşturulmuş olan çalışanın o anki maaşını öğreniyoruz..
            double raise = salary + 5000; // raise --> Zamlı maaş oluyor.
            setSalary(raise);               // Çalışanın yeni zamlı maaşı işlendi..
        }

        public override void doRaise(double _raiseRate) // Çalışana zam yapacağımız ve Prim ekleyeceğimşz metot.
        {
            double salary = getSalary(); 
            double raise = salary + (salary * _raiseRate); 
            setSalary(raise);    // Prim dahil güncellenmiş maaş
        }
    }
}
