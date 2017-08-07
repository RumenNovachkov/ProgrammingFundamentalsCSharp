using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@').ToArray();
            var username = email[0].ToCharArray();
            var domain = email[1].ToCharArray();

            var usernameCount = 0;
            var domainCount = 0;
            foreach (var lether in username)
            {
                usernameCount += Convert.ToInt32(lether);
            }
            foreach (var lether in domain)
            {
                domainCount += Convert.ToInt32(lether);
            }

            if (domainCount - usernameCount > 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else Console.WriteLine("Call her!");
        }
    }
}
