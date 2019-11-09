using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace UserControlDemo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //要将用户控件用在其他项目上，右键项目->属性->将输出类型改为类库，重新生成一下就可以了
        //使用时，将输出的dll文件拖动到项目，Windows窗体设计界面左侧工具箱中即可

        private string txt_txtbox;
        private string[] cmboxsz = null;
        private string txt_btnname;

        //用户控件在窗体中下方公有变量属性的分类
        [Category("qk文本框"), Browsable(true), Description("文本框赋值")]
        //公有变量会显示在用户控件的属性中
        public string Txt_txtbox
        {
            get { return txt_txtbox; }
            set { txt_txtbox = value; }
        }

        [Category("qk下拉框"), Browsable(true), Description("下拉框赋值")]
        public string[] Cmboxsz
        {
            get { return cmboxsz; }
            set { cmboxsz = value; }
        }

        [Category("qk按钮"), Browsable(true), Description("按钮名称")]
        public string Txt_btnname
        {
            get { return txt_btnname; }
            set { txt_btnname = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " " + comboBox1.SelectedItem;
        }

        public void run()
        {
            //赋值给文本框
            textBox1.Text = txt_txtbox;

            //循环赋值给下拉框
            if (cmboxsz.Length > 0)
            {
                comboBox1.Items.Clear();
                for (int i = 0; i < cmboxsz.Length; i++)
                {
                    comboBox1.Items.Add(cmboxsz[i]);
                }
                comboBox1.SelectedIndex = 0;
            }

            //赋值给按钮
            button1.Text = txt_btnname;
        }
    }
}