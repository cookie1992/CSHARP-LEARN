using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 文本练习1  dd/mm/yyyy→yyyy-mm-dd
            string msg = "我的生日是05/21/2010";
            msg = Regex.Replace(msg, @"([0-9]{2})/([0-9]{2})/([0-9]{4})","$3-$2-$1");
            Console.WriteLine(msg);
            Console.ReadKey();




            #endregion






        }
    }
}
