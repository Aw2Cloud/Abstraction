using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.BukuClass{
    public class komik1 : Buku{
        public override void judul()
        {
            Console.Write("Sword Art Online");
        }
        public override void penulis()
        {
            Console.Write("Reki Kawahara");
        }
        public override void penerbit()
        {
            Console.Write("Little Brown");
        }
    }
}
