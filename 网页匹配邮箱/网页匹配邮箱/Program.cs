using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 网页匹配邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 通过WEBCLIENT
            WebClient web = new WebClient();
           string path= web.DownloadString("http://tieba.baidu.com/p/2366935784");

            #endregion

            MatchCollection matches = Regex.Matches(path, @"[-0-9a-zA-Z_\.]+@[-0-9a-zA-Z_]+(\.[-0-9a-zA-Z_]+){1,3}");
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
               
            }
            Console.WriteLine("共有{0}个邮箱",matches.Count);
            Console.ReadKey();



        }
    }
}
