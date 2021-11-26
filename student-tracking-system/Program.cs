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
            VirtualDB db = new VirtualDB();
            Menu menu = new Menu();
            Login login = new Login(db);

            Menu:
            menu.showMenu();
            int choose = Convert.ToInt32(Console.ReadLine());
            menu.doSomething(db, choose);
            goto Menu;
             
        }
    }
}
