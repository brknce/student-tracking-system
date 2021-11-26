using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    internal class Login
    {
        //properties...
        bool isLogin = false;

        //methods...
        public Login(VirtualDB db)
        {
            while (!this.isLogin)
            {
                Console.Write("Kullanıcı Adı Giriniz: ");
                string username = Console.ReadLine();

                Console.Write("Şifre Giriniz: ");
                string password = Console.ReadLine();

                Console.WriteLine();

                foreach (Personal personal in db.personalList)
                {
                    if (username == personal.username && password == personal.password)
                    {
                        this.isLogin = true;
                        Console.Clear();
                    }
                }
            }
        }
    }
}
