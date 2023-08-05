using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Monitor : Form
    {
        internal protected OleDbDataAdapter bridge = new OleDbDataAdapter();
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd = new OleDbCommand();
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;
        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            weight_lbl.BackColor = Color.FromArgb(182, 26, 40); ; label2.Text = "w";
            height_lbl.BackColor = Color.Transparent;
            bmi_lbl.BackColor = Color.Transparent;

            if (Form2.accType == "Member")
            {
                user_lbl.Visible = false;
                userlist.Visible = false;
            }
            else
            {
                weightUpdate.Visible = false;
                using (con = new OleDbConnection(staticClass.connString))
                {
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        string query = "Select Username from Client where Trainer = '" + Form2.username + "'";
                        cmd.CommandText = query;
                        OleDbDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            userlist.Items.Add(reader["Username"].ToString()); //Lists all of the users' name in the comboBox
                        }
                        userlist.Text = userlist.Items[0].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("No members are training under you as of the moment");
                    }
                }
            }
            refresh_btn_Click(sender, e);
        }        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 home = new Form2(); home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(56, 67, 88);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }
        private void weightUpdate_Click(object sender, EventArgs e)
        {
            Update upweight = new Update();
            upweight.Show();
        }

        internal void refresh_btn_Click(object sender, EventArgs e)
        {
            if (label2.Text == "b")
            {
                bmi_lbl_Click(sender, e);
            }
            else if (label2.Text == "h")
            {
                height_lbl_Click(sender, e);
            }
            else
            {
                using (con = new OleDbConnection(staticClass.connString))
                {
                    string query = "";
                    if (Form2.accType == "Member")
                        query = "Select Day,WeightKg,WeightLbs from user_progress Where username ='" + Form1.user + "'";
                    else
                        query = "Select Day,WeightKg,WeightLbs from user_progress Where username ='" + userlist.Text + "'";
                    bridge = new OleDbDataAdapter(query, con);
                    ds = new DataSet();
                    con.Open();
                    bridge.Fill(ds, "Weight");
                    monitor_table.DataSource = ds.Tables["Weight"]; //Puts the content in the dataGrid

                    chart1.Series[0].XValueMember = "Day"; //Puts the content in the chart
                    chart1.Series[0].YValueMembers = "WeightKg";
                    chart1.DataSource = ds;
                    chart1.DataBind();
                }
            }
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

        private void height_lbl_Click(object sender, EventArgs e)
        {
            height_lbl.BackColor = Color.FromArgb(182, 26, 40);
            weight_lbl.BackColor = Color.Transparent;
            bmi_lbl.BackColor = Color.Transparent;
            y_label.Visible = true;
            y_label.Text = "CM";
            label2.Text = "h";
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "";
                if (Form2.accType == "Member")
                    query = "Select Day,HeightCm,HeightFt from user_progress Where username ='" + Form1.user + "'";
                else
                    query = "Select Day,HeightCm,HeightFt from user_progress Where username ='" + userlist.Text + "'";
                
                bridge = new OleDbDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                ds = new DataSet();
                con.Open();
                bridge.Fill(ds, "Weight");
                monitor_table.DataSource = ds.Tables["Weight"];

                chart1.Series[0].Name = "Height";
                chart1.Series[0].XValueMember = "Day";
                chart1.Series[0].YValueMembers = "HeightCm";
                chart1.DataSource = ds;
                chart1.DataBind();
            }
        }

        private void weight_lbl_Click(object sender, EventArgs e)
        {
            height_lbl.BackColor = Color.Transparent;
            bmi_lbl.BackColor = Color.Transparent;
            y_label.Visible = true;
            y_label.Text = "KG";
            chart1.Series[0].Name = "Weight";
            label2.Text = "w";
            refresh_btn_Click(sender, e);
        }

        private void bmi_lbl_Click(object sender, EventArgs e)
        {
            label2.Text = "b";
            weight_lbl.BackColor = Color.Transparent;
            bmi_lbl.BackColor = Color.FromArgb(182, 26, 40);
            height_lbl.BackColor = Color.Transparent;
            y_label.Visible = false;
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "";
                if (Form2.accType == "Member")
                    query = "Select Day,BMI from user_progress Where username ='" + Form1.user + "'";
                else
                    query = "Select Day,BMI from user_progress Where username ='" + userlist.Text+ "'";
                bridge = new OleDbDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                ds = new DataSet();
                con.Open();
                bridge.Fill(ds, "Weight");
                monitor_table.DataSource = ds.Tables["Weight"];

                chart1.Series[0].Name = "BMI";
                chart1.Series[0].XValueMember = "Day";
                chart1.Series[0].YValueMembers = "BMI";
                chart1.DataSource = ds;
                chart1.DataBind();
            }
        }

        private void weight_lbl_MouseEnter(object sender, EventArgs e)
        {
            weight_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void height_lbl_MouseEnter(object sender, EventArgs e)
        {
            height_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void bmi_lbl_MouseEnter(object sender, EventArgs e)
        {
            bmi_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void leave(object sender, EventArgs e)
        {
            if (label2.Text == "w")
            {
                height_lbl.BackColor = Color.Transparent;
                bmi_lbl.BackColor = Color.Transparent;
            }
            else if (label2.Text == "b")
            {
                weight_lbl.BackColor = Color.Transparent;
                height_lbl.BackColor = Color.Transparent;
            }
            else if (label2.Text =="h")
            {
                bmi_lbl.BackColor = Color.Transparent;
                weight_lbl.BackColor = Color.Transparent;
            }
        }
    }
}