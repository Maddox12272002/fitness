using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            if (regisUser.Text != "" && regisPass.Text != "")
            {
                using (con = new OleDbConnection(staticClass.connString))
                {
                    //Make a Query, mangutana ra ta sa database
                    string query = "Select * from [User] Where Username ='" + regisUser.Text + "'";
                    //Create an object that will send query through our connection to the sql server
                    bridge = new OleDbDataAdapter(query, con);
                    //Datable to put matching login info
                    DataTable dtbl = new DataTable();
                    //Fill the table with matching info from textbox 1 and 2 and user and pass from database
                    bridge.Fill(dtbl);
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
                            string acc = "";
                            if (trainer_btn.Checked)
                                acc = "Trainer";
                            else
                                acc = "Member";
                            byte[] imageData = null;
                            FileStream fstream = new FileStream("Default.jpg", FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fstream);
                            imageData = br.ReadBytes((int)fstream.Length);

                            query = "Insert into [User] (Username, [Password],Profile,AccountType) values (@user,@pass,@img,@acc)";
                            cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@user", regisUser.Text);
                            cmd.Parameters.AddWithValue("@pass", regisPass.Text);
                            cmd.Parameters.AddWithValue("@img", imageData);
                            cmd.Parameters.AddWithValue("@acc", acc);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            DateTime date = DateTime.Parse(Register2.bday);
                            query = "Insert into Client (Username, clientName, clientAge, HeightCm,WeightKg,HeightFt,WeightLbs,Birthday) values (@user,@name,@age,@cm,@kg,@ft,@lbs,@bd)";   
                            cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@user", regisUser.Text);
                            cmd.Parameters.AddWithValue("@name", Register2.name);
                            cmd.Parameters.AddWithValue("@age", Register2.age);
                            cmd.Parameters.AddWithValue("@cm", Register2.heightCm);
                            cmd.Parameters.AddWithValue("@kg", Register2.weightKg);
                            cmd.Parameters.AddWithValue("@ft", Register2.heightFt);
                            cmd.Parameters.AddWithValue("@lbs", Register2.weightLbs);
                            cmd.Parameters.AddWithValue("@bd", date);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            query = "Insert into user_progress (Username, [Day], HeightCm,WeightKg,HeightFt,WeightLbs,BMI) values (@user,@day,@cm,@kg,@ft,@lbs,@bmi)";
                            cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@user", regisUser.Text);
                            cmd.Parameters.AddWithValue("@day", "1");
                            cmd.Parameters.AddWithValue("@cm", Register2.heightCm);
                            cmd.Parameters.AddWithValue("@kg", Register2.weightKg);
                            cmd.Parameters.AddWithValue("@ft", Register2.heightFt);
                            cmd.Parameters.AddWithValue("@lbs", Register2.weightLbs);
                            cmd.Parameters.AddWithValue("@bmi", Register2.bmi);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            Register2.regis = false;
                            MessageBox.Show("Registration Successful!");
                            Hide(); start.Show();
                        }
                        catch(Exception E) { MessageBox.Show("An error has occured. You may try again or contact the developer."+E); }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide the necessary details!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Register2 register = new Register2();  
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
    }
}
