using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class Validate
    {
        static string[] classNumbers = { "1", "2", "3", "4" };
        static string[] genders = { "e", "k", "E", "K" };

        public static string name()
        {
            Console.Write("Öğrenci Ad: ");
            string name = Console.ReadLine().Replace('ö', 'o')
                .Replace('ü', 'u')
                .Replace('ş', 's')
                .Replace('ç', 'c')
                .Replace('ğ', 'g');

            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.Write("Lütfen geçerli bir ad giriniz: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public static string surname()
        {
            Console.Write("Öğrenci Soyad: ");
            string surname = Console.ReadLine().Replace('ö','o')
                .Replace('ü', 'u')
                .Replace('ş','s')
                .Replace('ç','c')
                .Replace('ğ','g');
            
            while (!Regex.IsMatch(surname, @"^[a-zA-Z]+$"))
            {
                Console.Write("Lütfen geçerli bir soyad giriniz: ");
                surname = Console.ReadLine();
            }

            return surname;
        }

        public static char gender()
        {
            Console.Write("Öğrenci Cinsiyet(e/k): ");
            string gender = Console.ReadLine();

            while (!genders.Contains(gender))
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                gender = Console.ReadLine();
            }

            return char.ToUpper(Convert.ToChar(gender));
        }

        public static int classNo()
        {
            Console.Write("Öğrenci Sınıf No(1-4): ");
            string classNo = Console.ReadLine();

            while (!classNumbers.Contains(classNo))
            {
                Console.Write("Lütfen geçerli bir sınıf no giriniz(1-4): ");
                classNo = Console.ReadLine();
            }

            return Convert.ToInt32(classNo);
        }

        public static string birthday()
        {
            Console.Write("Öğrenci Dogum Tarihi(gg.aa.yyyy): ");
            string birthdate = Console.ReadLine();

            while (!Regex.IsMatch(birthdate, @"^([0-9]\d)\.([0-9]\d)\.(\d{4})$"))
            {
                Console.Write("lütfen geçerli bir tarih giriniz(gg.aa.yyy): ");
                birthdate = Console.ReadLine();
            }

            return birthdate;
        }
    
        public static int IdforUpdate()
        {
            int studentListLength = StudentDB.studentList.Count;
            string[] id = new string[studentListLength];

            for(int i=0; i< studentListLength; i++)
            {
                id[i] = Convert.ToString(i + 1);
            }
            
            Console.Write("Güncellemek istediğiniz öğrenci id: ");
            string studentID = Console.ReadLine();

            while (!id.Contains(studentID))
            {
                Console.Write("Lütfen geçerli bir öğrenci id giriniz: ");
                studentID = Console.ReadLine();
            }

            return Convert.ToInt32(studentID);

        }
    }
}
