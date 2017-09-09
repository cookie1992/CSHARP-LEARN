using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string email = Console.ReadLine();
                Console.WriteLine(Regex.IsMatch(email, @"^[\d\w]+[\d\w-_.]*[\d\w]+@[\d\w]+(.[\w\d]*){1,2}$", RegexOptions.ECMAScript));//邮箱

                //@"^(\d{3-4}(\-)?\d{7-8})|(\d{5}(\d{6})?)";//电话号码
                //@"^(\d{1,3}){4}$";//ip
                //@"^\d{4}-(0\d|1[1-2])-([0-1]\d)$";//日期






            }
            Console.ReadKey();

        }
    }
}
