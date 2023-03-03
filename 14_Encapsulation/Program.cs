using _14_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal Durum

        clsBank clsBank = new clsBank();

        clsBank.accountNumber = 1234567890;
        clsBank.accountName = "Satoshi Bank";
        clsBank.balance = 3500000;

        clsBank.GetBalance();
        clsBank.WithdrawAccount();
        clsBank.Deposit();

        #endregion
        Console.WriteLine("\n\n-------------------------------------------\n\n");
        #region Getter / Setter


        clsBank.SetBalanceCaps(1500);
        Console.WriteLine($"Balance size : {clsBank.GetBalanceCaps()}");

        #endregion

        Console.WriteLine("\n\n-------------------------------------------\n\n");

        #region Eğer sınıfı tasarlarken Kapsülleme(encapsülation) prensibine uymazsak ne olur?

        //Sınıfı tasarlarken C# kapsülleme prensibini takip etmezsek, kullanıcı tarafından verilen verileri iş gereksinimlerimize göre doğrulayamayız ve gelecekteki değişiklikleri ele almanın bu durumda çok zor oldugu açıktır..
        //Bunu bir örnekle anlayalım. İlk proje gereksiniminde müşterinin uygulamanın negatif sayının depolanmasına izin vermesi gerektiğini belirtmediğini varsayalım.. Bu nedenle değişkene sınıf dışından doğrudan erişim sağlarız ve şimdi kullanıcı aşağıdaki örnekte gösterildiği gibi herhangi bir değeri depolayabilir.
        // Burada , miktar değişkenine doğrudan clsBank sınıfının dışından eriştiğimizi ve hem pozitif hemde negatif değerler ayarladığımızı görebilirsiniz...

        clsBank clsBank1 = new clsBank();

        //Pozitif bir değerle Amount değerini güncelleyin.

        clsBank1.amount = 100;

        Console.WriteLine($"Bankadaki miktar : {clsBank1.amount} PNG Kina.");

        clsBank1.amount = -150;

        Console.WriteLine($"Bankadaki miktar : {clsBank1.amount} PNG Kina.");
        Console.WriteLine("\n\n-------------------------------------------\n\n");

        // Hata yakalamaa
        try
        {
            int deger;
            clsBank clsBank3 = new clsBank();

            Console.WriteLine("Lütfen değeri giriniz... : ");
            deger = Convert.ToInt32(Console.ReadLine());

            clsBank3.SetAmount(deger);
            Console.WriteLine($"Bankadaki miktar : {clsBank3.GetAmount()} PNG Kina.");
            
            Console.WriteLine("Lütfen değeri giriniz... : ");
            deger = Convert.ToInt32(Console.ReadLine());

            clsBank3.SetAmount(deger);
            Console.WriteLine($"Bankadaki miktar : {clsBank3.GetAmount()} PNG Kina.");

        }
        catch (Exception hata)
        {
            Console.WriteLine(hata.Message);
        }

        #endregion

        Console.ReadKey();
    }
}