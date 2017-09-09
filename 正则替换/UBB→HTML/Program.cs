using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcUI.Extensions;

namespace UBB_HTML
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入UBB代码");
            string msg = Console.ReadLine();
            msg = MvcUI.Extensions.BBCodeUtils.ConvertBbCodeToHtml(msg);
            Console.WriteLine("输出的HTML代码为");
            Console.WriteLine(msg);
            Console.ReadKey();


        }
    }

}
