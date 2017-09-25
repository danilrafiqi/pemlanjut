using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu3tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int lama, menu, harga=0, jenis=0, diskon=0, totalbayar;
            Console.WriteLine("===================================");
            Console.WriteLine("             Hotel ABC");
            Console.WriteLine("===================================");
            Console.WriteLine();
            try
            {
                Console.Write("Masukkan Nama      : ");
                nama = Console.ReadLine();
                Console.WriteLine("Jenis Kamar");
                Console.WriteLine(" 1. VIP : 500000/malam");
                Console.WriteLine(" 2. I   : 300000/malam");
                Console.WriteLine(" 3. II  : 200000/malam");
                isiulang:
                Console.Write("Jenis Kamar(1/2/3) : ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        jenis = 500000;
                        break;
                    case 2:
                        jenis = 300000;
                        break;

                    case 3:
                        jenis = 200000;
                        break;

                    default:
                        Console.WriteLine("Inputan Anda Salah, masukkan angka 1-3");
                        Console.ReadKey();
                        goto isiulang;
                        
                }

                Console.Write("Lama menginap(hari): ");
                lama = int.Parse(Console.ReadLine());
                harga = lama * jenis;
                if (lama >= 3)
                {
                    diskon = harga * 10 / 100;
                }

                totalbayar = harga - diskon;
                Console.WriteLine();
                Console.WriteLine("===============================");
                Console.WriteLine("       Struk Pembayaran");
                Console.WriteLine("===============================");
                Console.WriteLine("Nama Pelanggan \t\t: " + nama);
                Console.WriteLine("Lama Inap \t\t: " + lama);
                Console.WriteLine("Harga Sebelum Diskon \t: " + harga);
                Console.WriteLine("Diskon \t\t\t: " + diskon);
                Console.WriteLine("Total Bayar \t\t: " + totalbayar);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Salah " + e.Message);
                Console.ReadKey();
            }
 
        }
    }

}