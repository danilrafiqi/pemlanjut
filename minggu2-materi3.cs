using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu2_materi3
{
    class Contoh3 {
        static void Main () {
            char c; string s;
        Console.Write ("Masukkan karakter ");
        s = Console.ReadLine();
        if ( char. TryParse ( s, out  c ) )  {	
            Console.WriteLine ("karakter yang dimasukkan adalah  " + c   );
        } 
        else { 
            Console.WriteLine (" Data yang anda masukkan " +  " tidak dapat dikonversi " + " ke tipe karakter " );
        }
        Console.ReadLine();
        }
    }

}
