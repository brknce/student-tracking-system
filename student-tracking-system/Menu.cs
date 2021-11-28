using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class Menu
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
            StudentDB studentDB = new StudentDB();
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 0) { Environment.Exit(0); }

            if (choose == 1) { studentDB.addStudent();}

            if (choose == 3) { studentDB.ListStudent();}

            if (choose == 4) { studentDB.ListStudentGender();}
        }
    }
}
