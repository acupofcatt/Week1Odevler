using System;
using System.Threading.Channels;

namespace Manav
{
    class Program
    {
        static void Main(string[] args)
        {
             WriteLineByIf();
             WriteLineBySwitch();
        }

        private static void WriteLineByIf() //if kullanarak yazdığım kodu ayrı bir fonksiyon olarak tanımlıyorum
        {
            Console.WriteLine(
                "Rüya Manavına Hoş Geldiniz!\n\nElma = 2 TL\n\nArmut = 3 TL\n\nÇilek = 2 TL\n\nMuz = 3 TL\n\nDiğer bütün meyveler = 4 TL");
            Console.WriteLine("Hangi meyveyi satın almak istersiniz?");

            string?
                degisken = Console
                    .ReadLine(); //değer verilmeden çalıştırılmaması için string? işaretiyle nullable yaptım

            if (degisken == null) //null ise uyarı veriyor
            {
                Console.WriteLine("Lüften bir meyve adı girin.");
                return;
            }

            string meyve = char.ToUpper(degisken[0]) +
                           degisken.Substring(1)
                               .ToLower(); //girilen meyvenin ilk harfini büyük diğer harflerini küçük yapıyor


            if ((meyve == "Elma") || (meyve == "Çilek"))
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }

            else if ((meyve == "Armut") || (meyve == "Muz"))
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }

            else
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
            }
        }

        private static void WriteLineBySwitch() //switch kullanarak yazdığım kodu ayrı bir fonksiyon olarak tanımlıyorum
        {
            Console.WriteLine(
                "Rüya Manavına Hoş Geldiniz!\n\nElma = 2 TL\n\nArmut = 3 TL\n\nÇilek = 2 TL\n\nMuz = 3 TL\n\nDiğer bütün meyveler = 4 TL");
            Console.WriteLine("Hangi meyveyi satın almak istersiniz?");

            string?
                degisken = Console
                    .ReadLine(); //değer verilmeden çalıştırılmaması için string? işaretiyle nullable yaptım

            if (degisken == null) //null ise uyarı veriyor
            {
                Console.WriteLine("Lüften bir meyve adı girin.");
                return;
            }

            string meyve = char.ToUpper(degisken[0]) + degisken.Substring(1).ToLower();


            switch (meyve)
            {
                case "Elma":
                case "Çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;

                case "Armut":
                case "Muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;

                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                    break;
            }
        }
    }
}

