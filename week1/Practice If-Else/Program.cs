using System;

namespace PracticeIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // sayının 10'dan büyük mü yoksa küçük mü oldugunu kontrol ettigimiz kısım
            if (sayi < 10)
            {
                Console.WriteLine("Girdiginiz sayi 10'dan kucuktur.");
            }
            else if (sayi == 10)
            {
                Console.WriteLine("Girdiginiz sayi 10'a esittir.");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi 10'dan buyuktur.");
            }

            // burada ise 2'e bölerek sayımızın çift mi yoksa tek mi oldugunu kontrol ediyoruz
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiginiz sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi tektir.");
            }

        }
    }
}
