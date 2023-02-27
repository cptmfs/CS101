internal class Program
{
    private static void Main(string[] args)
    {
        #region Matematiksel

        //// Mod alma operatoru...

        //int a = 5 % 2;

        //Console.WriteLine("Sonuc : " + a + "\n\n");

        //// Degisik bir durum , Eğer işlem yapılan her iki operant farklı türdeyse sonuc daha ust kapasiteli olan tipde tutulur.

        //float b = 5 / 2f; // burada 5 sayısı da  float gibi davranıyor ve sonuc ondalıklı cıkıyor . 

        //Console.WriteLine("Degisik durum sonucu : " + b);


        //// degisik durum 2 

        //float c = 2 / 5 / 2f;  //sonuc 0 cıkacaktır. Cünkü zaten islem sırasında sonuc 0 olmustu.

        //Console.WriteLine("Degisik durum 2 sonucu : " + c);

        //// degisik durum 3 

        //float d = 2f / 5 / 2;  // islem sol taraftan ondalıklı olarak basladıgı icin , sonuc ondalıklı  cıkacaktır.

        //Console.WriteLine("Degisik durum 3 sonucu : " + d);

        //// daha ilginc durum 

        //float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3;

        //Console.WriteLine("Daha ilginc durum sonucu : " + e);



        #endregion

        #region Bir arttırma ve Bir eksiltme operatorleri

        //int fonceki = 5;

        //int fsonraki = ++fonceki;  // ön ek örneği: hem fönceki değeri 1 arttırıyor , hemde bu degeri tutuyor sonrasında fsonraki degiskenin atıyor.

        //Console.WriteLine("Onceki İslem Sonucu : " + fonceki);
        //Console.WriteLine("Sonraki İslem Sonucu : " + fsonraki+"\n\n");

        //int gonceki = 20;

        //int gsonraki = gonceki++;  // Son ek örneği: önce gonceki değerini g sonrakiye aktarıyor .. sonra kendi degerini arttırıyor.

        //Console.WriteLine("Onceki İslem Sonucu : " + gonceki);
        //Console.WriteLine("Sonraki İslem Sonucu : " + gsonraki+"\n");

        //Console.WriteLine("\n"+"---------------------"+ "\n");

        #endregion

        #region OrtayaKarışık

        //int h = 5;

        //int i = h++;
        //int j = i--;
        //int k = 10;
        //int l = --k;

        //Console.WriteLine("İslem Sonucu : \n h={0}\n i={1}\n j={2}\n k={3}\n l={4}\n",h,i,j,k,l);

        #endregion

        #region Karsilastirma Operatorleri

        //bool m = 4 < 6;

        //bool n = 6 > 5;

        //bool o = 7 <= 7;

        //bool p = 9 >= 12;

        //bool q = 10 == 12;

        //bool r = 1 != 8;

        //Console.WriteLine("İslem Sonucu : \n m={0}\t n={1}\t o={2}\t p={3}\t q={4}\t r={5}\t", m,n,o,p,q,r);


        #endregion

        #region as operatörü 
        // tüm degisken turlerinden obje degisken turune ve obje turundende referans degiskenlere donusum islemini yapar.
        // eger  donusum olmazsa  null deger geri döner.

        object s = "50";

        string t = s as string;

        int u = 50;

        object v = u as object;

        #endregion

        Console.ReadKey();

    }
}