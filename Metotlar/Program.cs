using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya";
            product1.StokAdedi = 15;

            Product product2 =new Product();

            product2.Adi = "Karpuz";
            product2.Fiyati = 98;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.StokAdedi = 55;

            Product[] products = new Product[]{product1,product2};

            foreach (Product product in products) // (var product in products)
            {
                Console.WriteLine("Adı : "+ product.Adi + "\n" + "Fiyatı : " + product.Fiyati);
            }
            Console.WriteLine("--------Metotlar---------");

            // instance örneğini oluşturma

            // encapsulation ilişkilendirme
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Hasan","Uu",15);
            
            Console.ReadLine();
        }
    }
}
