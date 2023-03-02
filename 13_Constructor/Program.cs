using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {

        // 

        clsTest clsTest = new clsTest();

        Console.WriteLine($"i Değeri : {(clsTest.i)+5} \ns Değeri : {clsTest.s} \nb Değeri : {clsTest.b}");






        Console.ReadKey();
    }
}