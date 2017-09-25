using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu3tugas4_usia
{
    class Program
    {
        static void Main(string[] args)
        {
            int usia;
            Console.WriteLine("=========================");
            Console.WriteLine("      Hitung Usia");
            Console.WriteLine("=========================");
            Console.Write("Masukan Usia : ");
            usia = int.Parse(Console.ReadLine());
            if (usia <= 21) Console.WriteLine("Kamu masih anak anak");
            else if (usia > 21 && usia <= 40) Console.WriteLine("Kamu sudah dewasa");
            else Console.WriteLine("Kamu sudah tua");
            Console.ReadLine();
        }
    }
}
