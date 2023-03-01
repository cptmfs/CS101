using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Classes
{
    public class Program
    {

        static void Main(string[] args)
        {

            //Bir personel kayıt sistemi yapılacak.. clsPersonel sınıfı. clsPersonel içinde personel Bilgileri (adi,soyadi,id,tcNo,bolumu,maasi) özellikleri olacak. Personel kaydı olusturmak icin bir metod tanımlıycaz(setPersonelData).Personel kaydı yapacak ve güncelleme yapacak.. Personel bilgilerini kaydını yapacağız.. Ekranda göstermek için (getPersonelData) metodu tanımlayacağız ve ekrana yazdıracak bilgileri..

            //Personel Bilgileri : 
            #region Personel Örneği
            Console.WriteLine("\t\t\t\t--------------------Personel Listesi-----------------------");

            //manuel olarak dolduralım nesnelerimizi..
            //1. Seçenek classları ve metodları program class'ı içinde oluşturalım..
            //clsPersonel1 per1 = new clsPersonel1();

            //per1.setPersonelData(1, "Ferit", "Simsek", "Software", "12345678901", 4500);

            //per1.getPersonelData();

            //clsPersonel1 per2 = new clsPersonel1();

            //per2.setPersonelData(2, "Muhammed", "Simsek", "HR", "58145675901", 11500);

            //per2.getPersonelData();

            //clsPersonel1 per3 = new clsPersonel1();

            //per3.setPersonelData(2, "Seyma", "Simsek", "Sales", "78347968901", 9500);

            //per3.getPersonelData();

            // İkinci seçenek : Classları Farklı dosyalarda oluşturup yazdırma..
            //PersonelManager personelManager= new PersonelManager();
            //clsPersonel personel= new clsPersonel();
            //personel.Adi = "Ferit";
            //personel.Soyadi = "Simsek";
            //personel.Bolumu = "Yazılım";
            //personel.TcNo = "12345678912";
            //personel.Maas = 10000;

            //personelManager.Add(personel);
            #endregion

            #region Öğrenci örneği

            //Bir class olusturulacak ismi ögrenci olsun.
            //Tutulacak bilgiler : ögrenci No , adiSoyadi , ders ve dersNotu
            //2 methodumuzu olacak 
            //Ogrencinin verilerini ekrana doksun
            //Ogrencinin aldıgı nota gore(50) Gecti/Kaldı gibi bir mesaj göstersin..
            //Console.WriteLine("\t\t\t\t--------------------Öğrenci Bilgileri-----------------------");

            //StudentManager studentManager = new StudentManager();
            //clsOgrenci ogrenci = new clsOgrenci();

            //ogrenci.ogrNo= 1;
            //ogrenci.adiSoyadi = "Muhammed Ferit Simsek";
            //ogrenci.ders = "Yazılım";
            //ogrenci.dersNotu = 55;

            //studentManager.Add(ogrenci);

            //Console.WriteLine("-----------------------\n");

            //studentManager.Control(ogrenci.dersNotu);

            #endregion

            #region  Personel Örneği 2

            //Bu örneğin amacı class yapısının bu source dosyasından farklı bir yerde tanımlanması ve kullanılması üzerine 

            // Bir şirketimiz var 
            // 5 elemanı var .. AdSoyad , Ünvan , Maaş , Yıllıkİzin
            // Bir metodumuz olacak class içinde
            // Bu metodda öncelikle adSoyad bilgisinin dolu oldugu durumda maaşının miktarına göre o personelin kaç gün izin hakkı oldugu berlirlenecek..
            // Kriterler : Maaş 2500-10000 kina arasındaysa  Düz Personel ( Yıllık İzin 14 gün )
            // Maaş 10001 - 14000 Kina arasındaysa Kıdemli Personel ( Yıllık İzin 20 gün )
            // Maaş 14001 - 15500 Kina arasındaysa Kıdemli+ Personel (Sınırlar Dahil) ( Yıllık İzin 24 gün )
            // Maaş 15500 üstündeyse Uzman Personel ( Yıllık İzin 30 gün ) olarak çıkış veren şekilde olacak.

            // Not : Personelin  maaş bilgisinin belirlenmesi bilgisayara bırakılacak..Random aralığı 2500-20000

            EmployeeManager employeeManager = new EmployeeManager();
            

            Employee employee1 = new Employee();
            Random rnd = new Random();
            employee1.AdSoyad = "Muhammed Ferit Simsek";
            employee1.Maas = rnd.Next(2500, 20000); // 2500 ile 20000 arası sayi ürettiriyoruz..
            employee1.Unvan = null; // "" yada null veriyoruz çünkü aşağıda unvankontrol metodunda şarta göre içi doldurulacak..
            employee1.Izingunu =0; // 0 veriyouz  çünkü aşağıda unvankontrol metodunda şarta göre içi doldurulacak..
            employeeManager.UnvanKontrol(employee1); // maaş aralıgına göre kontrolleri yapan metod.
            

            employeeManager.Add(employee1); // ekrana yazdırdıgımız komut..
            




            #endregion

            Console.ReadKey();

        }

        #region Class and Methods
        class clsPersonel1
        {
            // Şimdi sıra geldi sınıfımın özelliklerini (properties) tanımlama

            //Properties
            public int PersonelID;
            public string Ad;
            public string Soyad;
            public string TCKNo;
            public string Bolum;
            public int Maas;


            public void setPersonelData(int pID, string pAd, string pSoyad, string pTCKNo, string pBolum, int pMaas)
            {
                // Bu metot class/object bigilerini set etmek için kullanılacak

                PersonelID = pID;
                Ad = pAd;
                Soyad = pSoyad;
                TCKNo = pTCKNo;
                Bolum = pBolum;
                Maas = pMaas;
            }

            public void getPersonelData()
            {
                Console.WriteLine($"\n\nPersonel No : {PersonelID}\nAdı ve Soyadı : {Ad} {Soyad}\nTc No : {TCKNo}\nBölümü : {Bolum}\nMaaş : {Maas} PNG Kina");
            }


        }
        #endregion

        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string Unvan;
        public int Maas;
        public int IzinGunu;
        public void setPersonelBilgileri (string pAd,string pSoyad, int pMaas)
        {
            if (pAd.Length>0 && pSoyad.Length>0)
            {
                Ad = pAd;
            }
        }
    }

}

