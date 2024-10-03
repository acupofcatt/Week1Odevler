using System;
using System.IO;

namespace Variables
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            Console.WriteLine("TC Kimlik Numarası: ");
            string TC = Console.ReadLine();

            Console.WriteLine("Adı: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadı: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Telefon Numarası: ");
            string telno = Console.ReadLine();  //farklı formatlarda girilebilecek telefon numaralarını tutabilmek için string kullanmayı tercih ettim

            Console.WriteLine("Yaş: ");
            int.TryParse(Console.ReadLine(), out int yas);

            Console.WriteLine("İlk Aldığı Ürünün Fiyatı: ");
            double fPrice = double.Parse(Console.ReadLine());   //işlem yaptırabilmek için double değer istedim

            Console.WriteLine("Son Aldığı Ürünün Fiyatı: ");
            double lPrice = double.Parse(Console.ReadLine());   //işlem yaptırabilmek için double değer istedim

            double toplam = fPrice + lPrice;
            double puan = toplam / 10;

            Console.WriteLine();
            Console.WriteLine($"\n{TC} TC Kimlik Numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur.\n {telno}telefon numarasına bildirim mesajı gönderilmiştir.\n{toplam} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {puan} TL'dir.");



        }
    }

}