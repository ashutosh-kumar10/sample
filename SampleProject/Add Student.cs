using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleProject
{
    public partial class Add_Student : MetroFramework.Forms.MetroForm
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n, r, c;
            n = name.Text;
            r = roll.Text;
            c = course.Text;
            MessageBox.Show("Name="+n+" Roll No="+r+" Course="+c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = "";
            roll.Text = "";
            course.Text = "";
        }
    }
}
