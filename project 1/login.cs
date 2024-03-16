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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path =  new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15; // adjust the value to change the roundness of the corners

            // create a round rectangle path using the form's size  and radius 
            path.AddArc(0, 0, radius,radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); //bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // creat a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks==1 && e.Y<=this.Height && e.Y >= 0)
                {
                   // ReleaseCapture();
                    //senderMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            {
                MessageBox.Show("Successfuly Login");
                home h = new home();
                h = new home();
                h.Show();
                this.Hide();
            }
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sing_Up s = new Sing_Up();
            s = new Sing_Up();
            s.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
