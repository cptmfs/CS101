using _11_Inheritance;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        clsSubTutorials clsSubTutorials = new clsSubTutorials();

        clsSubTutorials.renameTutorial(".Net tutorials from LinkedIn"); // çağrılan bu metod alt sınıfta
        Console.WriteLine(clsSubTutorials.getTutorialName()); // Ekrana yazdırmak için getTutorialName metodunu kullanıyoruz. clSubTutorials sınıfını getTutorialName metodunu içeren clsTutorials metodundan kalıtım aldırdığımız için yapabiliyoruz bu işlemi..


        Console.ReadKey();
    }
}


