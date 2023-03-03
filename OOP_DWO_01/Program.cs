using OOP_DWO_01;

internal class Program
{
    private static void Main(string[] args)
    {
        // Human adlı bir sınıf olusturarak adınızı , İş Tanımınızı , Doğum Tarihinizi oluşturunuz.. İster Ekrandan alarak ister hard coded olacak şekilde
        // Fruit isimli bir classınız daha olsun. Burada bir meyve tanımı (Elma) olusturunuz... İster ekrandan alarak ister hard coded olacak şekilde..
        // Human sınıfından oluşan nesneniz Elma yesin.. ve bunu bir mesaj ile ekrana yazdırın..

        // Game isimli bir sınıfınız olsun. Human sınıfından olusturulan bir nesneniz için istediğiniz bir "...." şu oyunu oynuyor "..." gibi bir mesaj verilsin..

        // Human sınıfından birden fazla  nesne üretebilirsiniz...

        string name, title;
        DateTime birthday;

        Human human = new Human();


        Console.WriteLine("Lütfen Adınızı Giriniz..  : ");
        name = Console.ReadLine();
        Console.WriteLine("Lütfen Ünvanınızı Giriniz..  : ");
        title = Console.ReadLine();
        Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz..  (MM/dd/yyyy)   : ");
        birthday = Convert.ToDateTime(Console.ReadLine());
        human.SetHuman(name,title,birthday);

        Fruit meyve = new Fruit();

        meyve.fruit = "Elma";

        Console.WriteLine($"{name} program ağacından 1 Adet {meyve.fruit} yedi ");

        Game game = new Game();

        game.callOfDuty = "Call Of Duty Black Ops Cold War";

        Console.WriteLine($"\n\n{name} Konsol üzerinde {title} ünvanı ile {game.callOfDuty} oyununu oynuyor..");



        Console.ReadKey();
    }
}