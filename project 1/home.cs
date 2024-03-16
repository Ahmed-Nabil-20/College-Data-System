using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student_info student_Info = new student_info();
            student_Info = new student_info();
            student_Info.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doctor_info doctor_Info = new Doctor_info();
            doctor_Info = new Doctor_info();
            doctor_Info.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            department_info department_Info = new department_info();
            department_Info = new department_info();
            department_Info.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            course_info course_Info = new course_info();
            course_Info = new course_info();
            course_Info.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}
