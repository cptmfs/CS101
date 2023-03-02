using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {

        // Kural : class ismiyle aynı olacak bir metotdur.
        // ctor class devreye girdiginde otomatik olarak calısan bir metotdur.
        // degisik durumlarda initial islemler yapmak için kullanılır..
        // parametreli de kullanımı olabilir.

        clsTest clsTest = new clsTest();

        Console.WriteLine($"i Değeri : {clsTest.i} \ns Değeri : {clsTest.s} \nb Değeri : {clsTest.b}");






        Console.ReadKey();
    }
}