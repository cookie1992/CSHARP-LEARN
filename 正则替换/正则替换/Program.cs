using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则替换
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 杂
            // string str = "Welcome 'to' china 'fadf'";

            //str= Regex.Replace(str, "'(.+?)'", "{$1}");
            // Console.WriteLine(str);
            // Console.ReadKey();

            // //手机号
            // //"(\d{3})\d{4}(\d{4})" "$1****$2"

            // 邮箱
            // "([-0-9a-zA-Z._]+)@[0-9a-zA-Z]+(\.[0-9a-zA-Z]+){1,3}"  
            #endregion


            #region \b的用法
            //什么是单词? 【a-zA-Z0-9_】
            //welcome come come come =4个单词
            // \b的意思是单词的边界。只判断不匹配
            //把row单词换成line
            //string msg = "the day after tomorrow is my wedding day.The row we are looking for is .row. nuber 10";
            //  msg= Regex.Replace(msg, @"\brow\b","line");
            //Console.WriteLine(msg);
            ////Console.ReadKey();

            //string msg = "# ## ### #### ## ### # ###.";
            //MatchCollection match = Regex.Matches(msg, @"\b###\b");
            //foreach (Match item in match)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.ReadKey();
            ////#不是单词，所以输出为空
            #endregion


            #region 叠词去重.
            ////叠词去重
            //while (true)
            //{
            //    Console.WriteLine("请输入叠词：");
            //    string msg = Console.ReadLine();
            //    msg = Regex.Replace(msg, @"(.)\1+", "$1");
            //    Console.WriteLine(msg);
            //}
            #endregion

            #region 从文本中取叠词
            //string msg = "浩浩荡荡，清清白白";
            //string msg1 = "如火如荼，愈演愈烈";
            //MatchCollection match = Regex.Matches(msg, @"(.)\1+");
            //msg1 = Regex.Replace(msg1,@"(.).\1.","$1");
            //foreach (Match item in match)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine("=========================");
            //Console.WriteLine(msg1);
            //Console.ReadKey();



            #endregion

        }
    }
}
