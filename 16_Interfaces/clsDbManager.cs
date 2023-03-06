using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    //Databaselerimi yönetecek class ..
    internal class clsDbManager
    {
        private IDatabase database; // Interfaceden bir değişken tanımlıyoruz..

        public clsDbManager() // Default Constructor
        {

        }
        public clsDbManager(IDatabase database) // Parametrik Constructor , buraya o anki db class'ının kendisini göndereceğiz..
        {
            this.database = database;  // o anki gelen db parametresine göre içsel değeri değiştiriyoruz..
        }

        public void loginDb() // Sistem Giriş..
        {
            string userName, userPass;

            Console.WriteLine("< Veritabanı Bağlantısı Başlatıldı >\n\n--> Kullanıcı adı :");
            userName= Console.ReadLine();
            Console.WriteLine("--> Şifre :");
            userPass= Console.ReadLine();
            if (database.Login(userName,userPass)==1)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Bağlantı bilgilerinde bir terslik var.. Kontrol Ediniz...\n");
            }
        }
        public void closeDb()
        {
            database.Close();
        }
        private void AddValue(string value)
        {
            database.AddValue(value);
        }
        private void DeleteValue()
        {
            database.DeleteValue();
        }
        private void UpdateValue(string value)
        {
            database.UpdateValue(value);
        }
        private void GetValue()
        {
            database.getValue();
        }

        public void Menu()
        {
            string value;
            int v;
            Console.WriteLine("< Veri Tabanı İşlemleri >\n");
            Console.WriteLine("[1] - Veri Ekle\n[2} - Veri Sil\n[3] - Veri Getir\n[4] - Bağlantıyı Kes\n");

            Console.WriteLine("-> Yapmak istediğiniz işlem : ");
            v = Convert.ToInt32(Console.ReadLine());

            switch (v)
            {
                case 1:
                    Console.WriteLine("{0}\n-> Eklemek istediğiniz veri :");
                    value = Console.ReadLine();

                    AddValue(value);
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    DeleteValue();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    GetValue();
                    Menu();
                    break;
                    case 4:
                    closeDb();
                    break;
            }
        }
        



    }
}
