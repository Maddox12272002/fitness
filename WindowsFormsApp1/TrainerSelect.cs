using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrainerSelect : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        internal protected bool mouseDown;
        internal protected Point lastLocation;
        static internal protected bool done = false;
        Form2 home = new Form2();

        public TrainerSelect()
        {
            InitializeComponent();
        }

        private void TrainerSelect_Load(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string query = "Select Username from [User] where AccountType = 'Trainer'";
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        trainerlist.Items.Add(reader["Username"].ToString()); //Lists all of the users' name in the comboBox
                    }
                    trainerlist.Text = trainerlist.Items[0].ToString();
                }
                catch
                {
                    MessageBox.Show("An error has occured!", "Trainer Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                if (trainerlist.Text == "")
                    MessageBox.Show("Please select a trainer!", "Trainer Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string query = "Update Client Set Trainer = @train where Username = @user";
                    cmd = new OleDbCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@train", trainerlist.Text);
                    cmd.Parameters.AddWithValue("@user", Form1.user);
                    cmd.ExecuteNonQuery();
                }
            }
            Close(); home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            done = true; Close(); home.Show();
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
