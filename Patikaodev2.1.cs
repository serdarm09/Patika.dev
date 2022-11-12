using System;

namespace patikaodev2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            Console.Write("sayi giriniz:");
            deger = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[deger];
            for (int i = 0; i < deger; i++)
            {
                Console.Write("Kelimeyi giriniz:");
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Tersten yazdirilmis hali:");
            for (int i = (deger - 1); i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
