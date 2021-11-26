using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class VirtualDB
    {
        //properties...
        public List<Student> studentList = new List<Student>();
        public List<Personal> personalList = new List<Personal>();

        //methods...
        public VirtualDB()
        {
            this.addPersonal();
        }

        public void addStudent()
        {
            Console.Write("\nÖğrenci Ad: ");
            string name = Console.ReadLine();

            Console.Write("Öğrenci SoyAd: ");
            string surname = Console.ReadLine();

            Console.Write("Öğrenci Sınıf No: ");
            int classNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Öğrenci Dogum Tarihi: ");
            string birthdate = Console.ReadLine();

            Console.Write("Öğrenci Cinsiyet: ");
            char gender = Convert.ToChar(Console.ReadLine());

            Student student = new Student(name, surname, birthdate, gender, classNo);
            studentList.Add(student);
        }

        public void changeInformationStudent()
        {

        }

        public void ListStudent()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine("\n" + student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthdate + "\n");
            }
        }

        public void ListStudentGender()
        {
            Console.Write("Hangi Cinsiyete Göre: ");
            char gender = Convert.ToChar(Console.ReadLine());

            foreach (Student student in studentList)
            {
                if (student.gender == gender)
                {
                    Console.WriteLine(student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthdate + "\n\n");
                }
            }
        }

        public void addPersonal()
        {
            Personal personal = new Personal("burak", "123456");
            personalList.Add(personal);
        }
    }
}
