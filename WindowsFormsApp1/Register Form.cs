using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        DataSet ds;
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\Nodz\\Desktop\\The dream\\Database\\Database1.accdb");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Make a Query, mangutana ra ta sa database
            string query = "Select * from UserInfo Where username ='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            //Create an object that will send query through our connection to the sql server
            bridge = new OleDbDataAdapter(query, con);
            //Datable to put matching login info
            DataTable dtbl = new DataTable();
            //Fill the table with matching info from textbox 1 and 2 and user and pass from database
            bridge.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form2 home = new Form2();
                this.Hide(); home.Show();
            }
            else
                MessageBox.Show("Incorrect username or password. Please try again!");
        }

        private void button2_Click(object sender, EventArgs e) //ibalhin ni nga code sa registration nga form
        {
            //Make a Query, mangutana ra ta sa database
            string query = "Select * from UserInfo Where username ='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            //Create an object that will send query through our connection to the sql server
            bridge = new OleDbDataAdapter(query, con);
            //Datable to put matching login info
            DataTable dtbl = new DataTable();
            //Fill the table with matching info from textbox 1 and 2 and user and pass from database
            bridge.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
                MessageBox.Show("Username is already taken!");
            else {
                try
                {
                    //write query
                    string commString = "INSERT INTO UserInfo (username, password) VALUES (@val1,@val2)";
                    //create an sqlCommand
                    cmd = new OleDbCommand(commString, con);
                    //where sanitizing happens
                    //sanitizing prevents adding malitious pieces of code into the query strings
                    cmd.Parameters.AddWithValue("@val1", textBox1.Text); // ilisan para registration
                    cmd.Parameters.AddWithValue("@val2", textBox2.Text); // ilisan para registration
                    //open  the connection
                    con.Open();
                    //execute query
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Successful!");
                }
                catch { MessageBox.Show("An error has occured. You may try again or contact the developer."); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            start.Hide();
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
    }
}
