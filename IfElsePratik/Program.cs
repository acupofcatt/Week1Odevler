using System;
using System.IO;

namespace Variables
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");

            int.TryParse(Console.ReadLine(), out int sayi);     //kullanıcıdan sayı alınıyor

            if (sayi == 10)     //sayının 10a göre değerlendirmesi yapılıyor
            {
                Console.WriteLine("Girilen sayı 10'a eşittir.");
            }
            else if (sayi < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");
            }


            if (sayi % 2 == 0)      //sayının teklik çiftlik kontrolü yapılıyor
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }
            



        }
    }
}

