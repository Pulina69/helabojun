using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace helabojun
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new UserControl2();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl4 uc = new UserControl4();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl5 uc = new UserControl5();
            addUserControl(uc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserControl6 uc = new UserControl6();
            addUserControl(uc);
        }
    }
}
