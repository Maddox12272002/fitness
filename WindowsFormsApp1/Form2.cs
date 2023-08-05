using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 start = new Form1();
        internal protected OleDbDataAdapter bridge = new OleDbDataAdapter();
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;
        internal static string accType= "", accName= "",trainer="",username="";

        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Hide(); start.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise();
            Hide(); exercise.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            Hide(); setting.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            Hide(); edit.Show();
        }
        private new void MouseLeave(object sender, EventArgs e)
        {
            logout_lbl.BackColor = Color.Transparent;
            exercise_lbl.BackColor = Color.Transparent;
            setting_lbl.BackColor = Color.Transparent;
            edit_lbl.BackColor = Color.Transparent;
            monitor_lbl.BackColor = Color.Transparent;  
        }

        private new void MouseEnter(object sender, EventArgs e)
        {
            logout_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "Select AccountType from [User] Where username ='" + Form1.user + "'";
                bridge = new OleDbDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                bridge.Fill(dtbl);
                accType = (string)dtbl.Rows[0][0];
                if (accType != "Member")
                {
                    exercise_lbl.Visible = false;
                    edit_lbl.Location = new Point(28, 43);
                    monitor_lbl.Location = new Point(28, 99);
                    setting_lbl.Location = new Point(28, 154);
                    logout_lbl.Location = new Point(28, 211);
                }
                else if (accType == "Member" && trainer != "")
                {
                    edit_lbl.Visible = false;
                    exercise_lbl.Location = new Point(28, 43);
                    monitor_lbl.Location = new Point(28, 99);
                    setting_lbl.Location = new Point(28, 154);
                    logout_lbl.Location = new Point(28, 211);
                }


                query = "Select * from Client Where username ='" + Form1.user + "'";
                bridge = new OleDbDataAdapter(query, con);
                dtbl = new DataTable();
                bridge.Fill(dtbl);

                if (dtbl.Rows[0][9].ToString() == "" && accType!="Trainer" && TrainerSelect.done == true)
                {
                    TrainerSelect trainer = new TrainerSelect();
                    Close(); trainer.Show();
                }
                accName = name_lbl.Text = dtbl.Rows[0][1].ToString();
                age_lbl.Text = dtbl.Rows[0][2].ToString();
                trainer = dtbl.Rows[0][9].ToString();
                username = dtbl.Rows[0][0].ToString();
                double bmi = Convert.ToDouble(dtbl.Rows[0][4]) / (Math.Pow((Convert.ToDouble(dtbl.Rows[0][3]) * 0.01), 2.0));
                bmi_lbl.Text = bmi.ToString("0.0");
                if (bmi < 18.50)
                    class_lbl.Text = "Underweight";
                else if (bmi < 25 && bmi >= 18.50)
                    class_lbl.Text = "Normal";
                else if (bmi > 25 && bmi < 30)
                    class_lbl.Text = "Overweight";
                else
                    class_lbl.Text = "Obese";
                try
                {
                    con.Open();
                    byte[] ImageByte = null;
                    MemoryStream MemStream = null;
                    query = "Select Profile from [User] Where username ='" + Form1.user + "'";
                    cmd = new OleDbCommand(query, con);
                    ImageByte = (byte[])cmd.ExecuteScalar();
                    MemStream = new MemoryStream(ImageByte);
                    profile.Image = Image.FromStream(MemStream);
                }
                catch
                {
                    MessageBox.Show("Welcome to the app! Choose a profile picture");
                }
            }
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            exercise_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            edit_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            setting_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }
         
        private void label12_Click(object sender, EventArgs e)
        {
            Hide(); Monitor monitor = new Monitor(); monitor.Show();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            monitor_lbl.BackColor = Color.FromArgb(182, 26, 40);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pfp.Visible = true;
        }

        private void pfp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pfp.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(56, 67, 88);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Red;
        }

        private void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg,  *.png)|*.jpg; *.jpeg;  *.png";
                openFileDialog.RestoreDirectory = true;
                string file = Path.GetFileName(openFileDialog.FileName);
                string dest = Path.Combine(Application.StartupPath, "ProfilePictures", file);
                openFileDialog.FileName = "Image file name";
                openFileDialog.Title = "Choose an image...";
                openFileDialog.AddExtension = true;
                openFileDialog.FilterIndex = 0;
                openFileDialog.Multiselect = false;
                openFileDialog.ValidateNames = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    profile.Image = Image.FromFile(openFileDialog.FileName);
                    string path = openFileDialog.FileName;
                    img_path.Text = path;
                }

                File.Copy(openFileDialog.FileName, dest, true);

                using (con = new OleDbConnection(staticClass.connString))
                {
                    byte[] imageData = null;
                    FileStream fstream = new FileStream(img_path.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageData = br.ReadBytes((int)fstream.Length);

                    string query = "Update [User] Set Profile = @pfp where Username = @user";
                    cmd = new OleDbCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@pfp", imageData);
                    cmd.Parameters.AddWithValue("@user", Form1.user);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error! " + E.Message);
            }
        }
    }
}