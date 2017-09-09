using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        static void Main(string[] args)
        {
            //del使用了委托方法
            MyDelegate del = new MyDelegate(M1);
            del += M1;
            del();
            Console.ReadKey();

        }
        static void M1()
        {
            Console.WriteLine("无返回值");
        }

        /// <summary>
        /// 委托是一个数据类型
        /// </summary>
        //定义委托类型
        public delegate void MyDelegate();
    }
}
