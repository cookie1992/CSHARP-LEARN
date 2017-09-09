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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string str,GetForm2Delegate gt1)
        {
            InitializeComponent();
            textBox1.Text = str;
            gt2 = gt1;
        }
        private GetForm2Delegate gt2;
        public  GetForm1Delegate geet1;
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gt2(textBox1.Text.Trim());
            this.Dispose();
        }
    }
}
