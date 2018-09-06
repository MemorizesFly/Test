using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入账号");
            string UserName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string UserPassword = Console.ReadLine();
            testInterface test = new testInterface();
            test.login(UserName, UserPassword);
            Console.WriteLine("请输入当前状态");
            string statusCode = Console.ReadLine();
            Console.WriteLine(test.getStatus(statusCode)); 

        }
    }

    public interface ILoginEvent
    {
        void login(string UserName,string UserPassword);
        bool getStatus(string StatusCode);
        
    }

    class testInterface : ILoginEvent
    {
        public bool getStatus(string StatusCode)
        {
            if (StatusCode=="true")
            {
                return true;
            }
            return false;
        }

        public void login(string UserName, string UserPassword)
        {
            if (UserName=="杨鹏飞"&&UserPassword=="123456")
            {
                Console.WriteLine("登陆成功");
            }
        }
    }
}
