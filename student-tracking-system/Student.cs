using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string birthday { get; set; }
        public int classNo { get; set; }
        public char gender { get; set; }

        public Student(int id, string name, string surname, string birthdate, char gender, int classNo)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.birthday = birthdate;
            this.gender = gender;
            this.classNo = classNo;
        }
    }
}
