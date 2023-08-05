using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        internal protected OleDbDataAdapter bridge;
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;

        public Admin()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "SELECT User.Username AS Username, Trainer.trainerName AS Name, Trainer.trainerAge AS Age, Trainer.BMI\r\nFROM [User] INNER JOIN (Client INNER JOIN Trainer ON Client.Trainer = Trainer.Username) ON User.Username = Trainer.Username;\r\n";
                bridge = new OleDbDataAdapter(query, con);
                ds = new DataSet();
                con.Open();
                bridge.Fill(ds, "[User]");
                dataGridView1.DataSource = ds.Tables["[User]"];

                dataGridView1.ClearSelection();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            regisUser.Visible = true;
            regisPass.Visible = true;
            name.Visible = true;
            edad.Visible = true;
            button4.Visible = true;
            cancel_btn.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); Form1 start = new Form1();
            start.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "Delete From [User] where Username = @user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string query1 = "Delete From Account where Username = @user";
                cmd = new OleDbCommand(query1, con);
                cmd.Parameters.AddWithValue("@user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                query = "Delete From user_progress where Username = @user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                query = "Delete From Routine where Username = @user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();

            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "SELECT Username, clientName AS Name FROM Client WHERE Trainer = @train";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@train", row.Cells[0].Value.ToString());
                bridge = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                bridge.Fill(ds, "Client");
                dataGridView2.DataSource = ds.Tables["Client"];
                dataGridView2.ClearSelection();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(staticClass.connString))
            {
                string query = "Insert into Trainer (Username, [Name], [Age]) values (@user,@name, @age)";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", regisUser.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@age", edad.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                byte[] imageData = null;
                FileStream fstream = new FileStream("Default.jpg", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageData = br.ReadBytes((int)fstream.Length);

                query = "Insert into [User] (Username, [Password],Profile,AccountType) values (@user,@pass,@img,@acc)";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user", regisUser.Text);
                cmd.Parameters.AddWithValue("@pass", regisPass.Text);
                cmd.Parameters.AddWithValue("@img", imageData);
                cmd.Parameters.AddWithValue("@acc", "Trainer");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Account has been added!");
            cancel_btn_Click(sender, e);
            load();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            regisUser.Visible = false;
            regisPass.Visible = false;
            name.Visible = false;
            edad.Visible = false;
            button4.Visible = false;
            cancel_btn.Visible = false;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userList.SelectedIndex == 0)
            {
                load();
                dataGridView2.Visible = true;
                clienttxt.Visible = true;
            }
            else
            {

                using (con = new OleDbConnection(staticClass.connString))
                {
                    string query = "SELECT User.Username AS Username, Client.clientName AS Name, Client.clientAge AS Age, Client.HeightCm, Client.WeightKg, Client.HeightFt, Client.WeightLbs, Client.BMI, Client.Trainer\r\nFROM [User] INNER JOIN Client ON User.Username = Client.Username;\r\n";
                    bridge = new OleDbDataAdapter(query, con);
                    ds = new DataSet();
                    con.Open();
                    bridge.Fill(ds, "[User]");
                    dataGridView1.DataSource = ds.Tables["[User]"];

                    dataGridView1.Columns[0].Name = "Username";
                    dataGridView1.Columns[1].Name = "Name";
                    dataGridView1.Columns[2].Name = "Age";
                    dataGridView1.ClearSelection();

                    dataGridView2.Visible = false;
                    clienttxt.Visible = false;
                }
            }
        }
    }
}
