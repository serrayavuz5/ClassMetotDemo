using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi. ");
            Console.WriteLine("Müşteri Tc : " + musteri.Tc);
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Telefon Numarası : " + musteri.TelefonNumarasi);
            
        }
        
        public  void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemi başarıyla gerçekleşti. "+ musteri.Tc);
            
        }

        public  void MusteriListesi(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi ");
            Console.WriteLine("Müşteri Tc : " + musteri.Tc);
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Telefon Numarası : " + musteri.TelefonNumarasi);
        }
    }
}
