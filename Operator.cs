using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tAtama Operatörleri");// =, +=, -=, *=, /=, %=
            int x = 3, y = 3;
            y += 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("\n\tMantıksal Operatörler");// &&, ||, !
            bool b1 = true, b2 = false;
            if (b1 && b2)
            {
                Console.WriteLine("Perfect!");
            }

            if (b1 || b2)
            {
                Console.WriteLine("Great!");
            }

            if (b1 && !b2)
            {
                Console.WriteLine("Fine!");
            }

            Console.WriteLine("\n\tİlişkisel Operatörler");// >, >=, <, <=, ==, !=
            int a = 3, b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("\n\tAritmetik Operatörler");// +, -, *, /
            int sayi1 = 10, sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine("Sonuç = " + sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine("Sonuç = " + sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine("Sonuç = " + sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine("Sonuç = " + sonuc1);
            sonuc1 = ++sayi1;
            Console.WriteLine("Sonuç = " + sonuc1);

            //% --> mod alır
            sonuc1 = sayi1 % 3;
            Console.WriteLine("Sonuç = " + sonuc1);
        }
    }
}
