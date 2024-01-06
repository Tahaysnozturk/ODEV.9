using System;

namespace or094
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string s = "b Sayısı Asal Sayı";

            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
                goto bitir;
            }

            for (int a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }

            Console.WriteLine(s);

        bitir:
            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
