using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register2 : Form
    {
        public static string name = "",bday="";
        public static decimal age = 0;
        public static double weightKg = 0, weightLbs = 0, heightCm = 0, heightFt = 0,bmi=0;
        private bool mouseDown;
        private Point lastLocation;
        string hold = "",temp="";
        public static bool regis;

        public Register2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            Hide(); start.Show();
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

        private void Register2_Load(object sender, EventArgs e)
        {
            if(regis)
            {
                regisUser.Text = name;
                birthdate.Value = DateTime.Parse(Register2.bday);
                heightval.Value = Convert.ToDecimal(heightCm);
                weightval.Value = Convert.ToDecimal(weightKg);
            }
        }

        private void state_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (regisUser.Text != "" && weightval.Value!=0 && heightval.Value !=0)
            {
                name = regisUser.Text;
                age = DateTime.Today.Year - birthdate.Value.Year;
                bday = birthdate.Value.ToShortDateString();
                if (cm.Checked)
                {
                    heightCm = Convert.ToDouble(heightval.Value);
                    temp = (heightCm * 0.0328084).ToString("0.00");
                    heightFt = Convert.ToDouble(temp);
                }
                else
                {
                    heightFt = Convert.ToDouble(heightval.Value);
                    temp = (heightFt * 30.48).ToString("0.00");
                    heightCm = Convert.ToDouble(temp);
                }
                if (kg.Checked)
                {
                    weightKg = Convert.ToDouble(weightval.Value);
                    hold = (weightKg * 2.20462262).ToString("0.00");
                    weightLbs = Convert.ToDouble(hold);
                }
                else
                {
                    weightLbs = Convert.ToDouble(weightval.Value);
                    hold = (weightLbs * 0.45359237).ToString("0.00");
                    weightKg = Convert.ToDouble(hold);
                }
                hold = (weightKg / Math.Pow(heightCm*0.01, 2.0)).ToString("0.00");
                bmi = Convert.ToDouble(hold);
                Register register = new Register();
                Hide(); register.Show(); regis = true;
            }
            else if (age < 15 && regisUser.Text!="" && age !=0)
                MessageBox.Show("Age inputted is below the allowed user age.");
            else
                MessageBox.Show("One or more details are not filled properly.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
