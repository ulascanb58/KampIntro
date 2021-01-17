using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(NMusteri musteri)
        {
            Console.WriteLine("id : " + musteri.id);
            Console.WriteLine("Ad : " + musteri.ad);
            Console.WriteLine("Yaş : " + musteri.yas);
            Console.WriteLine("Soyad : " + musteri.soyad);
        }

        public void MusteriSil(NMusteri musteri)
        {

            Console.WriteLine(musteri.id + "ıd Li kayıt silinmiştir");
        }


    }
}
