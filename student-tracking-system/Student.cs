using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class Student
    {
        //properties...
        public string name, surname, birthdate;
        public char gender;
        public int classNo;

        //methods...
        public Student(string name, string surname, string birthdate, char gender, int classNo)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.gender = gender;
            this.classNo = classNo;
        }
    }
}
