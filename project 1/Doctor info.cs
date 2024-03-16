using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Doctor_info : Form
    {
        public Doctor_info()
        {
            InitializeComponent();
        }
        private void display()
        {
            SqlConnection con = new SqlConnection("server = OTAKUYA; database = faculty; trusted_connection= True;");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Professors" , con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void insert()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection("server = OTAKUYA; database = faculty; trusted_connection= True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Professors(Prof_id, Prof_N, Prof_dep, Prof_gender) values(@p_id, @p_n, @dep_id, @p_g)", conn);
                cmd.Parameters.AddWithValue("@p_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@p_n", textBox2.Text);
                cmd.Parameters.AddWithValue("@dep_id", textBox3.Text);
                cmd.Parameters.AddWithValue("@p_g", textBox4.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully.");
            }
            else
            {
                MessageBox.Show("Please provide details.");
            }
        }
        private void delete()
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(("server = OTAKUYA; database = faculty; trusted_connection= True;"));
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Professors where Prof_id=@p_id", con);
                cmd.Parameters.AddWithValue("@p_id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted Successfully");
            }
            else
            {
                MessageBox.Show("please enter id to delete");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            home back = new home();
            back.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 20;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Doctor_info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            display();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
