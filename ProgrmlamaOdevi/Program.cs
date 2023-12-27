using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrmlamaOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, toplam, fark, bolum, carpim;

            Console.Write("1.Sayıyı Giriniz: ");
            s1=Convert.ToDouble(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            s2=Convert.ToDouble(Console.ReadLine());

            toplam = s1 + s2;
            fark = s1 - s2;
            bolum = s1 / s2;
            carpim = s1 * s2;

            Console.WriteLine("Toplamı: " + toplam.ToString());
            Console.WriteLine("Farkı: " + fark.ToString());
            Console.WriteLine("Bölümü: " + bolum.ToString());
            Console.WriteLine("Çarpımı: " + carpim.ToString());

            Console.ReadKey();
        }
    }
}
