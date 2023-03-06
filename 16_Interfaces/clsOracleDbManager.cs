using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsOracleDbManager : IDatabase
    {

        private string value; // Database'deki değer
        private string userName = "Oracle";
        private string userPass = "admin";
        public void AddValue(string value)
        {
            this.value = value;
        }

        public void Close()
        {
            Console.WriteLine("-> Oracle DB Bağlantısı başarılı şekilde sonlandırıldı..\n");
        }

        public void DeleteValue()
        {
            this.value = null;
            Console.WriteLine("-> Veritabanı üzerindeki bilgiler silindi..\n");
        }

        public void getValue()
        {
            if (value != null)
            {
                Console.WriteLine($"-> İstediğiniz doğrultuda [{value}] verisi başarılı bir şekilde getirildi..\n");
            }
            else
            {
                Console.WriteLine($"-> Veritabanı içinde herhangi bir değer bulunamadı..\n");
            }
        }

        public int Login(string username, string password)
        {
            if (username == this.userName && password == this.userPass)
            {
                return 1;
                //Console.WriteLine($"->{userName} isimli kullanıcı veritabanına {DateTime.Now} tarihinde başarıyla giriş yapmıştır..");

            }
            else
            {
                return 0;
            }
        }

        public void UpdateValue(string value)
        {
            this.value = value;
            Console.WriteLine("-> Veritabanı üzerindeki bilgiler güncellendi..\n");
        }
    }
}
