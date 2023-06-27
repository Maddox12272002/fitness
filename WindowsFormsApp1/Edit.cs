using System;
using System.Collections;
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
    public partial class Edit : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        private bool mouseDown;
        private Point lastLocation;
        public static int index = 0;
        public Edit()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide(); Form2 home = new Form2(); home.Show();
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
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Form5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExercise add = new AddExercise();
            index = userlist.SelectedIndex; add.Show();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                string query = "Delete From Routine where Exercise = @exer";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@exer", routine_list.CurrentRow.Cells[1].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Routine(sender,e);
        }

        internal void add_Click(object sender, EventArgs e, string user)
        {
            userlist.Text = user;
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                try
                {
                    string query = "";
                    query = "Insert into Routine (Username,Exercise, [Set/s], Repetitions, Equipment,TimeSec) values (@user,@name,@set,@rep,@equip,@time)";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", AddExercise.user);
                    cmd.Parameters.AddWithValue("@name", AddExercise.exer);
                    cmd.Parameters.AddWithValue("@set", AddExercise.sets);
                    cmd.Parameters.AddWithValue("@rep", AddExercise.reps);
                    cmd.Parameters.AddWithValue("@equip", AddExercise.equip);
                    cmd.Parameters.AddWithValue("@time", AddExercise.times);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show("There has been an error in adding. Please ensure the fields are filled correctly." + E);
                }
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            if (Form2.accType == "Member")
            {
                user_lbl.Visible = false;
                userlist.Visible = false;
                userlist.Text = Form1.user;
            }

            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string query = "Select Username from Account where Trainer = '" + Form2.username + "'";
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userlist.Items.Add(reader["Username"].ToString()); //Lists all of the users' name in the comboBox
                    }
                    if (Form2.accType != "Member")
                        userlist.Text = userlist.Items[0].ToString();
                }
                catch
                {
                    MessageBox.Show("No members are training under you as of the moment");
                }
            }
            Routine(sender,e);
        }
        public void Routine(object sender, EventArgs e)
        {
            Routine();
        }
        public void Routine(object sender, MouseEventArgs e)
        {
            Routine();
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                string query = "Delete From Routine where Username = @user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", userlist.Text);
                con.Open(); 
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Routine()
        {
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                string query = "Select * from Routine Where username ='" + userlist.SelectedItem.ToString() + "'";
                bridge = new OleDbDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                con.Open();
                bridge.Fill(dtbl);
                routine_list.DataSource = dtbl;
                routine_list.Columns[0].Visible = false;
                con.Close();
            }
        }
    }
}