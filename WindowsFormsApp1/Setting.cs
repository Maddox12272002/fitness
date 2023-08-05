using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Setting : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        private bool mouseDown;
        private Point lastLocation;

        public Setting()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "Select * from [User] Where username ='" + Form1.user + "'";
                //Create an object that will send query through our connection to the sql server
                bridge = new OleDbDataAdapter(query, con);
                //Datable to put matching login info
                DataTable dtbl = new DataTable();
                //Fill the table with matching info from textbox 1 and 2 and user and pass from database
                bridge.Fill(dtbl);
                user_txtbox.Text = dtbl.Rows[0][0].ToString();
                pass_txtbox.Text = dtbl.Rows[0][1].ToString();
                accType_txtbox.Text = dtbl.Rows[0][3].ToString();

                query = "Select * from Client Where username ='" + Form1.user + "'";
                bridge = new OleDbDataAdapter(query, con);
                dtbl = new DataTable();
                bridge.Fill(dtbl);
                age_txtbox.Text = dtbl.Rows[0][2].ToString();
                name_txtbox.Text = dtbl.Rows[0][1].ToString();
                if (radioButton1.Checked)
                {
                    height_txtbox.Text = Convert.ToDouble(dtbl.Rows[0][3]).ToString("0.00") + " cm";
                    weight_txtbox.Text = Convert.ToDouble(dtbl.Rows[0][4]).ToString("0.00") + " kg"; 
                }
                if (radioButton2.Checked)
                {
                    height_txtbox.Text = Convert.ToDouble(dtbl.Rows[0][5]).ToString("0.00") + " ft";
                    weight_txtbox.Text = Convert.ToDouble(dtbl.Rows[0][6]).ToString("0.00") + " lbs";
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide(); Form2 home = new Form2(); home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(56, 67, 88);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Red;
        }

        private void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }
        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Form6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Form6_Load(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form6_Load(sender, e);
        }

        private void changePass_btn_Click(object sender, EventArgs e)
        {
            current_label.Visible = true;
            current_txtbox.Visible = true;
            new_label.Visible = true;
            new_txtbox.Visible = true;
            re_txtbox.Visible = true;
            type_label.Visible = true;
            confirm_btn.Visible = true;
            cancel_btn.Visible = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            current_label.Visible = false;
            current_txtbox.Visible = false;
            new_label.Visible = false;
            new_txtbox.Visible = false;
            re_txtbox.Visible = false;
            type_label.Visible = false;
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if(current_txtbox.Text == "" && new_txtbox.Text == "" && re_txtbox.Text == "")
            {
                MessageBox.Show("Fields are empty.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(current_txtbox.Text != pass_txtbox.Text)
            {
                MessageBox.Show("Current password is incorrect", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else if (new_txtbox.Text != re_txtbox.Text)
            {
                MessageBox.Show("Passwords do not match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (con = new OleDbConnection(staticClass.connString))
                {
                    try
                    {
                        string query = "Update [User] Set [Password]=@pass where Username = @user";
                        cmd = new OleDbCommand(query, con);
                        cmd.Parameters.AddWithValue("@pass", re_txtbox.Text);
                        cmd.Parameters.AddWithValue("@user", Form1.user);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Password has been successfully updated!", "Change Password", MessageBoxButtons.OK);
                        cancel_btn_Click(sender, e);
                        Form6_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("An error has occured. You may try again or contact the developer.","Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
