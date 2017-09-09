using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //下载HTML
            WebClient wb = new WebClient();
            string html = wb.DownloadString("http://image.baidu.com/search/index?tn=baiduimage&ps=1&ct=201326592&lm=-1&cl=2&nc=1&ie=utf-8&word=%E7%BE%8E%E5%A5%B3");
            //提取<img/>
            MatchCollection match = Regex.Matches(html, @"<img.*?src=""(.+?)""",RegexOptions.IgnoreCase);
            foreach (Match item in match)
            {
                string pathimg= "http://image.baidu.com/search/index?tn=baiduimage&ps=1&ct=201326592&lm=-1&cl=2&nc=1&ie=utf-8&word=%E7%BE%8E%E5%A5%B3"+(item.Groups[1].Value);
                //下载
                wb.DownloadFile(pathimg, @"E:\" + System.DateTime.Now.ToFileTime() + ".jpg");
            }




            Console.ReadKey();
        }
    }
}
