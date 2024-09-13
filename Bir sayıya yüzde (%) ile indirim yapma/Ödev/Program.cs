using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double urun1, urun2, toplam, yuzde, sonuc, tutar;

            Console.WriteLine("Birinci Ürünün Fiyatını Giriniz: ");
            urun1 = double.Parse(Console.ReadLine());

            Console.WriteLine("İkinci Ürünün Fiyatını Giriniz: ");
            urun2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n*********\n*********\n*********\n*********\n");

            toplam = urun1 + urun2;
            yuzde = (toplam * 0.25);
            sonuc = (yuzde % toplam);
            tutar = (toplam - sonuc);


            if (toplam < 250 || toplam == 250)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nİndirim tanımlanabilmesi için lütfen 250'nin üstünde " +
                    "bir giriş yapınız.\nGeçerli İndirim Miktarı: (%0) \n**********Ödeme Tutarı: " + toplam);
                Console.Beep();

            }
            else if (toplam > 250)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler!\nÖdediğiniz tutar 250'nin üstünde olduğu için %25\nindirim kazandınız. \n" +
                    "Geçerli indirim miktarı (%25)\nÖdeme Tutarı:" + tutar);
                Console.Beep();
                Console.Beep();
            }
                Console.ReadLine();






















        }
    }
}
