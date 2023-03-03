using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {

        // Kural : class ismiyle aynı olacak bir metotdur.
        // ctor class devreye girdiginde otomatik olarak calısan bir metotdur.
        // degisik durumlarda initial islemler yapmak için kullanılır..
        // parametreli de kullanımı olabilir.

        #region Standart Yapı

        //clsTest clsTest = new clsTest();

        //Console.WriteLine($"i Değeri : {clsTest.i} \ns Değeri : {clsTest.s} \nb Değeri : {clsTest.b}");

        #endregion

        // Constructor Tipleri

        // Default or Parameterless Constructor -- standart/parametresiz
        // Parameterized Constructor -- parametreli
        // Copy Constructor -- 
        // Static Constructor -- 
        // Private Constructor --

        #region Default/Parametresiz 

        // 
        //clsEmployee employee = new clsEmployee();

        //employee.DisplayEmployee();

        //clsEmployee employee1 = new clsEmployee();
        //employee.Name = "Şeyma";
        //employee.DisplayEmployee();

        #endregion

        #region Parametreli Constructor

        //clsParametized parametized = new clsParametized(10);

        //parametized.Display();
        //clsParametized parametized1= new clsParametized(20);    

        //parametized1.Display();

        //clsParametized parametized2 = new clsParametized(30);
        
        //parametized2.Display();


        #endregion


        #region Copy Constructor

        // Aynı değerlere sahip birden fazla örnek/nesne olusturulması istendigi durumlarda kullanılmalıdır...
        // Bu durumda Copy Ctor yapıcısı aynı sınıfı üzerine parametre olarak alır..
        clsCopy clsCopy = new clsCopy(10);

        clsCopy.Display();

        clsCopy clsCopy1 = new clsCopy(clsCopy);

        clsCopy1.Display();

        #endregion




        Console.ReadKey();
    }
}