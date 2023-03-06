using _15_Abstraction;

internal class Program
{
    //Basit bir örnek üzerinden işleyece kolursak ; bir işletmemiz ve bu işletmeye bağlı çalışanlarımızın bilgilerinin yer alacağı, çeşitli işlemlere imkan verecek bir sınıfımız ve bu sınıfa özelliklerin atanmasını sağlayacağımız bir abstract class olusturarak gerekli bilgilerini çıktısını kullanıcıya iletmek isteyelim.
    //Bir örnek için uygulanacak asamalar ;

    //1. calısan bilgilerinin tutulacagı base konumunda bir abstract class olusturmak gerektiginden dolayı 
    // cls EmployeeBaseManager isminde bir abstract sınıf olusturalım.

    //2. Çalışanların bilgilerinin saklanacağı çeşitli değişkenler ve bu bilgilere göre çeşitli işlemler yapılmasının sağlanacağı bazı metot tanımlamaları gereçekleştirelim.

    //3. Her çalışan kişinin zam orani, yıllık izni gibi kavramlar çalışanın statüsüne ve deneyimine bağlı olarak değişeceği için abstract metot olarak bazı metotların da tanımlanması gerekmektedir...


    // Tanımlamalar gerçekleştirdikten sonra clsEmployeeBaseManager sınıfını içeriğini inceleyelim..
    private static void Main(string[] args)
    {

        // Öncelikle bir işçi ( Gemici ) oluşturalım.

        clsCreateEmployeeManager seamen = new clsCreateEmployeeManager(); // nesneyi olusturduk..
        // clsCreateEmployeeManager sınıfını seamen olarak tanımladık. sonra seamen.employeeBaseManager diyerek create sınıfı içerisinden employeeBaseManager (tanımlamıstık zaten) içerisindeki bilgilere erişmesini sağladık.. ve bunların içerisine clsEmployeeManager sınıfındaki değerleride atamış olduk..
        seamen.employeeBaseManager= new clsEmployeeManager(); // Gemiciler için

        seamen.Create();
        seamen.GetInfo();

        // Birde Kaptan için 
        clsCreateEmployeeManager captain = new clsCreateEmployeeManager(); // nesneyi olusturduk..
        captain.employeeBaseManager = new clsEngineerManager(); // Mühendisler için

        captain.Create();
        captain.GetInfo();  

        Console.ReadKey();
    }
}