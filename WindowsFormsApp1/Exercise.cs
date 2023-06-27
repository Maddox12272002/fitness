using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exercise : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        private bool mouseDown;
        private Point lastLocation;
        OleDbCommand cmd;
        public Exercise()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            Hide(); home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(56, 67, 88);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Red;
        }

        private void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void Exercise_Load(object sender, EventArgs e)
        {
            greet_lbl.Text = "Hello " + Form2.accName + ", this is today's routine!";

            if (Form2.accType == "Member" && Form2.trainer!=Form2.accName)
            {
                user_lbl.Text = "Trainer: "+Form2.trainer;
                userlist.Visible = false;
            } 
            else if(Form2.accType == "Member" && Form2.trainer == Form2.accName)
            {
                user_lbl.Visible = false;
                userlist.Visible = false;
            }

            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string query = "Select Name from Account where Trainer = '"+Form2.username+"'";
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userlist.Items.Add(reader["Name"].ToString()); //Lists all of the users' name in the comboBox
                    }

                    if (Form2.accType == "Member")
                        userlist.Text = Form1.user;
                    else
                        userlist.Text = userlist.Items[0].ToString();
                }
                catch (Exception E)
                {
                    MessageBox.Show("An error has occured. You may try again or contact the developer." + E);
                }
            }

            Routine(sender, e);
        }

        internal void Routine(object sender, EventArgs e)
        {
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                string query = "Select * from Routine Where username ='" + userlist.Text + "'";
                bridge = new OleDbDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                con.Open();
                bridge.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.Columns[0].Visible = false;
                con.Close();
            }
        }

        private void Exercise_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Exercise_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Exercise_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
