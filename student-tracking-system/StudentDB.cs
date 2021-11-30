using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class StudentDB
    {
        public static List<Student> studentList = new List<Student>();

        public static Student createStudent(int studentID)
        {
            int    id = studentID;
            string name = Validate.name();
            string surname = Validate.surname();
            int    classNo = Validate.classNo();
            char gender = Validate.gender();
            string birthdate = Validate.birthday();
            
            return new Student(id, name, surname, birthdate, gender, classNo);
        }

        public static void addStudent()
        {
            Console.Clear();
            Student student = createStudent(studentList.Count + 1);
            studentList.Add(student);
            Console.Clear();
            Console.WriteLine("Kayıt Eklendi...");
        }

        public static void updateStudent()
        {
            Console.Clear();
            ListStudent();

            if (studentList.Count>0)
            {
                int studentID = Validate.IdforUpdate();
                Console.Clear();

                Student student = createStudent(studentID);

                studentList[studentID - 1] = student;

                Console.Clear();
                Console.WriteLine("Güncelleme Başarılı...\n");
            }

        }

        public static void ListStudent()
        {
            Console.Clear();
            if (studentList.Count == 0)
            {
                Console.WriteLine("Kayıt Bulunamadı....");
                return;
            }
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.id + "\t" + student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthday + "\n");
            }
        }

        public static void ListStudentByGender()
        {
            if (studentList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Kayıt Bulunamadı....");
                return;
            }
            char gender = Validate.gender();
            bool isEmpty = true;
            Console.Clear();

            foreach (Student student in studentList)
            {
                if (student.gender == gender)
                {
                    Console.WriteLine(student.id + "\t" + student.name + "\t" + student.surname + "\t" + student.classNo
                    + "\t" + student.gender + "\t" + student.birthday + "\n\n");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("Kayıt Bulunamadı....");
            }
        }
    }
}
