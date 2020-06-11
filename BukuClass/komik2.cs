using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.BukuClass
{
    class komik2 : Buku
    {
        public override void judul()
        {
            Console.Write("Naruto");
        }
        public override void penulis()
        {
            Console.Write("Masashi Kishimoto");
        }
        public override void penerbit()
        {
            Console.Write("Elex Media Komputindo");
        }
    }
}
