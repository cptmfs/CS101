using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    internal abstract class clsEmployeeBaseManager
    {
        // Çalışanlar için temel bilgilerin tutulacagı değişkenler..


        private string name, surName, title; // Özlük bilgileri
        private double salary;              // Maaş
        private int annualLeave;           //  Yıllık izin

        // Çalışan kişilerin bilgilerini yazdıracağımız

        public void getInfo()
        {
            if (annualLeave>0)
            {
                // Eğer çalışan herhangi bir şekilde  olusturulmadıysa uyarı vermek için.

                Console.WriteLine($"< Abstract Company Employee >\n\n-> İsim : {name}\n-> Soyisim : {surName}\n-> Ünvan : {title}\n-> Maaş : {salary} PNG Kina\n-> Yıllık İzin : {annualLeave}\n");
            }
            else
            {
                Console.WriteLine($"< Employee not Found >\n\n");
            }
        }

        // Çalışan kişilerin bilgilerini set edeceğimiz metot
        public void setInfo(string _name , string _surName , double _salary)
        {
            if (_name.Length >=3 && _surName.Length>=2)
            {
                if (_salary>=8500)
                {
                    this.name = _name;
                    this.surName= _surName;
                    this.salary = _salary;

                    if (_salary>=8500 && _salary<=12000)
                    {
                        this.title = "Deneyimli " + title; // Zaten tanımlı olan title ın başına Deneyimli ekleyecek..
                        this.annualLeave = 20;
                    }
                    else if (_salary>12000 && _salary<=15000)
                    {
                        this.title = "Kıdemli " + title; // Zaten tanımlı olan title ın başına Kıdemli ekleyecek..
                        this.annualLeave = 24;
                    }
                    else if (_salary>15000)
                    {
                        this.title = "Uzman " + title; // Zaten tanımlı olan title ın başına Kıdemli ekleyecek..
                        this.annualLeave = 30;
                    }
                    else
                    {
                        this.annualLeave = 14;
                    }
                }
                else
                {
                    Console.WriteLine("<ERROR>\n\n-> Çalışanınıza minimum 8500 PNG Kina vermeniz gerekmektedir.. O yüzden çalışan kaydı oluşturulamadı\n");
                }
            }
            else
            {
                Console.WriteLine("<ERROR>\n\n-> Çalışan isim/soyisim uzunluğu gerekli kriterleri karşılamıyor.. Kontrol ediniz..\n");
            }
        }

        // Maaş bilgilerine erişim sağlayacak Getter/Setter metotları

        public double getSalary() // Maaşını öğrenme metodu..
        {
            return salary;
        }
        public void setSalary(double _salary)
        {
            this.salary = _salary;
        }


        // Ünvan bilgilerine erişim sağlayacak Getter/Setter metotları

        public void setTitle(string _title)
        {
            this.title = _title;
        }

        // Her nesne için ( Personel , Mühendis .. vb ) özel zam seçenekleri  olabileceği için Abstract metotlar tanımlanıyor..
        // Polymorphism kullanılıyor..

        public abstract void doRaise(); // Düz Zam
        public abstract void doRaise(double _raiseRate); // Zam + Prim 




    }
}
