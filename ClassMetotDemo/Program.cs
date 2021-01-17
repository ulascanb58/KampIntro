using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NMusteri musterim=new NMusteri();
            musterim.ad = "Hasan";
            musterim.soyad = "Çolak";
            musterim.id = 5;
            musterim.yas = 35;
            MusteriManager musteriManager = new MusteriManager();

           musteriManager.MusteriListele(musterim);

           musteriManager.MusteriSil(musterim);

           Console.ReadLine();
        }
    }
}
