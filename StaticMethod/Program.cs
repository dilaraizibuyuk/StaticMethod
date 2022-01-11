using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personel p1 = new Personel();
            //p1.AdSoyadYazdir();


            //static durum
            //Personel.AdSoyadYazdir();


            Personel.numbersAddup(58,8);
            Console.ReadKey();
        }
    }
}
