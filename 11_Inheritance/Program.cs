using _11_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        clsSubTutorials clsSubTutorials = new clsSubTutorials();

        clsSubTutorials.renameTutorial(".Net tutorials from LinkedIn"); // çağrılan bu metod alt sınıfta
        Console.WriteLine(clsSubTutorials.getTutorialName()); // Ekrana yazdırmak için getTutorialName metodunu



        Console.ReadKey();
    }
}


