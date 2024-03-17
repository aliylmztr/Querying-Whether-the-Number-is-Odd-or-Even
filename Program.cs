using System;

namespace QueryingWhetherTheNumberIsOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayilarinToplami = 0;
            int ciftSayilarinToplami = 0;

            int kullaniciDeger;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 0) + ". index değerini giriniz: ");
                kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger;
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    ciftSayilarinToplami += sayilar[j];
                }
                else
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }
            }

            if (ciftSayilarinToplami > tekSayilarinToplami)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür.");
            }

            Console.WriteLine("**********");

            Console.WriteLine("Çift sayıların toplamı: " + ciftSayilarinToplami);
            Console.WriteLine("Çift sayıların adedi: " + ciftAdetToplam);

            Console.WriteLine("**********");

            Console.WriteLine("Tek sayıların toplamı: " + tekSayilarinToplami);
            Console.WriteLine("Tek sayıların adedi: " + tekAdetToplam);

            Console.ReadLine();
        }
    }
}
