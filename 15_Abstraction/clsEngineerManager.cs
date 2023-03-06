using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // Kaptan sınıfından personeller için kullanılacak class
    internal class clsEngineerManager : clsEmployeeBaseManager
    {
        public clsEngineerManager()
        {
            setTitle("Kaptan");
        }
        public override void doRaise()
        {
            double salary = getSalary(); // Oluşturulmuş olan çalışanın o anki maaşını öğreniyoruz..
            double raise = salary + 10000; // raise --> Zamlı maaş oluyor.
            setSalary(raise);               // Çalışanın yeni zamlı maaşı işlendi..
        }

        public override void doRaise(double _raiseRate)
        {
            double salary = getSalary();
            double raise = salary + (salary * _raiseRate)+(salary %2);
            setSalary(raise);    // Prim dahil güncellenmiş maaş
        }
    }
}
