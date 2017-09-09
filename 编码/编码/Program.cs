using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编码
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader stream1 = new StreamReader("123.txt");
            //if (stream1.ReadToEnd()==string.Empty)
            //{

            //}
            //if (File.ReadAllText("123.txt")==string.Empty)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}

            //StringBuilder sb = new StringBuilder();
            //sb.Append("345\n");
            //sb.Append("3415");
            //Console.WriteLine(sb.ToString());

            //using (FileStream fs1 = new FileStream("123.txt", FileMode.OpenOrCreate))
            //{
            //    using (FileStream fs2 = new FileStream("345.txt", FileMode.OpenOrCreate)  )
            //    {
            //        fs1.CopyTo(fs2);
            //    }
            //} 

            //拷贝大文件
            string a = @"H:\迅雷下载\cyuygaojbc_xpgod\Professional C# 6 and .NET Core 1.0.pdf";
            string b = @"H:\Professional C# 6 and .NET Core 1.0.pdf";
            Bigfilecopy(a, b);
            Console.ReadKey();




            //Console.ReadKey();


        }


        /// <summary>
        /// 大文件拷贝
        /// </summary>
        /// <param name="a">源</param>
        /// <param name="b">目标</param>
        private static void Bigfilecopy(string a, string b)
        {
            using (FileStream fs1 = new FileStream(a, FileMode.Open,FileAccess.Read))
            {
                using (FileStream fs2 = new FileStream(b, FileMode.Create,FileAccess.Write))
                {
                    byte[] byte1 = new byte[1024 * 1024 * 15];
                    int r = fs1.Read(byte1, 0, byte1.Length);
                    double v = 0;
                    while (r > 0) 
                    {
                        fs2.Write(byte1, 0, r);
                        v = Math.Round((fs2.Position / (double)fs1.Length) * 100, 2);
                        Console.WriteLine(v+"%");
                        r = fs1.Read(byte1, 0, byte1.Length);
                    }
                   

                }
            }
        }
    }
}
