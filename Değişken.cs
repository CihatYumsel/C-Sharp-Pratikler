using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string s1 = String.Empty;
            Console.WriteLine("\nS1 = " + s1);
            string s2 = "Cihat", s3 = "Yümsel";
            string tamisim = s2 + " " + s3;
            Console.WriteLine("\nMerhaba " + tamisim);

            int i1, i2, i3;
            Console.WriteLine("\nBir sayi giriniz : ");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sayi giriniz : ");
            i2 = int.Parse(Console.ReadLine());
            i3 = i1 + i2;
            Console.WriteLine("Toplam = " + i3);

            bool b1 = 10 < 2;
            Console.WriteLine("\n" + b1);

            string toplam1, str20 = "20";
            int i20 = 20;
            toplam1 = str20 + i20.ToString();
            Console.WriteLine("\nToplam1 = " + toplam1);

            int i21;
            i21 = i20 + Convert.ToInt32(str20);
            Console.WriteLine("i21 = " + i21);

            int i22 = i20 + int.Parse(str20);
            Console.WriteLine("i22 = " + i22);

            string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("\n" + dt1);

            string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dt2);

            string saat = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(saat);
        }
    }
}
