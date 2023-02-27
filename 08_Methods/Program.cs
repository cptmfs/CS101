internal class Program
{
    private static void Main(string[] args)
    {
        // Dikdörtgenin alanını hesaplayan bir methodun 4 farklı şeklinin incelenmesi

        #region Geriye değer döndürmeyen ve parametre almayan

        //hesapla();


        #endregion

        #region  Geriye değer döndürmeyen ve parametre alandır.

        //int uzunKenar, kisaKenar;
        //Console.WriteLine("Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
        //uzunKenar = int.Parse(Console.ReadLine());
        //Console.WriteLine("Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
        //kisaKenar = int.Parse(Console.ReadLine());

        //hesapla(uzunKenar, kisaKenar);



        #endregion

        #region Geriye değer döndüren ve parametre almayan

        //int sonuc = hesaplaParametresiz(); // sonuc = alan ( return'den gelen )

        //Console.WriteLine("Girdiğiniz Değerlere Göre oluşturulan Dikdörtgenin Alanı : {0}", sonuc);

        #endregion

        #region Geriye değer döndüren ve parametre alan

        //Console.WriteLine("Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
        //int uKenar = int.Parse(Console.ReadLine());
        //Console.WriteLine("Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
        //int kKenar = int.Parse(Console.ReadLine());

        //int sonuc = hesaplaParametreli(kKenar,uKenar);

        //Console.WriteLine("Alan = {0}",sonuc);

        #endregion


        #region

        //Soru : Uygun metod yapısı kullanarak  4 islemi gerçekleştiriniz ( +,-,*,/). Birden fazla  metod  tanımlayabilirsiniz..
        // Ek : İslem tipinide alıp ona göre düsünelim..
        //Console.WriteLine("Lütfen sayi1'i giriniz : ");
        //int sayi1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Lütfen sayi2'yi giriniz : ");
        //int sayi2 = int.Parse(Console.ReadLine());
        //Console.Write("\n Bölme İşlemi için :/ \n Çarpma İşlemi için :* \n Toplama İşlemi için :+ \n Çıkarma İşlemi için :- yazınız..\nLütfen yapmak istediğiniz işlemi yazınız : ");
        //string islem = Console.ReadLine();

        //Console.WriteLine("İşlem Türü : {0}\nİşlemin Sonucu : {1} ", islem, DortIslem(sayi1, sayi2, islem));



        #endregion

        #region Metotlarda aşırı yüklenme

        //Console.WriteLine("2'li Toplama işlemi  Sonucu : {0}", toplamaIslemi(45, 45));
        //Console.WriteLine("3'li Toplama işlemi  Sonucu : {0}", toplamaIslemi(45, 45,90));
        //Console.WriteLine("4'li Toplama işlemi  Sonucu : {0}", toplamaIslemi(45, 45,127,138));


        #endregion

        #region Soru : menülü bişi

        // Ekrana seçenekli bir menü gelicek..
        //Secenekler 1) Hesap makinesi , 2) Tek/Çift Kontrol..
        // Buna göre metodları hazırlayınız.. ( menüyü ekrana getirme, hesap makinesi , tek çift)

        // İlk secenekte Normal hesap makinesi
        //İkicinci secenekte

        Menu();

        #endregion




        Console.ReadKey();
    }

    #region Metotlar

    private static void hesapla()
    {

        int uKenar, kKenar;
        Console.WriteLine("Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
        uKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
        kKenar = int.Parse(Console.ReadLine());
        int alan = Convert.ToInt32(kKenar * uKenar);
        Console.WriteLine("Girdiğiniz Değerlere Göre oluşturulan Dikdörtgenin Alanı : {0}", alan + "\t' dir ...");
    }

    private static void hesapla(int kisaKenar, int uzunKenar)
    {

        int alan = Convert.ToInt32(kisaKenar * uzunKenar);

        Console.WriteLine("Girdiğiniz Değerlere Göre oluşturulan Dikdörtgenin Alanı : {0}", alan + "\t' dir ...");

    }

    private static int hesaplaParametresiz()
    {
        //Geriye değer döndüren metotlar/funcitonlar da  mutlaka return tanımı olmalıdır..
        Console.WriteLine("Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
        int uKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
        int kKenar = int.Parse(Console.ReadLine());


        int alan = kKenar * uKenar;

        return alan; // geri döndürülen bilgi..
    }

    private static int hesaplaParametreli(int kKenar, int uKenar)
    {
        return kKenar * uKenar;
    }


    private static int topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    private static int Cikarma(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    private static int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    private static int Bol(int sayi1, int sayi2)
    {
        return sayi1 / sayi2;
    }

    private static void hepsi(int sayi1, int sayi2)
    {
        int topla = sayi1 + sayi2;
        int cikar = sayi1 - sayi2;
        int carp = sayi1 * sayi2;
        int bol = sayi1 / sayi2;

        Console.WriteLine("Girdiğiniz sayıların toplamı : " + topla);
        Console.WriteLine("Girdiğiniz sayıların toplamı : " + cikar);

        Console.WriteLine("Girdiğiniz sayıların toplamı : " + carp);

        Console.WriteLine("Girdiğiniz sayıların toplamı : " + bol);

    }

    private static int DortIslem(int sayi1, int sayi2, string islem)
    {
        int sonuc = 0;

        if (islem == "+")
        {
            sonuc = sayi1 + sayi2;

        }

        else if (islem == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (islem == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else if (islem == "/")
        {
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch (Exception)
            {

                Console.WriteLine("sayi2 değeri 0.. değerlerin sırasını değiştiriyorum..");
                sonuc = sayi2 / sayi1;

            }
        }
        return sonuc;
    }

    private static int toplamaIslemi(int a, int b)
    {
        return a + b;
    }
    private static int toplamaIslemi(int a, int b, int c)
    {
        return a + b + c;
    }
    private static int toplamaIslemi(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

    public static void Menu()
    {
        Console.WriteLine("Hesap Makinesi için : H \t Tek/Çift Kontrol için : T  'ye basınız...");
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : ");
        string secenek = Console.ReadLine();

        if (secenek == "h" || secenek == "H")
        {
            Console.WriteLine("İşlem Sonucu : " + hesapMakinesi());
        }
        else if (secenek == "t" || secenek == "T")
        {
            Console.WriteLine("Girdiğiniz Sayi  : " + tekCiftKontrol());
        }
        else
        {
            Console.WriteLine("Lütfen Düzgün Değer Giriniz..");
        }
    }

    public static int hesapMakinesi()
    {
        Console.WriteLine("Lütfen sayi1'i giriniz : ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen sayi2'yi giriniz : ");
        int sayi2 = int.Parse(Console.ReadLine());
        Console.Write("\n Bölme İşlemi için :/ \n Çarpma İşlemi için :* \n Toplama İşlemi için :+ \n Çıkarma İşlemi için :- yazınız..\nLütfen yapmak istediğiniz işlemi yazınız : ");
        string islem = Console.ReadLine();

        int sonuc = 0;

        if (islem == "+")
        {
            sonuc = sayi1 + sayi2;

        }

        else if (islem == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (islem == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else if (islem == "/")
        {
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch (Exception)
            {

                Console.WriteLine("sayi2 değeri 0.. değerlerin sırasını değiştiriyorum..");
                sonuc = sayi2 / sayi1;

            }


        }
        return sonuc;
    }

    public static string tekCiftKontrol()
    {
        Console.WriteLine("Lütfen Tek/Cift durumunu kontrol etmek istediğiniz  sayiyi giriniz : ");
        int sayi = int.Parse(Console.ReadLine());
        string sonuc;
        if (sayi%2==0)
        {
            sonuc = "Çift Sayıdır";
        }
        else
        {
            sonuc = "Tek Sayıdır";

        }

        return sonuc;

    }
}
    #endregion



