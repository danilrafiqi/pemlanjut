using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu3tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, nip, status;
            int masa, tunjangannikah = 0, gaji, tunjanganmasa = 0, gajiakhir;

            Console.WriteLine("===Menghitung Gaji===");
            Console.Write("Masukan Nama                    : ");
            nama = Console.ReadLine();
            Console.Write("Masukan Nip                     : ");
            nip = Console.ReadLine();
            Console.Write("Masukan Gaji Pokok              : ");
            gaji = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lama Masa Kerja (Tahun) : ");
            masa = int.Parse(Console.ReadLine());
            if (masa >= 5)
            {
                tunjanganmasa = 20 * gaji / 100;
            }
            Console.Write("Apakah Kamu sudah menikah (y/n) : ");
            status = Console.ReadLine();
            status.ToLower();

            if (status == "y" || status == "ya" || status == "yes")
            {
                tunjangannikah = 10 * gaji / 100;
            }

            gajiakhir = gaji + tunjanganmasa + tunjangannikah;

            Console.WriteLine("==================================");
            Console.WriteLine("Nama                 : "+nama);
            Console.WriteLine("Gaji Pokok           : " + gaji);
            Console.WriteLine("Tunjangan Nikah      : " + tunjangannikah);
            Console.WriteLine("Tunjangan Masa Kerja : " + tunjanganmasa);
            Console.WriteLine("Gaji Akhir           : " + gajiakhir);
            Console.Read();
        }
    }
}
