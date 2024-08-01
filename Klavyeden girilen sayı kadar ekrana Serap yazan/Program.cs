using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_sayı_kadar_ekrana_Serap_yazan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin");
            int sayi = Int32.Parse(Console.ReadLine());

            for (int i= 0;i<sayi;i++)
            {
                Console.WriteLine("Serap");

            }
            Console.ReadLine();

        }
    }
}
