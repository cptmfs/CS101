internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata olusturabilecek durum


        //int a = 100;
        //int b =0; // istenmeyen bazı durumlarda aslında 0 olmayan bu deger 0 lanmıs olabilir...

        //    Console.WriteLine("{0}/ {1} işleminin sonucu : {2} ", a, b, a / b);


        #endregion

        #region Hata Avcısıı Try-Catch

        //int c = 100;
        //int d = 0; // istenmeyen bazı durumlarda aslında 0 olmayan bu deger 0 lanmıs olabilir...

        //try
        //{
        //    Console.WriteLine("{0}/ {1} işleminin sonucu : {2} ", c, d, c / d);
        //}
        //catch
        //{
        //    if (c != 0 && d == 0)
        //    {
        //        d = c / 10;
        //        Console.WriteLine("D degeri  hata olusturdugundan dolayı güncellenmis ve {0} degeri atanmıstır.. \n {1}/ {2} işleminin sonucu : {3} ", d, c, d, c / d);

        //    }
        //    else if (c==0 && d !=0)
        //    {
        //        c = d * 10;
        //        Console.WriteLine("C degeri  hata olusturdugundan dolayı güncellenmis ve {0} degeri atanmıstır.. \n {1}/ {2} işleminin sonucu : {3} ", c, c, d, c / d);
        //    }
        //    else if (c==0 && d==0)
        //    {
        //        c = 50; d = 20;

        //        Console.WriteLine("C ve D degeri  hata olusturdugundan dolayı güncellenmis ve {0} ve {1} degeri atanmıstır.. \n {2}/ {3} işleminin sonucu : {4} ", c, d, c, d ,c/ d);
        //    }
        //}

        #endregion

        #region Hata Metodları

        byte deger;

        try
        {
            Console.WriteLine("Byte türünden bir deger giriniz  : ");
            deger = Convert.ToByte(Console.ReadLine());

        }
        catch (Exception hata)
        {

            Console.WriteLine("Message : {0}\n Source: {1}\nStackTrace : {2}\nTargetSite : {3}", hata.Message, hata.Source, hata.StackTrace, hata.TargetSite);
        }

        #endregion

        Console.ReadKey();
    }
}