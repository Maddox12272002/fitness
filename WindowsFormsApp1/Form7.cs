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

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        internal protected OleDbDataAdapter bridge;
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;

        public Form7()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb");
            load();
        }
        public void load()
        {
            string query = "Select * from [User]";
            bridge = new OleDbDataAdapter(query, con);
            ds = new DataSet();
            con.Open();
            bridge.Fill(ds, "[User]");
            dataGridView1.DataSource = ds.Tables["[User]"];
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); Form1 start = new Form1();
            start.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
            string query = "Delete From [User] where Username = @user";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@user", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
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
