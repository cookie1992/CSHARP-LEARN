using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 加密
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jiami(textBox2.Text, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"E:\123.txt";
            textBox2.Text = @"E:\345.rar";

        }
        private static void Jiami(string a, string b)
        {
            using (FileStream fs1 = new FileStream(a, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fs2 = new FileStream(b, FileMode.Create, FileAccess.Write))
                {
                    byte[] byte1 = new byte[1024 * 1024 * 15];
                    int r = 0; 
                    while ((r=fs1.Read(byte1, 0, byte1.Length)) > 0)
                    {
                        for (int i = 0; i < r; i++)
                        {
                            byte1[i] =Convert.ToByte(Byte.MaxValue - byte1[i]);
                        }
                        fs2.Write(byte1, 0, r);
                    }


                }
            }
        }
    }
}
