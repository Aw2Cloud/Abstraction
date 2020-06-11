using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.BukuClass;

namespace Abstraction{
    class Program{
        static void Main(string[] args){
            Buku buku;

            Console.WriteLine("DATA BUKU");

            buku = new komik1();

            Console.Write("Judul Buku : "); buku.judul();
            Console.Write("\nPenulis : "); buku.penulis();
            Console.Write("\nPenerbit : "); buku.penerbit();

            buku = new komik2();

            Console.Write("\n\nJudul Buku : "); buku.judul();
            Console.Write("\nPenulis : "); buku.penulis();
            Console.Write("\nPenerbit : "); buku.penerbit();
            Console.ReadKey();
        }
    }
}
