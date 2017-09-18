using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu2_tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, npm, ps, alamat, hp;
            Console.WriteLine("DATA DIRI");
            Console.WriteLine("Isilah Data dibawah ini :");
            Console.Write("Nama          : ");
            nama = Console.ReadLine();
            Console.Write("NPM           : ");
            npm = Console.ReadLine();
            Console.Write("Program Studi : ");
            ps = Console.ReadLine();
            Console.Write("Alamat        : ");
            alamat = Console.ReadLine();
            Console.Write("No HP         : ");
            hp = Console.ReadLine();
            Console.WriteLine("Halo "+nama+" NPM kamu "+npm+" Program Studi kamu "+ps+", Alamat kamu "+alamat+" No telepon kamu "+hp);
            Console.ReadLine();

        }
    }
}
