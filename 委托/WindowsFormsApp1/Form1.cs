using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public delegate void InterDel(string t1);
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.dell2 += Give;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void Give(string va1)
        {
            textBox1.Text = va1;


        }
    }
}
