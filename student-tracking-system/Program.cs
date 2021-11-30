using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login.login();

            Loop:
                Menu.showMenu();

                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 0) { Environment.Exit(0); }

                if (choose == 1) { StudentDB.addStudent(); }

                if (choose == 2) { StudentDB.updateStudent(); }

                if (choose == 3) { StudentDB.ListStudent(); }

                if (choose == 4) { StudentDB.ListStudentByGender(); }
            goto Loop;
             
        }
    }
}
