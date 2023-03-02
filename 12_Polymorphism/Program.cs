using _12_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        
        clsTutorials clsTutorials = new clsTutorials();

        clsTutorials.setTutorial(1,"C # Eğitimi"); // 1.formunu kullanıyorum..
        Console.WriteLine(clsTutorials.getTutorialName());

        clsTutorials.setTutorial("SQL Server Eğitimi");
        Console.WriteLine(clsTutorials.getTutorialName());

        clsTutorials.setTutorial(1111111111, "Kurumsal Kaynak Planlama ve Veri Analizi", "Ümit Karaçivi");
        Console.WriteLine(clsTutorials.getTutorialName());
        
        


        Console.ReadKey();
    }
}