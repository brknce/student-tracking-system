using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_tracking_system
{
    static class Login
    {
        //methods...
        public static void login()
        {
            bool isLogin = false;
            while (!isLogin)
            {
                Console.Write("Kullanıcı Adı Giriniz: ");
                string username = Console.ReadLine();

                Console.Write("Şifre Giriniz: ");
                string password = Console.ReadLine();

                if (username == "burak" && password == "123456")
                {
                    isLogin = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı...");
                }
            }
        }
    }
}
