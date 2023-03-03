using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsEmployee
    {
        public int Id,Age;
        public string Address,Name;
        public bool isActive;


        public clsEmployee() // User-defined Constructor -- Kullanıcı Tanımlı Constructor
        {
            Id = 100;
            Age = 29;
            Address = "Istanbul";
            Name = "Ferit";
            isActive = true;
        }


        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee Id : {Id}\nEmployee Age : {Age}\nEmployee Name : {Name}\nEmployee Adress : {Address}\nEmployee Status : {isActive}");
        }

    }
}
