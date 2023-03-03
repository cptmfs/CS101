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

        clsParametized parametized = new clsParametized(10);

        


        #endregion




        Console.ReadKey();
    }
}