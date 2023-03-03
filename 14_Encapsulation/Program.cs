using _14_Encapsulation;

internal class Program 
{
    private static void Main(string[] args)
    {
        #region Normal Durum

        clsBank clsBank = new clsBank();

        clsBank.accountNumber = 1234567890;
        clsBank.accountName = "Satoshi Bank";
        clsBank.balance = 3500000;

        clsBank.GetBalance();
        clsBank.WithdrawAccount();
        clsBank.Deposit();

        #endregion
        Console.WriteLine("\n-------------------------------------------\n");
        #region Getter / Setter


        clsBank.SetBalanceCaps(1500);
        Console.WriteLine($"Balance size : {clsBank.GetBalanceCaps()}");

        #endregion


        Console.ReadKey();
    }
}