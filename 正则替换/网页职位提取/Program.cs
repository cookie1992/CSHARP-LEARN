using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 网页职位提取
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "http://search.51job.com/jobsearch/search_result.php?fromJs=1&jobarea=020000&keywordtype=2&lang=c&stype=2&postchannel=0000&fromType=1&confirmdate=9";
            WebClient Wb1 = new WebClient();
           string Downstr= Wb1.DownloadString(path);
            //Console.WriteLine(Downstr);
            Regex reg = new Regex(@"<a target=.*title=""(.+)""*? href=""(.+)"".*onmousedown");
            MatchCollection match = reg.Matches(Downstr);
            foreach (Match item in match)
            {
                Console.WriteLine("职位={0}，链接={1}", item.Groups[1].Value, item.Groups[2].Value);
            }
            Console.ReadKey();





        }
    }
}
