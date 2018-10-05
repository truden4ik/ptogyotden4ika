using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
          float result = float.Parse(textBox1.Text); 
          float otvet = (result - 1) / 2;
         textBox2.Text = (otvet).ToString();
         textBox3.Text = (otvet+1).ToString();
        }
    }
}
