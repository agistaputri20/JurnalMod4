using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302201140
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 20));

        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic jumlah1 = a;
            dynamic jumlah2 = b;
            dynamic jumlah3 = c;

            return jumlah1 + jumlah2 + jumlah3;

        }
    }

}