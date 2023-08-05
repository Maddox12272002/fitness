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
    public partial class Execute : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        int i = 0;
        public Execute()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exeute_Load(object sender, EventArgs e)
        {
            try
            {
                using (con = new OleDbConnection(staticClass.connString))
                {
                    string query = "Select * from Routine Where username ='" + Form1.user + "'";
                    bridge = new OleDbDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    con.Open();
                    bridge.Fill(dtbl);
                    if (dtbl.Rows.Count > i)
                    {
                        exercise_lbl.Text = dtbl.Rows[i][1].ToString();
                        equipment_lbl.Text = "Equipment - "+dtbl.Rows[i][5].ToString();
                        set_lbl.Text = "Sets - "+ dtbl.Rows[i][2].ToString();
                        rep_lbl.Text = "Reps - "+dtbl.Rows[i][3].ToString();
                        i++;
                    }
                    con.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("An error has occured. You may contact your developer or try again!\n"+E, "Execute Exercise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
