using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai19_trycatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int so = Convert.ToInt32(textBox1.Text);
                label1.Text = (100 + so).ToString();
            }
            catch {
                label1.Text = "vui lòng nhập số nguyên";
            }
            
           
        }
    }
}
