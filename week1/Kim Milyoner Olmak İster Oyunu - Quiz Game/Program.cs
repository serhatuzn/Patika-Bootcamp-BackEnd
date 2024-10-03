using System;
using System.Data;
using System.Security.Claims;

namespace sss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster Yarısmasına Hoşgeldiniz!");
            Console.WriteLine("\n3 sorudan 2'sini dogru bilirisneniz büyük ödül kazanacaksınız! Başarılar!");

            // Doğru ve yanlış cevapları tutacak değişkenler çünkü 2 doğru bilirse büyük ödül kazanacak yada 2 yanlış bilirse kaybedecek
            int dogrucevap = 0;
            int yanliscevap = 0;

            Console.WriteLine("\nSoru 1: Türkiye'nin başkenti neresidir?");
            Console.WriteLine("A) Ankara");
            Console.WriteLine("B) İstanbul");
            Console.WriteLine("C) İzmir");

            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "A")
            {
                Console.WriteLine("TEBRİKLER Doğru Cevap!");
                dogrucevap++;
            }
            else if (cevap == "B" || cevap == "C")
            {
                Console.WriteLine("Yanlış Cevap!");
                Console.WriteLine("Dogru Cevap: A) Ankara");
                yanliscevap++;
            }
            else
            {
                Console.WriteLine("Geçersiz Bir şık girdiniz!");
            }

            // 1. soruyu dogru ve yanlış cevapladıktan sonra 2. soruyu sor
            Console.WriteLine("\nSoru 2: 12'nin yarısı kaçtır?");
            Console.WriteLine("A) 5");
            Console.WriteLine("B) 2");
            Console.WriteLine("C) 6");

            string cevap2 = Console.ReadLine().ToUpper();
            
            if (cevap2 == "C")
            {
                Console.WriteLine("TEBRİKLER Doğru Cevap!");
                dogrucevap++;
            }
            else if (cevap2 == "A" || cevap2 == "B")
            {
                Console.WriteLine("Yanlış Cevap!");
                Console.WriteLine("Dogru Cevap: C) 6");
                yanliscevap++;
            }
            else
            {
                Console.WriteLine("Geçersiz Bir şık girdiniz!");
            }

            // 2 soruyu da yanlış bildiyse direkt programı sonlandır
            if (yanliscevap == 2)
            {
                Console.WriteLine("\nÜzgünüm! 2 soruyu da yanlış bildiniz ve büyük ödülü kazanamadınız!");
                return;
            }

            else if(dogrucevap == 2)
            {
                Console.WriteLine("\nTebrikler! 2 soruyu da doğru bildiniz ve büyük ödülü kazandınız!");
                return;
            }

            // burada 1 doğru 1 yanlış varsa 3. soruyu sor
            Console.WriteLine("\nSoru 3: Hasbihal kelimesinin anlamı nedir?");
            Console.WriteLine("A) Sohbet");
            Console.WriteLine("B) Yemek");
            Console.WriteLine("C) Uyku");

            string cevap3 = Console.ReadLine().ToUpper();

            if (cevap3 == "A")
            {
                Console.WriteLine("TEBRİKLER Doğru Cevap!");
                dogrucevap++;
            }
            else if (cevap3 == "B" || cevap3 == "C")
            {
                Console.WriteLine("Yanlış Cevap!");
                Console.WriteLine("Dogru Cevap: A) Sohbet");
                yanliscevap++;
            }
            else
            {
                Console.WriteLine("Geçersiz Bir şık girdiniz!");
            }

            // Eğer 2 Doğrusu olmuş olursa buraya girer ve büyük ödülü kazanır yoksa else bloğuna girer ve büyük ödülü kazanamaz
            if (dogrucevap == 2)
            {
                Console.WriteLine("\nTebrikler! 2 soruyu da doğru bildiniz ve büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine("\nÜzgünüm! 2 soruyu da doğru bilemediniz ve büyük ödülü kazanamadınız!");
            }
        }
    }
}