using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba...");

            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.Ad = "Hazal";
            musteri1.Soyad = "Bingül";
            musteri1.Email = "hazal@gmail.com";


            Musteri musteri2 = new Musteri();
            musteri2.id = 1;
            musteri2.Ad = "Sevgi";
            musteri2.Soyad = "Yilmaz";
            musteri2.Email = "sevgi@gmail.com";


            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Ad +" "+ musteri.Soyad);
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
        }

       

    }
}
