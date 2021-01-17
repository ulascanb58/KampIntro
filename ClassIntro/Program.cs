using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();

            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Hasan";
            kurs2.izlenmeOrani = 75;

            Kurs kurs3 = new Kurs();

            kurs3.kursAdi = "Java fx";
            kurs3.egitmen = "Hasancan";
            kurs3.izlenmeOrani = 55;


            
           

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar )
            {
                Console.WriteLine(kurs.kursAdi);
               

            }
            Console.ReadLine();
        }

    }

    public class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
