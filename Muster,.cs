using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad +" "+ "Sisteme eklendi." );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri + "Müşteri kaydı silindi.");
        }

        public void list()
        {

        }

        
    }
}
