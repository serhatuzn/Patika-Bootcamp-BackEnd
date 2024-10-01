using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YENI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen asagidaki bilgileri giriniz:");

            Console.Write("T.C. Kimlik Numarasi: ");
            string TC = Console.ReadLine();

            Console.Write("Adi: ");
            string name = Console.ReadLine();

            Console.Write("Soyadi: ");
            string surname = Console.ReadLine();

            Console.Write("Telefon Numarasi:");
            string number = Console.ReadLine(); // string bir veri tipi kullandım. gireceğim telefon numarası bir stringdir.

            Console.Write("Yas: ");
            string age = Console.ReadLine();

            //son aldıgım ürünleri int veri tipini kullandım cünkü benden ilk aldıgım ve son aldıgım urunlerin toplamını ve kazandıgım puanı istediği için bunları bir string ifade olarak yazamıcagım icin int olarak yazdım.

            Console.Write("Ilk aldigi Ürünün Fiyati: ");
            int buy1 = int.Parse(Console.ReadLine()); // Kullanıcının girdiği değeri okur ve int'e dönüştürerek buy1 değişkenine atar

            Console.Write("Ikinci Aldigi Ürünün Fiyati: ");
            int buy2 = int.Parse(Console.ReadLine()); // Burada da kullanıcının girdiği değeri okuyor ve int'e dönüştürerek buy2 değişkenine atıyor

            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine($"{TC} Tc numarali {name} {surname} isimli kisi icin kayit olusturulmustur.");

            Console.WriteLine($"{number} telefon numarasina bildirim mesaji gonderilmistir");

            int toplam = buy1 + buy2;

            double puan = toplam * 0.10;

            Console.WriteLine($"{toplam} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {puan} TL'dir.");

        }
    }
}