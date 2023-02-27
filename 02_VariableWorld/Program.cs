internal class Program
{
    private static void Main(string[] args)
    {

        #region adSoyad
        //string name;

        //string nameDesc;

        //string Name;

        //string NameDesc;

        //name = "Muhammed Ferit"; // degiskene deger atama..

        //nameDesc = "Benim adım : ";

        //NameDesc = "Soyadım : ";

        //Name = "Şimşek";

        //Console.WriteLine(nameDesc + "\t" + name + "\n\n\n");
        //Console.WriteLine("\n" + "---------------------");

        //Console.WriteLine("\n" + NameDesc + "\t" + Name + "\n\n\n");
        //Console.WriteLine("---------------------");
        #endregion

        #region sayisalIslemler

        //byte a = 5;
        //byte a1 = 255;
        //int toplam = a+a1;

        //Console.WriteLine("Toplam Degeri : "+ toplam.ToString());

        #endregion

        #region soru

        //byte a = 1;
        //byte b = 5;

        //string c = "hello";
        //string d = " whats up ?";

        //Console.WriteLine("Toplama Sonucu : "+ (a+b) + "\n\n"+ c+"\t"+d);
        #endregion

        #region isimBilgi

        ////Ekrana isim bilgisini almak için bir mesaj çıksın , klavyeden girilen bilgiyi ekrana yazılsın.

        //string adSoyad;

        //Console.WriteLine("Lütfen Adınızı Giriniz : ");
        //adSoyad = Console.ReadLine();

        //Console.WriteLine("\n\n\n" + "Adınız ve Soyadınız : " + adSoyad);

        #endregion

        #region Sıkyapilanhatalar

        // Aynı satırda farklı veri tiplerinden tanımlama yapma
        // Tanımlanan değişkene tanımlandıgı tipten farklı deger atama

        //int number;

        //number = "Ferit";

        // degiskeni tanımlamadan uzerine deger atamaya calısma

        // degiskenin tanımlama yerinin yanlıs yerde yapılması

        // bazı degisken turlerinin (float,date) gerekşi bazı tanımlamaların yapılmaması
        // ve ondalık sayıların 
        //float v;
        //v = 12.5f;

        // metinsel degiskenlerle matematiksel işlem yapmaya çalışmak.

        string a = "12345";
        string b = "12345";

        int c = Convert.ToInt32(a)+Convert.ToInt32(b);

        // bir degiskeni birden fazla tanımlamaya calısmak

        string a1;

        Console.WriteLine(c);
        

        #endregion
        Console.ReadKey();





    }
}