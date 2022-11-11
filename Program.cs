using System;

namespace Patikaodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z;
            uint a;
            byte b;
            ushort c;
            short d;
            decimal e;
            ulong f;    
            long l;


            char ch = 's';
            string s = "serdar";
            
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 12;
            object o2 = "serdar";
            object o3 = 1.2;
            object o4 = "naber";

            
            string str1=string.Empty;
            str1 = "merhaba githup";
            string ad = "serdar";
            string cinsiyet = "Serdarm09";
            string tam = ad +" "+cinsiyet;

            int id1 = 5;
            int id2 = 6;
            int idtoplam = id1 + id2;

            bool booli = 10 > 2;

            int id11 = 22;
            string str11 = "20";

            string toplamyil = str11 + id11.ToString();

            Console.WriteLine(toplamyil);
            

        }
    }
}
