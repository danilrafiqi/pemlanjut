using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minggu2_materi2
{
    class Contoh2 {
        static void Main () {
        string input; int i; double d;
        Console.Write ("Masukkan bilangan bulat ");
        input = Console.ReadLine();
        if (int. TryParse (input, out  i) )  {	
            Console.WriteLine ("Anda memasukkan bilangan " + i  );
        } 
        else { 
            Console.WriteLine ("Salah " +  "konversi ke integer gagal"  );
        }
        Console.Write ("\n Masukkan bilangan bulat "  );
        input = Console.ReadLine();
        if ( double. TryParse (input, out d ) )  {	 
            Console.WriteLine("Anda memasukkan bilangan " +  d   );
        } 
        else { 
            Console.WriteLine ("Salah " +  "konversi ke double gagal"  );
        }
        Console.ReadLine();
        }
    }
}
