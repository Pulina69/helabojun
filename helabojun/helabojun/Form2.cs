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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
