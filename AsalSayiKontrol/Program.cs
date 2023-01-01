using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Bir Sayı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            String s = "b Sayısı Asal Sayı";
            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
            }
            for (a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }

            }
            Console.WriteLine(s);
            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
