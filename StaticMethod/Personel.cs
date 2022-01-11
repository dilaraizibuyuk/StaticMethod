using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Personel  //static olmama durumu
    {
        //public void AdSoyadYazdir()
        //{
        //    Console.WriteLine("Stephen Hawking");
        //}


        //static olma durumu

        //public static void AdSoyadYazdir()
        //{
        //    Console.WriteLine("Stephen Hawking");
        //}

        public static void numbersAddup(int number1,int number2)
        {
            Console.WriteLine("İki sayının toplamı:"+(number1+number2));
        }
    }
}
