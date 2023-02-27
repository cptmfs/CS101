internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Vize notunu girin: ");
            double vizeNotu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final notunu girin: ");
            double finalNotu = Convert.ToDouble(Console.ReadLine());

            double ortalamaNot = (vizeNotu * 0.3) + (finalNotu * 0.7);

            if (ortalamaNot >= 50)
            {
                Console.WriteLine("Geçtiniz. Ortalama notunuz: " + ortalamaNot);
            }
            else
            {
                Console.WriteLine("Kaldınız. Ortalama notunuz: " + ortalamaNot);
            }
        
    }

}
