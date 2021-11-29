using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class Menu
    {
        //methods...
        public static void showMenu()
        {
            Console.WriteLine("1. Ogrenci Ekle");
            Console.WriteLine("2. Ogrenci Bilgi Değişikliği");
            Console.WriteLine("3. Bütün Öğrencileri Listele");
            Console.WriteLine("4. Öğrencileri Listele Cinsiyete Göre");
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Seciniz...(Çıkmak İçin 0 Seçiniz...)");
        }

        public static void doSomething()
        {
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 0) { Environment.Exit(0); }

            if (choose == 1) { StudentDB.addStudent();}

            if (choose == 2) { StudentDB.updateStudent(); }
            
            if (choose == 3) { StudentDB.ListStudent();}

            if (choose == 4) { StudentDB.ListStudentGender();}
        }
    }
}
