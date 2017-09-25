using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu3tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kuis, uts, uas, total;
            double rata;
            Console.WriteLine("===Menghitung Nilai===");
            Console.Write("Masukan nilai KUIS: ");
            kuis = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai UTS: ");
            uts = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai UAS: ");
            uas = int.Parse(Console.ReadLine());

            total = kuis + uas + uts;
            rata = total / 3.0;
            Console.WriteLine("Total Nilai adalah: " + total);
            Console.WriteLine("Rata Rata Nilai adalah: " + rata);
            if (rata >= 80)
            {
                Console.WriteLine("Kamu mendapat Nilai A");
            }
            else if (rata >= 60)
            {
                Console.WriteLine("Kamu mendapat Nilai B");
            }
            else
            {
                Console.WriteLine("Kamu mendapat Nilai C");
            }
            Console.Read();
        }
    }
}
