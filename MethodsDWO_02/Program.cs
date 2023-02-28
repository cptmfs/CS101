using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDWO_02
{
    internal class Program
    {
        // Global Degiskenler..

        // datUsers
        public static string[,] datUsers = new string[,] // 2 boyutlu dizi 
        {
            {"admin", "ferit", "cptmfs"},  // kullanıcı adları
            {"admin", "1234", "5678"},     // Şifreler
            {"ADMİN", "User", "User"},     // Kullanıcı Türü
            {"+"    , "-"   , "-"},        // Kullanıcı Yetkileri
        };
        public static string userAuthority; // Admin yada User 
        public static string userStatus;    // Kullanıcı Aktif mi Pasif mi ? 

        public static string[] datLog = new string[10]; //Log dizisi..  // Tek boyutlu dizi...

        public static int indexLog =0;

        static void Main(string[] args)
        {
            //kullanıcı adi , sifresi , yetkisi , aktifliğini iceren bir dizi var.
            // (User Tablosu Gibi )
            // 4x3 boyutunda manuel  (hard coded) olusturulacak..
            // K1,K2,K3 -- kullanıcı adları
            // P1,P2,P3 -- sifreleri
            // A ,K ,K  -- yetki derecesi ( Admin'mi normal kullanıcımı?)
            // + ,+ ,+  -- kullanıcının aktifliği ( + aktif , - pasif )
            //
            // bunun disinda sistem üzerindeki islemleri izleyebilecegim ( Admin'in ) bir log dizisi var. ( Tek Boyutlu )
            //
            // 1. Program ilk calıstıgında kullanıcıyı bir  Ana Menu karsılayacak (Metodsal Yapı).. Secenekler 1. Sisteme Giris , 2. Cıkıs..
            // 2. Sisteme Giris'e basildiginda Kullanıcının karsisina bir login ekranı gelmeli.
            // 3. Kullanıcıdan userName ve passWord istenecek..
            // 4. Bir kontrol islemiyle(datUser dizisi) kullanıcının var olup olmadıgı kontrol edilecek.. Yok ise ;   Uyarı Mesajı verilecek.. ve Tekrar Login Ekranına Gönderilecek.. Var ise ; Kullanıcının diger bilgileri (yetki ve aktiflik) ögrenilecek.. Buna göre yetki durumuna baglı olarak farklı ekranlar gösterilecek.. Yani ; Admin ise (Admin Paneli) User ise (Yapacağı İşlemler Listesi) gibi..
            // 5. Yapılan işlemler datLog isimli bir diziye işlenecek.. Admin istediğinde bu kayıtlar listelenecek.. Bu Secenek Admin Menusunde olacak..

            bool showMenu = true;

            while (showMenu)
            {
                showMenu = mainMenu();

            }
            Console.WriteLine("Çıkış için herhangi bir tuşa basınız...");
            Console.ReadKey();

        }

        private static bool mainMenu()
        {
            bool showLogin = true;
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t ------ Ana Menü ------ ");
            Console.WriteLine("1. Sistem Giriş");
            Console.WriteLine("2. Programdan Çıkış");
            Console.Write("\nSeçeneğiniz : ");

            switch (Console.ReadLine())
            {
                case "1":
                    while (showLogin)
                    {
                        showLogin = loginMenu();
                    }
                    return true;

                case "2":

                    //Programdan Cikis bolumu..
                    return false;
                default:
                    return true;

            }


        }
        private static bool loginMenu()
        {
            // Not : Her Sifre  karakteri girdiginde , sifre bölümünde yildiz gözüksün..
            string userID = "", userPass = "";

            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t ------ Kullanıcı Girişi ------ ");
            Console.WriteLine("Ana Menüye dönmek için * a basınız ..\n");
            Console.WriteLine("Lütfen Kullanıcı adını giriniz : ");
            userID = Console.ReadLine().Trim();
            if (userID == "*")
            {
                return false;
            }

            Console.WriteLine("Lütfen Şifrenizi giriniz : ");
            
            userPass = Console.ReadLine();
            Console.WriteLine();
            userPass = userPass.Trim();



            if (UserControl(datUsers, userID, userPass))
            {
                // eger kullanıcı bulunduysa ..
                Console.WriteLine("Kullanıcı Girişi Başarılı!   \n\n");
                Console.WriteLine($"Kullanıcı Yetki Seviyesi  : {userAuthority}\n\n");
                Console.WriteLine($"Kullanıcı Durumu  : {userStatus}\n\n");
                

                printLog(userID);          
            }
            else
            {
                Console.WriteLine("Kullanıcı Girişi Başarısız..");
            }
            Console.ReadKey();
            //Console.WriteLine("Ana menü için 3 e basınız");
            //int anaMenu = Convert.ToInt32(Console.ReadLine());
            //if (anaMenu==3)
            //{
            //    mainMenu();
            //}
            
            return true;
        }
        private static bool UserControl(string[,] prmUsers, string prmUser, string prmPass)
        {

            bool found = false; // Kullanıcının bulunup bulunmadıgını belirten bir degisken

            // içiçe for döngüleri yardımıyla  tüm dizi  ögelerini dolasalım.

            for (int satir = 0; satir < prmUsers.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < prmUsers.GetLength(1); sutun++)
                {
                    if (prmUsers[satir, sutun] == prmUser) // eslesen kullanıcı varmı ? 
                    {
                        if (prmUsers[satir + 1, sutun] == prmPass) // kullanıcının alt satırında aynı sutundaki sifre eslesiyormu ?
                        {
                            userAuthority = prmUsers[satir + 2, sutun]; // kullanıcı adı sifre eslesen yerde kullanıcı adının 2 satır altında tanımladıgımız . Admin User gibi kullanıcı  Türünü atıyoruz.
                            userStatus = prmUsers[satir + 3, sutun]; // kullanıcı adı sifre eslesen yerde kullanıcı adının 3 satır altında tanımladıgımız . + / - gibi kullanıcı  aktiflik pasiflik durumunu atıyoruz.

                            found = true; // Kullanıcıyı buldum. 
                            break;  // döngüden sonlandır..
                        }
                    }

                }
                if (found == true)
                {
                    break;
                }
            }
            return found;
        }

        private static string printLog(string kullaniciAdi)
        {
            datLog[indexLog] = $"{kullaniciAdi} isimli kullanıcı sisteme giriş yapmıştır..";
            indexLog++;

            for (int i = 0; i < indexLog; i++)
            {
                Console.WriteLine("Log Kaydı : " + datLog[i] + "\tGiriş Zamanı : " + DateTime.Now);
            }

            return kullaniciAdi;
        }
    }
}
