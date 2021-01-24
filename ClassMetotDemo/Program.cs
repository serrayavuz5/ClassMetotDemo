using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Tc = 333;
            musteri1.Ad = "Serra";
            musteri1.Soyad = "Yavuz";
            musteri1.TelefonNumarasi = "0536 935 14 01";

            Musteri musteri2 = new Musteri();
            musteri2.Tc = 222;
            musteri2.Ad = "Burak";
            musteri2.Soyad = "Yavuz";
            musteri2.TelefonNumarasi = "0532 342 48 58";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("*******************");
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("*******************");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("*******************");

            musteriManager.MusteriListesi(musteri1);
            Console.WriteLine("*******************");
            musteriManager.MusteriListesi(musteri2);
            
        }
    }
}
