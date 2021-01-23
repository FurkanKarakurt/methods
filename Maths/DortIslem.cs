using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int   sonuc=sayi1 + sayi2 ;
            Console.WriteLine("cevap = "+sonuc);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
           int sonuc = sayi1 - sayi2;
            Console.WriteLine("cevap = " + sonuc);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("cevap = " + sonuc);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("cevap = " + sonuc);
        }
    }
}
