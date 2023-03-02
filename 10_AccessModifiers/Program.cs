using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiers
{
    internal class Program : clsMovies // Kalıtım(Inheritance)  clsMovies içindeki tüm metod değişkenleri (private dışındaki) getiriyor ve onları Program                                            class'ında kulllanabiliyoruz..
    {                           
        static void Main(string[] args)
        {
            #region  Public ****   Heryerden erişilebilir..    ****

            clsTutorials tutorials = new clsTutorials(); // Class dan örnekleme yaptık. Yani nesneyi oluşturduk. 

            tutorials.setTutorial(1, "CSharp Egitimi..");

            Console.WriteLine($"Egitim Adı : {tutorials.getTutorialName()}");

            #endregion


            #region Private  ****   Tanımlandığı class içerisinde erişilebilir..    ****


            clsStudent student = new clsStudent();

            student.getName();

            #endregion

            #region Protected **** Kendisinden kalıtım alan yerlerde erişilebilir..      ****

            Program program = new Program(); // clsMovies movies = new clsMovies(); yerine Program'ı zaten clsMoviesden kalıtım aldırdıgımız                                   için , programı tekrar burda tanımladık. ve aşağıda program.movieName yazdık... 


            Console.WriteLine($"Filim adı :  {program.movieName}");
            #endregion

            Console.ReadKey();
        }
    }

    }
