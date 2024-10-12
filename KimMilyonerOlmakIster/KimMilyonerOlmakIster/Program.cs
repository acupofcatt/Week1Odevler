using System;
using System.Reflection.Metadata;

namespace Milyoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int trueCount = 0;
            bool q1Result = Question1();
            if (q1Result == true)
            {
                trueCount += 1;
                Console.WriteLine("Doğru Cevap Sayısı " + trueCount);
            }
            
            bool q2Result = Question2();
            if (q2Result == true)
            {
                trueCount += 1;
                Console.WriteLine("Doğru Cevap Sayısı " + trueCount);
            }
          
            if (trueCount == 2)
            {  
                Console.WriteLine("Doğru Cevap. Tebrikler Milyoner Oldunuz!");
            }
            else if (trueCount == 0)
            {
                Console.WriteLine("Kaybettiniz!");
            }
            else
            {
                bool q3Result = Question3();
                if (q3Result == true)
                {
                    trueCount += 1; //sonucu değiştirmiyor ama pratikte kullanılabilmesi adına devam ettirdim
                    Console.WriteLine("Doğru Cevap. Tebrikler Milyoner Oldunuz!");
                }
                else
                {
                    Console.WriteLine("Kaybettiniz!");
                }
            }
            
        }

        private static bool Question1()
        {
            Console.Write("Soru 1: Karesi -1 olan sayı hangisidir?\nA)i B)j\nLütfen cevabınızı giriniz: ");
            string? answer1 = Console.ReadLine();

            if (string.IsNullOrEmpty(answer1)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
            {
                Console.Write("Lütfen A veya B şıkkını seçiniz.");
                answer1 = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(answer1)) //kullanıcının tekrar tekrar null girmesini engellemek için ikinci tekrarda yanlış cevap kabul ettim
            {
                
                return false;
            }

            answer1 = answer1.ToUpper(); //cevabı ne girerse girsin büyük harfle değerlendirdim

            if (answer1 == "A")
            {
                Console.WriteLine("Cevabınız Doğru.");
                return true;
            }

            else
            {
                Console.WriteLine("Cevabınız Yanlış");
                return false;
            }
        }

        private static bool Question2()
        {
            Console.Write(
                "\nSoru 2: Eğer şimşeğin sesini 5 saniye sonra duyuyorsak kaç metre ileride çakmıştır? \nA)2305 B)1715\nLütfen cevabınızı giriniz: ");
            string? answer2 = Console.ReadLine();

            if (string.IsNullOrEmpty(answer2)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
            {
                Console.WriteLine("Lütfen A veya B şıkkını seçiniz.");
                answer2 = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(answer2)) //kullanıcının tekrar tekrar null girmesini engellemek için ikinci tekrarda yanlış cevap kabul ettim
            {
                return false;
            }

            answer2 = answer2.ToUpper(); //cevabı ne girerse girsin büyük harfle değerlendirdim

            if (answer2 == "B")
            {
                Console.WriteLine("Cevabınız Doğru.");
                return true;
            }

            else
            {
                Console.WriteLine("Cevabınız Yanlış");
                return false;
            }
        }

        private static bool Question3()
        {
            Console.Write(
                "\nSoru 3: Hangisi bir elementtir? \nA)Helyum B)Tuz\nLütfen cevabınızı giriniz: ");
            string? answer3 = Console.ReadLine();

            if (string.IsNullOrEmpty(answer3)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
            {
                Console.WriteLine("Lütfen A veya B şıkkını seçiniz.");
                answer3 = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(answer3)) //kullanıcının tekrar tekrar null girmesini engellemek için ikinci tekrarda yanlış cevap kabul ettim
            {
                return false;
            }

            answer3 = answer3.ToUpper(); //cevabı ne girerse girsin büyük harfle değerlendirdim

            if (answer3 == "A")
            {
                Console.WriteLine("Cevabınız Doğru.");
                return true;
            }

            else
            {
                Console.WriteLine("Cevabınız Yanlış");
                return false;
            }
        }
    }
}