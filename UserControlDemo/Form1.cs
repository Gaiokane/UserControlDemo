using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Txt_txtbox = "11";
            userControl11.Txt_cmbox = new string[] { "q1", "q2", "q3" };
            userControl11.Txt_btnname = "12";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Txt_txtbox = "21";
            userControl11.Txt_cmbox = new string[] { "w1", "w2", "w3" };
            userControl11.Txt_btnname = "22";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.showlabel();
        }
    }
}
