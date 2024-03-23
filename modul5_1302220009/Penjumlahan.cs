using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220009
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T x, T y, T z)
        {
            dynamic a, b, c;
            a = x; b = y; c = z;
            Console.WriteLine(a + b + c);
        }
    }
}