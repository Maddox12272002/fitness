using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        internal protected OleDbDataAdapter bridge = new OleDbDataAdapter();
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;
        internal static string user = "";
       
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Make a Query, mangutana ra ta sa database
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "Select * from [User] Where username ='" + user_txt.Text + "' and password = '" + pass_txt.Text + "'";
                //Create an object that will send query through our connection to the sql server
                bridge = new OleDbDataAdapter(query, con);
                //Datable to put matching login info
                DataTable dtbl = new DataTable();
                //Fill the table with matching info from textbox 1 and 2 and user and pass from database
                bridge.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Hide();
                    if (user_txt.Text == "admin" || user_txt.Text == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else
                    {
                        user = user_txt.Text;
                        Form2 home = new Form2();
                        home.Show();
                    }
                }

                else
                    MessageBox.Show("Incorrect username or password. Please try again!");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //ibalhin ni nga code sa registration nga form
        {
            Register2 register= new Register2();
            Hide(); register.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public void Close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        public void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.FromArgb(56, 67, 88);
        }

        public void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            minimize_btn.BackColor = Color.Transparent;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                pass_txt.UseSystemPasswordChar = false;
            }
            else
            {
                pass_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
