using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsTest
    {
        // 
        // Constructor otomatik çalışan bir metod , oluşturduğunuzda hangi class dan olusturduysanız onun tüm degiskenlerinin ilk degerlerini  null (string için "null" int için "0") olarak  içine alır..
        public int i; // default = 0 
        public string s; // default = ""
        public bool b;  // default = false

        public clsTest()
        {
            i = 50;
            b=true;
            s = "Ferit";
        }

    }
}
