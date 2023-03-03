using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    internal class clsBank
    {

        #region Normal Durum

        public long accountNumber; // Hesap No..
        public string accountName; // Hesap Adı..
        public int balance; // Hesaptaki Miktar..

        public void GetBalance()
        {
            Console.WriteLine($"Hesap Numarası : {accountNumber}\tHesap Adı : {accountName}\tHesap Bakiyesi : {balance}");
        }

        public void WithdrawAccount()
        {
            int withdraw = balance - 50000;

            Console.WriteLine($"Hesapdan para çekme işlemi gerçekleştirildi\nYeni Hesap Bakiyesi : {withdraw}");
        }

        public void Deposit()
        {
            int deposit = balance + 100000000;
            Console.WriteLine($"Hesaba para yatırma işlemi gerçekleştirildi\nYeni Hesap Bakiyesi : {deposit}");

        }


        #endregion


        #region Getter / Setter

        private double balance2; // uani burada dışarıya kapalı bir degisken tanımı var 

        //set / get metotlarının tanımlanması...

        // Public getter metot -> Bu metot balance2 değişkenimizde tutulan  değeri almak için 

        public double GetBalanceCaps() // private olan değişkeni public bir metotda yer verdiğimiz zaman onu sanki public bir değişkenmiş                                    gibi kullanabiliriz... 
        {
            //Burada farklı işlemler var.. balance2 = balance2 * 1.15 ; gibi 

            return balance2;
        }

        // Public setter metot -> Bu metot balance2 değişkenimizde tutulan  değeri değiştirmek/güncellemek için kullanılır..

        public void SetBalanceCaps(double balance2)
        {
            // Burada yine farklı işlemler olabilir.. balance2 = balance2 * 1.15 ; gibi 

            this.balance2 = balance2;  // " this " Benim yukarda tanımladığım değişkenimi güncelleyeceksin demek..
        }

        #endregion

        #region Eğer sınıfı tasarlarken Kapsülleme(encapsülation) prensibine uymazsak ne olur?

        //Daha sonra , gelecekte müşteri uygulamanın negatif bir değere izin vermemesini istiyor.
        //Ardından miktar değişkeninde saklamadan önce kullanıcı tarafından verilen değerleri doğrulamalıyız.. 
        //Bu nedenle kapsülleme ilksesini aşağıdaki gibi izleyerek uygulamayı geliştirmemiz gerekir..
        

        public int amount;

        public int GetAmount()
        {
            return amount;
        }

        public void SetAmount(int amount)
        {
            if (amount>0)
            {
                this.amount = amount;
            }
            else
            {
                throw new Exception("Negatif bir Değer Girdiniz ...!!");
            }
        }

        #endregion

        #region Properties / Değişkenlere de uygulanabilir..

        private int _Amount1;
        
        public int _Amount2 { get; set; } // Sadece alır ve yazar koşulsuz bir şekilde..


        // Şu şekildede kullanılır..

        public int Amount1 // koşul atamak istediğimizde kullanılır..
        {
            get
            {
                return _Amount1;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Lütfen Pozitif bir değer giriniz");
                }
                else
                {
                    _Amount1 = value;
                }
            }
        }

        #endregion
    }
}
