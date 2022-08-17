using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager mManager = new MusteriManager();

            Musteri Musteri1 = new();
            Musteri1.Id =101;
            Musteri1.Ad = "Kamil";
            Musteri1.Soyad = "ÖZEL";

            Musteri Musteri2 = new();
            Musteri2.Id = 102;
            Musteri2.Ad = "Orkun";
            Musteri2.Soyad = "DİNÇ";

            Musteri Musteri3 = new();
            Musteri3.Id = 103;
            Musteri3.Ad = "Özgür";
            Musteri3.Soyad = "DEMİRAY";

            Musteri[] MusteriArray = new Musteri[] {Musteri1,Musteri2,Musteri3 };
            mManager.Ekle(Musteri1);
            mManager.Listele(MusteriArray);
            mManager.Sil(Musteri3);
           
                    

        }
    }
}
