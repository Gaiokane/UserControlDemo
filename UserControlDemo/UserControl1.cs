using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string txt_txtbox;
        private string[] txt_cmbox = null;
        private string txt_btnname;
        private string txt_cmboxselect;

        public string Txt_txtbox { get => txt_txtbox; set => txt_txtbox = value; }
        public string[] Txt_cmbox { get => txt_cmbox; set => txt_cmbox = value; }
        public string Txt_btnname { get => txt_btnname; set => txt_btnname = value; }
        public string Txt_cmboxselect { get => txt_cmboxselect; set => txt_cmboxselect = value; }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            /*
            textBox1.Text = txt_txtbox;

            for (int i = 0; i < txt_cmbox.Length; i++)
            {
                comboBox1.Items.Add(txt_cmbox[i]);
            }

            button1.Text = txt_btnname;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showlabel();
        }

        public void showlabel()
        {
            Txt_txtbox = textBox1.Text;
            txt_cmboxselect = comboBox1.SelectedText;
            label1.Text = Txt_txtbox + " " + txt_cmboxselect;
        }
    }
}
