using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        private bool mouseDown;
        private Point lastLocation;
        Form1 start = new Form1();

        public Register()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database1.accdb");
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Regis_Click(object sender, EventArgs e)
        {
            //Make a Query, mangutana ra ta sa database
            string query = "Select * from [User] Where username ='" + regisUser.Text + "'";
            //Create an object that will send query through our connection to the sql server
            bridge = new OleDbDataAdapter(query, con);
            //Datable to put matching login info
            DataTable dtbl = new DataTable();
            //Fill the table with matching info from textbox 1 and 2 and user and pass from database
            bridge.Fill(dtbl);
            //con.Close();
            if (dtbl.Rows.Count > 0)
            {
                Console.Beep();
                MessageBox.Show("Username is already taken!");
            }
            else if (regisPass.Text != regisPassConfirm.Text)
            {
                Console.Beep();
                MessageBox.Show("Passwords do not match! Please try again.");
            }
            else
            {
                try
                {
                    query = "Insert into [User] (Username, [Password]) values (@user,@pass)";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", regisUser.Text);
                    cmd.Parameters.AddWithValue("@pass", regisPass.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Successful!");
                    Hide(); start.Show();
                }
                catch { MessageBox.Show("An error has occured. You may try again or contact the developer."); }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide(); start.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
