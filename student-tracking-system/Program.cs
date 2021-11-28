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
                Menu.doSomething();
            goto Loop;
             
        }
    }
}
