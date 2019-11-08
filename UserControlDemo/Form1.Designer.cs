namespace UserControlDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl12 = new UserControlDemo.UserControl1();
            this.userControl11 = new UserControlDemo.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(338, 162);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(298, 151);
            this.userControl12.TabIndex = 3;
            this.userControl12.Txt_btnname = "testname";
            this.userControl12.Txt_cmbox = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"};
            this.userControl12.Txt_cmboxselect = null;
            this.userControl12.Txt_txtbox = null;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(71, 68);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(298, 151);
            this.userControl11.TabIndex = 0;
            this.userControl11.Txt_btnname = null;
            this.userControl11.Txt_cmbox = null;
            this.userControl11.Txt_cmboxselect = null;
            this.userControl11.Txt_txtbox = null;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControl1 userControl12;
    }
}

