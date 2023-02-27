internal class Program
{
    private static void Main(string[] args)
    {
        #region if-else

        //int c = 5, d = 7;


        //if (c < d)
        //{
        //    Console.WriteLine("C değeri d değerinden küçüktür.... ");
        //    Console.WriteLine(c);
        //}

        //else
        //{
        //    Console.WriteLine("c değeri d değerinden büyüktür..");
        //    Console.WriteLine(d);
        //}

        //int e = 5, f = 7;

        //if (e > f)
        //{
        //    Console.WriteLine("e f den küçüktür..");
        //}

        // Şöyle bir durum olabilir.


        //Console.WriteLine("Lütfen cinsiyet bilgisini giriniz..( E / K ) \n");

        //char cinsiyet = Convert.ToChar(Console.ReadLine());

        //if (cinsiyet == 'e')
        //{
        //    Console.WriteLine("Cinsiyet : Erkek " );
        //}
        //else if (cinsiyet == 'k')
        //{
        //    Console.WriteLine("Cinsiyet : Kadın ");
        //}

        //else
        //{
        //    Console.WriteLine("Lütfen doğru karakter giriniz ... ");
        //}

        // Ekrandan parola bilgisi al parola : 1234 ise doğru değilse yanlış olsun..

        //Console.WriteLine("Lütfen Parolayı Giriniz : ");

        //int parola = Convert.ToInt32(Console.ReadLine());

        //if (parola == 1234)
        //{
        //    Console.WriteLine("Girdiğiniz parola doğru ..");
        //}
        //else if (parola == 133441)
        //{
        //    Console.WriteLine("Admin girişi yaptınız..");
        //}

        //else
        //{
        //    Console.WriteLine("Gerçersiz Giriş XXXXXX");
        //}


        // ikili kontrol : ekrandan gelen  hem kullanıcı adı  hemde  şifresi alınacak, ve kontrol..


        //const string UN = "cptmfs";
        //const string UP = "Q1W2e3";

        //Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : ");
        //string userName = Console.ReadLine();
        //Console.WriteLine("Lütfen Şifrenizi Giriniz : ");        
        //string pw = Console.ReadLine();

        //if (userName == UN && pw == UP)
        //{
        //    Console.WriteLine("Kullanıcı adı ve şifreniz doğrudur...");
        //}
        //else
        //{
        //    Console.WriteLine("Kullanıcı adı yada şifre yanlış! Tekrar giriş yapınız..");
        //}


        // Detaylı olarak hangi bilginin yanlıs oldugunu belirtmek için kullanılabilir.

        //string userName;
        //string pw;
        //const string UN = "cptmfs";
        //const string UP = "Q1W2e3";

        //Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : ");
        //userName = Console.ReadLine();
        //    Console.WriteLine("Lütfen Şifrenizi Giriniz : ");
        //pw = Console.ReadLine();

        //if (userName == UN)
        //{
        //    if (pw == UP)
        //    {
        //        Console.WriteLine("Kullanıcı Adı ve Şifreniz Doğrudur..");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girdiğiniz Parola Yanlıştır...");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Kullanıcı adınız yanlıştır. Lütfen Kontrol Edin..");
        //}
        #endregion

        #region switch-case

        //int g = 6;

        //switch (g)
        //{

        //    case 4: Console.WriteLine("değer 4 ...");
        //        break;
        //    case 5:
        //        Console.WriteLine("değer 5 ...");
        //        break;

        //    case 6:
        //        Console.WriteLine("değer 6 ...");
        //        break;

        //    default:
        //        break;
        //}


        //int sayi = 4;

        //Console.WriteLine("Lütfen 1 ile 5 arası sayı girin");
        // sayi = Convert.ToInt32(Console.ReadLine());

        //switch (sayi)
        //{

        //    case 1: Console.WriteLine("Tahmin edemediniz tekrar deneyin .. ");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tahmin edemediniz tekrar deneyin .. ");
        //        break;
        //    case 3:
        //        Console.WriteLine("Tahmin edemediniz tekrar deneyin .. ");
        //        break;
        //    case 4:
        //        Console.WriteLine("DOĞRUU .. ");
        //        break;
        //    case 5:
        //        Console.WriteLine("Çok yaklaştın tekrar deneyin .. ");
        //        break;

        //    default:
        //        break;
        //}


        //string ad, soyad;

        //Console.WriteLine("Lütfen Adınızı Giriniz...");

        //ad= Console.ReadLine();

        //switch (ad)
        //{

        //    case "Ferit":

        //        Console.WriteLine("Lütfen Soyadınızı Giriniz...");

        //        soyad = Console.ReadLine();

        //        Console.WriteLine("Girmiş oldugunuz bilgi : " + ad +" "+soyad);
        //        break;
        //    default:
        //        Console.WriteLine("Yanlış Format..");
        //        break;
        //}

        //int j = 5;
        //switch (j)
        //{
        //    case 4: 
        //        string k1= Console.ReadLine();
        //        Console.WriteLine(k1);
        //        break;

        //    case 5:
        //        Console.WriteLine("Şimdi case 4'e gideceksiniz.");
        //            goto case 4;
        //    default:
        //        Console.WriteLine("Deneme");
        //        break;
        //}


        #endregion


        #region for

        // 1 den 10 a kadar sayıların toplamı..

        //int toplam = 0;

        //for (int i = 0; i <=10; i++)
        //{
        //    toplam = toplam + i;
        //    //toplam += i;
        //}

        //Console.WriteLine(toplam);

        // 

        //string deger = "Muhammed Ferit Şimşek";

        //for (int i = deger.Length-1; i >=0 ; i--)
        //{
        //    Console.WriteLine(deger[i]);
        //}

        //
        // girdiginiz herhangi bir sayinin faktoriyel hesabı.

        //float s;
        //int t, f;  //f degiskeni faktoriyel.
        //bool a=true; //girilen degerin pozitiflik durumunu belirlemek için.

        //for (; a; ) // esas döngü olayı bloğun içinde biz sadece baslamasını sagladık.
        //{
        //    Console.WriteLine("Lütfen faktöriyeli alınacak sayiyi giriniz : ");

        //    s= Convert.ToSingle(Console.ReadLine());    

        //    t= (int)s; // tip değişimi için zorluyorum  .

        //    if (t != s || s<1)
        //    {
        //        Console.WriteLine("Lütfen pozitif  bir tamsayı giriniz..");
        //        a = false;
        //    }
        //    else // eger pozitif girmisse asagidaki koddan devam..
        //    {
        //        a = true;

        //        for (f = 1; t > 1; t--)
        //        {
        //            f *= t;

        //        }
        //        Console.WriteLine("Faktöriyel  = {0}", f);
        //    }
        //}


        // 
        //1 den 1000 e kadar (sınırlar dahil) olan sayılar icerisinde 5 e tam bölünen ancak 7 ye tam bölünemeyen sayıları alt alta listeyen , bu sayıların kaç tane oldugunu ve toplamını yazan bir program yazınız..

        //int toplam=0,adet=0,sayi;



        //for (sayi = 1; sayi <= 1000; sayi++)
        //{
        //    if (sayi % 5 == 0 && sayi % 7 !=0)
        //    {
        //        adet++; // koşula uyan bir sayı buldum.
        //        toplam += sayi;  // toplam = toplam + sayi
        //        Console.WriteLine(sayi+"\n");
        //    }

        //}

        //Console.WriteLine("Sayiların adedi : {0} adettir.",adet);
        //Console.WriteLine("Sayiların toplamı : {0}'dir",toplam);

        // Konsol ekranına girilen 0-100 sınırlar dahil arasındaki 3 notun en buyugunu en kucugunu ve ortalamasını yazan program.


        //int enBuyukNot = 0; // enbüyük notu belirtsin
        //int toplam = 0;
        //int enKucukNot = 0;
        //int not = 0;

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(i+". notu giriniz :");
        //    not = Convert.ToInt32(Console.ReadLine());

        //    if (not > 100 || not < 0 )
        //    {
        //        Console.WriteLine("Lütfen 0 ile 100 arası bir not giriniz.. ");

        //        i--;

        //        continue;
        //    }

        //    if (i==0)
        //    {
        //        enBuyukNot = not;
        //        enKucukNot = not;
        //    }
        //    else
        //    {
        //        if (not>enBuyukNot)
        //        {
        //            enBuyukNot = not;
        //        }
        //        if (not<enKucukNot)
        //        {
        //            enKucukNot = not;
        //        }
        //    }

        //    toplam += not;
        //}

        //Console.WriteLine("En Büyük Sayi : {0}\n En Küçük : {1}\n Ortalama : {2}",enBuyukNot,enKucukNot,toplam/3);





        #endregion

        #region while

        // 0-100 arasındaki sayıların toplamı.

        //int toplam = 0;
        //int i = 0;

        //while (i<100) // i kücük 100 oldugu sürece asagidaki blogu calıstır.
        //{
        //    toplam += i; // toplama islemini gerçekleştir
        //    i++; // i yi bir arttır
        //}

        //Console.WriteLine(toplam);

        // asagadaki islemde int sayi isimli bir degisken olusturulup icine klavyeden gelen string deger donuserek atanmıstır. Cunku while dongusu buyuktur(>) operatoru kullanmak icin bir sayiya ihtyiyacımız vardır ve int degiskenler buyuktur operatorunu kullanabilecegimiz sayıyıy tutmaktadır.

        // ekrandan girilen sayının basamaklarını bulan program parcası.

        //Console.WriteLine("Lütfen bir sayı giriniz..");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //int basamak = 0;

        //while (sayi>0)
        //{
        //    basamak++;
        //    sayi = sayi / 10; // sayiyi 10 al böldük ve 1 basamak atladık sayı halen 0 dan büyük ise tekrar yukarı dönüp basamak degerini 1 daha arttıracak bu döngü sürdükce 0 dan kücük olana kadar devam edecek ve kac basamaklı oldugunu basamak degiskeninde tutacak..
        //}

        //Console.WriteLine("Girdiginiz sayi : "+basamak+"\tbasamaklıdır..");

        #endregion

        #region do while

        // Klavyeden yaşı girilen 10 kişiden kaçının askere gidip gidemeyeceğini bulan C# programının kodları:

        //int sayac= 0;
        //int i = 0;

        //do
        //{
        //    Console.WriteLine("Lütfen : {0}",(i+1)+".nci yaşı girinizz");

        //    int yas = Convert.ToInt32(Console.ReadLine());

        //    if (yas>=20)
        //    {
        //        sayac++;
        //    }

        //    i++;


        //} while (i<10);

        //Console.WriteLine("Girilen değerlere göre askere gidecek kişi sayısı : "+ sayac);
        //Console.WriteLine("Girilen değerlere göre askere gidemeyecek kişi sayısı : "+(10-sayac));

        // 
        int toplam = 0;
        int sayac = 0;
        
        do
        {
            sayac++;
            toplam += sayac;

        } while (sayac <3);

        Console.WriteLine("Toplam : "+toplam+"\tSayac : "+sayac);



        #endregion





        Console.ReadKey();

    }
}