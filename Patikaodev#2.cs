using System;

namespace patikaodev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birinciSayi, ikinciSayi;

            Console.Write("birinci sayiyi giriniz:");
            birinciSayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayiyi giriniz:");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[birinciSayi];
            for (int i = 0; i < birinciSayi; i++)
            {
                Console.WriteLine((i + 1) + ".sayiyi giriniz:");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("*** Bolunebilir sayilar ***");
            for (int i = 0; i < birinciSayi; i++)
            {
                if (array[i] % ikinciSayi == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
