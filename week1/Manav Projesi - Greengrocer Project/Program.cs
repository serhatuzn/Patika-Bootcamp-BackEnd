using System;
using System.Data;
using System.Net.WebSockets;

namespace sss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz!"); // Manava Hoşgeldiniz yazısı

            //Burada meyvelerin fiyatlarını belirledik 

            int elma = 2;
            int armut = 3;
            int çilek = 2;
            int muz = 3;
            int dıgerurn = 4;
            
            //Burada meyvelerin fiyatlarını yazdırdık

            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");

            // Kullanıcıdan meyve seçmesini istedik

            Console.Write("\nhangi meyveyi saatın almak istersiniz? (elma/armut/çilek/muz/diğer): ");

            // Kullanıcının girdiği meyveyi küçük harfe çevirdik CİLEK yazsa bile çilek olarak algılasın diye

            string meyve = Console.ReadLine().ToLower();

            // fiyat değişkenini tanımladık ve switch case yapısını kullandık
            int fiyat = 0;

            // switch case yapısını kullanmaya başladığımız yer
            switch (meyve)
            {
                case "elma":
                    fiyat = elma;
                    break;
                case "armut":
                    fiyat = armut;
                    break;
                case "çilek":
                    fiyat = çilek;
                    break;
                case "cilek":
                    fiyat = çilek;
                    break;
                case "muz":
                    fiyat = muz;
                    break;
                default:
                    fiyat = dıgerurn;
                    break;

            }
            // Kullanıcının seçtiği meyvenin fiyatını yazdırdık
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");
        }
    }
}

