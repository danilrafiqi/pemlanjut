using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu3tugas5_nilai
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai;
            Console.WriteLine("=========================");
            Console.WriteLine("           Nilai");
            Console.WriteLine("=========================");
            Console.Write("Masukan Nilai : ");
            nilai = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (nilai > 80) Console.WriteLine("Nilai Kamu "+nilai+" Selamat Kamu Mendapat Nilai A");
            else if (nilai > 60) Console.WriteLine("Nilai Kamu " + nilai + " Kamu Mendapat Niali B");
            else Console.WriteLine("Nilai Kamu " + nilai + " Kamu Mendapat Nilai C");
            Console.ReadLine();
        }
    }
}
