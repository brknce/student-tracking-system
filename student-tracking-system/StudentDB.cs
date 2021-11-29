using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class StudentDB
    {
        //properties...
        public static List<Student> studentList = new List<Student>();

        //methods...
        public static void addStudent()
        {
            Console.Write("\nÖğrenci Ad: ");
            string name = Console.ReadLine();

            Console.Write("Öğrenci SoyAd: ");
            string surname = Console.ReadLine();

            Console.Write("Öğrenci Sınıf No(1-4): ");
            string tempClassNo = Console.ReadLine();

            while(tempClassNo.Length > 1 || tempClassNo == "")
            {
                Console.Write("1 ile 4 arasında bir sınıf giriniz: ");
                tempClassNo = Console.ReadLine();
            }

            int classNo = Convert.ToInt32(tempClassNo);

            while (classNo < 1  || classNo > 4)
            {
                Console.Write("1 ile 4 arasında bir sınıf giriniz: ");
                classNo = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Öğrenci Dogum Tarihi: ");
            string birthdate = Console.ReadLine();

            Console.Write("Öğrenci Cinsiyet(e/k): ");
            string tempGender = Console.ReadLine();

            while (tempGender.Length > 1 || tempGender == "")
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                tempGender = Console.ReadLine();
            }

            char gender = char.ToLower(Convert.ToChar(tempGender));

            while (gender != 'e' && gender != 'k')
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                gender = char.ToLower(Convert.ToChar(Console.ReadLine()));
            }

            Student student = new Student(name, surname, birthdate, gender, classNo);
            studentList.Add(student);

            Console.Clear();
        }

        public static void updateStudent()
        {
            Console.Clear();
            int studentID = 1;
            foreach (Student student in studentList)
            {
                Console.WriteLine("\n" + studentID + ".\t" + student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthday + "\n");
                studentID += 1;
            }
            Console.Write("Güncellemek istediğiniz öğrenci id: ");
            studentID = Convert.ToInt32(Console.ReadLine());

            while (studentID < 1 || studentID > studentList.Count)
            {
                Console.Write("Lütfern geçerli bir öğrenci id giriniz: ");
                studentID = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nÖğrenci Ad: ");
            string name = Console.ReadLine();

            Console.Write("Öğrenci SoyAd: ");
            string surname = Console.ReadLine();

            Console.Write("Öğrenci Sınıf No(1-4): ");
            string tempClassNo = Console.ReadLine();

            while (tempClassNo.Length > 1 || tempClassNo == "")
            {
                Console.Write("1 ile 4 arasında bir sınıf giriniz: ");
                tempClassNo = Console.ReadLine();
            }

            int classNo = Convert.ToInt32(tempClassNo);

            while (classNo < 1 || classNo > 4)
            {
                Console.Write("1 ile 4 arasında bir sınıf giriniz: ");
                classNo = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Öğrenci Cinsiyet(e/k): ");
            string tempGender = Console.ReadLine();

            while (tempGender.Length > 1 || tempGender == "")
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                tempGender = Console.ReadLine();
            }

            char gender = char.ToLower(Convert.ToChar(tempGender));

            while (gender != 'e' && gender != 'k')
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                gender = char.ToLower(Convert.ToChar(Console.ReadLine()));
            }

            Console.Write("Öğrenci Dogum Tarihi: ");
            string birthday = Console.ReadLine();

            studentList[studentID - 1].name = name;
            studentList[studentID - 1].surname = surname;
            studentList[studentID - 1].birthday = birthday;
            studentList[studentID - 1].gender = gender;
            studentList[studentID - 1].classNo = classNo;

            Console.Clear();
            Console.WriteLine("Güncelleme Başarılı...\n");

        }

        public static void ListStudent()
        {
            Console.Clear();
            foreach (Student student in studentList)
            {
                Console.WriteLine("\n" + student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthday + "\n");
            }
        }

        public static void ListStudentGender()
        {
            Console.Write("Hangi Cinsiyete Göre(e/k): ");
            string tempGender = Console.ReadLine();

            while (tempGender.Length > 1 || tempGender == "")
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                tempGender = Console.ReadLine();
            }

            char gender = char.ToLower(Convert.ToChar(tempGender));

            while (gender != 'e' && gender != 'k')
            {
                Console.Write("Lütfen geçerli bir cinsiyet giriniz(e/k): ");
                gender = char.ToLower(Convert.ToChar(Console.ReadLine()));
            }

            Console.Clear();
            foreach (Student student in studentList)
            {
                if (student.gender == gender)
                {
                    Console.WriteLine(student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthday + "\n\n");
                }
            }
        }
    }
}
