using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {
            Console.WriteLine("ID numarası: "+musteri.Id + " Adı: "+musteri.Ad+" Soyadı: "+musteri.Soyad+" olan müşteri sisteme eklenmiştir." );
            Console.WriteLine("-------******------******");
        }
        public void Listele(Musteri[] musteri) {
            foreach (Musteri musteritem in musteri) {

                Console.WriteLine("ID numarası: " + musteritem.Id + " Adı: " + musteritem.Ad + " Soyadı: " + musteritem.Soyad);
              
            }
            Console.WriteLine("-------******------******");
        }
        public void Sil(Musteri musteri) {
            Console.WriteLine("ID numarası: " + musteri.Id + " Adı: " + musteri.Ad + " Soyadı: " + musteri.Soyad + " olan müşteri sistemden silinmiştir.");
            Console.WriteLine("-------******------******");
        }
    }
}
