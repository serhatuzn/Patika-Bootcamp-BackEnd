using System;

namespace PracticeIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

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