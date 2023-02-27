internal class Program
{
    private static void Main(string[] args)
    {
        #region Dizi tanımlama , değer atama , kullanma

        //int[] dizi = new int[20]; // 20 elemanlı bir dizi isimli bir dizi olusturulmus.

        //dizi[5] = 30; // 5. indexine bir deger atanıyor.

        //Console.WriteLine(dizi[5]);

        //string[] dizi1 = { "Bir", "İki", "Üç" };

        //int[] dizi2 = { 2, -4, 6 };

        //float[] dizi3 = { 2f, 1.2f, 7f };

        //int[] dizi4 = new int[] { 1, 2, 3 };

        // Kullanıcının girdigi degere göre +5 dizi ekledik. sonra ekrana 5 numaralı indexe atadıgımız sayıyı yazdırdık..

        //Console.WriteLine("1 ile 10 arasındaki bir sayi giriniz : ");
        //int boyut = Convert.ToInt32(Console.ReadLine());
        //int[]dizi5 = new int [boyut + 5];

        //dizi5[5] = 30;
        //Console.WriteLine(dizi5[5]);

        // birden fazla dizi tanımlama

        int[] dizi6 = new int[10], dizi7 = new int[20];

        //verilen bir strin dizinin, ters sırada ( sondan basa dogru ) listeleme

        //string[] sınıf = { "Muhammed", "Ferit", "Simsek" };

        //int son = sınıf.Length - 1;

        //for (int i = son; i >= 0; i--)
        //{
        //    Console.WriteLine(sınıf[i]);
        //}

        #endregion

        #region for/foreach donguleri

        // Verilen bir tamsayı dizisinin elemanlarının toplamını  for ve foreach dongulerını kullanarak ayrı ayrı gelistiriniz

        //for

        //int[] sayilar = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam = 0;

        //for (int index = 0; index < sayilar.Length; index++)
        //{
        //    toplam += sayilar[index];
        //}

        //Console.WriteLine(toplam);

        //foreach       
        //int[] sayilar = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam = 0;

        //foreach (int i in sayilar)
        //{
        //    toplam += i;
        //}

        //Console.WriteLine(toplam);

        // Tanımlana sayılar dizisi icersindeki sayıların negatif , pozitif ve isaretsiz olma durumlarını yanına yazdırma..

        //int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 100 };
        //int psayac = 0; 
        //int nsayac = 0;
        //int isaretsizsayac = 0;


        //foreach (var sayi in sayilar)
        //{

        //    if (sayi>0)
        //    {
        //        psayac++;
        //        Console.WriteLine(sayi + "Pozitiftir..");
        //    }
        //    else if (sayi<0)
        //    {
        //        nsayac++;
        //        Console.WriteLine(sayi+"Negatiftir..");
        //    }
        //    else
        //    {
        //        isaretsizsayac++;
        //        Console.WriteLine(sayi+"İşaretsizdir..");
        //    }
        //}

        //Console.WriteLine("\n\n"+psayac+"adet pozitif sayı vardır..");
        //Console.WriteLine(nsayac+ "adet negatif sayı vardır..");
        //Console.WriteLine(isaretsizsayac + "adet işaretsiz sayı vardır..");

        // Kullanıcıdan alınan metinin icindeki sesli harf sayısını bulma ve harfleri yazdırma ..

        //char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        //char[] hangileri = new char[10];
        //string metin;
        //char[] karakter;
        //int hindex = 0;
        //int sayac = 0;

        //Console.WriteLine("Metin giriniz : ");
        //metin = Console.ReadLine().ToLower(); // girilen metni kucuk harflere cevirdim ve girilen metni okudum.

        //for (int i = 0; i < sesliler.Length; i++) // sesliler dizisi üzerinde tek tek dolaşacak
        //{
        //    for (int j = 0; j < metin.Length; j++) // ekrandan alınan metini tek tek dolaşacak
        //    {
        //        if (metin[j] == sesliler[i]) // önce girilen metini dizi gibi algıtalıp , metindeki harfler sesliler                                  dizisindeki harflerle ortusuyormu ? 
        //        {
        //            hangileri[hindex] = metin[j];
        //            hindex++;

        //            sayac++; // ortusenleri bir bir tut

        //        }
        //    }

        //}
        //Console.WriteLine("Girdiğiniz metin içerisinde {0} adet sesli harf bulunmaktadır ", sayac);
        //Console.WriteLine(hangileri);


        // 10 elemanlı bir dizide bulunan pozitif , sıfır ve negatif degerlerin sayısını bulup yazma..


        //int[] sayilar = { 10, -3, 5, 8, 33, -22, -33, 0, 21, };

        //int sifirSay = 0, pozitifSay = 0, negatifSay = 0;

        //for (int i = 0; i < sayilar.Count(); i++)
        //{
        //    if (sayilar[i]<0)
        //    {
        //        negatifSay++;
        //    }
        //    else if (sayilar[i]>0)
        //    {
        //        pozitifSay++;
        //    }
        //    else
        //    {
        //        sifirSay++;
        //    }
        //}
        //Console.WriteLine("Sıfırların Sayısı : "+sifirSay);
        //Console.WriteLine("Negatiflerin Sayısı : " + negatifSay);
        //Console.WriteLine("Pozitiflerin Sayısı : " + pozitifSay);

        #endregion


        #region Cok boyutlu diziler

        //int[,] dizi1 = new int[3, 2];  // 2 boyutlu dizi
        //int[,] dizi2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        //int[,,] dizi3 = new int [3, 2, 2];  // 3 boyutlu dizi
        //int[,,] dizi4 = { { { 1, 2 }, { 3, 4 }, { 4, 5 }, { 5, 6 }, { 6, 7 }, { 7, 8 }, { 9, 10 }, { 11, 12 } } };

        //for (int i = 0; i < 3; i++)
        //    for (int j = 0; j < 2; j++)
        //        for (int k = 0; k < 2; k++)
        //            dizi4[i, j, k] = 20;
        #endregion

        #region Dizilerde kullanılan bazı metotlar

        // Get Lenght ****

        //int[] dizi5 = { 1, 4, 7, 8, 9 };

        //Console.WriteLine(dizi5.GetLength(0));

        //

        //int[,] dizi8 = { { 2, 4, 2 }, { 5, 4, 3 }, { 7, 4, 5 }, { 9, 4, 5 } };

        //byte boyut1 = (byte)dizi6.GetLength(0);

        //Console.WriteLine(boyut1);


        // CreateInstance **********

        //Array dizi9 = Array.CreateInstance(typeof(int), 5); // int turunde 5 elemanlı dizi9 adında bir dizi tanımlandı ve dizinin her bir elemanına int turunun varsiyaln bir degeri atandı.

        //Array dizi10 = Array.CreateInstance(typeof(int), 3,2,5); // 3boyutlu

        // ilginc bir kullanım ornegi..

        int[] dizi11 = new int[5] { 2, 3, 6, 8, 7 }; // diziyi olusturuken init degerleride atadık.


        // Dizi kopyalama *******

        //int[] dizi12 = { 1, 2, 3, 4 };

        //int[] dizi13 = new int[10];
        //dizi12.CopyTo(dizi13,3); // burda dizi 12 nin tüm elemanları dizi 13 ün 3. indexinden itibaren kopyalanır..


        //int[] dizi14 = {1,2,3,4,5,6,7};
        //int[] dizi15 = new int[10];
        //Array.Copy(dizi14, 2, dizi15, 7, 3); // burada dizi 14 ün 2. indeksinden itibaren 3 eleman, dizi 15'in 7. indeksten itibaren kopyalanır..

        // Dizi sıralama ******

        //diziyi CreateInstance ile olusturup. İcini doldurup sıralamasını hazır metodla yaptırmak...

        //Array metinsel = Array.CreateInstance(typeof(string), 8);

        //metinsel.SetValue("İstanbul", 0);
        //metinsel.SetValue("Ankara", 1);
        //metinsel.SetValue("Bursa", 2);
        //metinsel.SetValue("İzmir", 3);
        //metinsel.SetValue("Bitlis", 4);
        //metinsel.SetValue("Bolu", 5);
        //metinsel.SetValue("Kastamonu", 6);
        //metinsel.SetValue("Urfa", 7);

        //Console.WriteLine("\n\n---- Sırasız dizi : ");

        //foreach (var sehirler in metinsel)
        //{
        //    Console.Write(sehirler+" ");
        //}

        //Console.WriteLine("\n\n---- Sıralı dizi : ");

        //Array.Sort(metinsel); // sehirleri harf sırasına göre sıralıyor "Sort" komutu.. 
        //foreach (var sehirler in metinsel)
        //{
        //    Console.Write(sehirler + " ");
        //}

        //Console.WriteLine("\n\n---- Ters Sıralı dizi : ");

        //Array.Reverse(metinsel); // sehirleri harf sırasına göre ters sıralıyor "Reverse" komutu.. 
        //foreach (var sehirler in metinsel)
        //{
        //    Console.Write(sehirler + " ");
        //}


        // Dizilerde arama (searching)

        int[] dizi16 = { 500, 68, 234, 56, 2 };

        Array.Sort(dizi16); // kucukten buyuge sıralama metodu Sort .. 
        Array.Reverse(dizi16);  // Buyukten kucuge sıralamak için önce Sort komutu calıstırıp sonra Reverse                         calıstırmak gerekiyor.
        foreach (var sayi in dizi16)
        {
            Console.Write(sayi + " ");

        }

        Console.Write("\nDizi16 Index : " + Array.BinarySearch(dizi16, 56));
        // Binary Search metodu bir nesneyi ( Örn:56) dizi içerisinde arar eğer bulursa , onun bulundugu indexi verir. Bulamazsa negatif bir deger tutar..
        // eger Binary Search kullanmak istiyorsak önce diziyi bir sort ile sıralamak gerekiyor..
        if (Array.BinarySearch(dizi16, 56)<0)
        {
            Console.WriteLine("Aramıs oldugunuz deger bulunamadı..");
        }
        #endregion

        Console.ReadKey();
    }

}