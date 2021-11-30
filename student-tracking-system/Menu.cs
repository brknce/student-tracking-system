using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class Menu
    {
        public static void showMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Ogrenci Ekle                           ");
            Console.WriteLine("2. Ogrenci Bilgi Değişikliği              ");
            Console.WriteLine("3. Bütün Öğrencileri Listele              ");
            Console.WriteLine("4. Öğrencileri Cinsiyete Göre Listele     ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Seciniz...(Çıkmak İçin 0 Seçiniz...)");
        }
    }
}
