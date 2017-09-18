using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu2_tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t;
            double luas;
            Console.WriteLine("==Menghitung luas segitiga==");
            Console.Write("Masukkan alas : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            t = int.Parse(Console.ReadLine());
            luas = a * t / 2.0;
            Console.WriteLine("Luas Segitiga yang alasnya "+ a + " dan tingginya "+ t+" adalah "+luas);
            Console.ReadLine();
        }
    }
}
