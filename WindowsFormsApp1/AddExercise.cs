using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddExercise : Form
    {
        internal protected OleDbDataAdapter bridge;
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;
        internal protected DataSet ds;
        internal protected bool mouseDown;
        internal protected Point lastLocation;
        public static string combo = "", exer = "",user="",equip="",times="", reps = "";
        public static decimal sets = 0;
        bool btn_state = false, muscle=false, level = false, target = false,mouse=false;
        private void filter_btn_Click(object sender, EventArgs e)
        {
            if (mouse == false)
            {
                muscleGroup_filter.Visible = true;
                target_filter.Visible = true;
                level_filter.Visible = true;
                muscle_Lbl.Visible = true;
                target_lbl.Visible = true;
                lvl_lbl.Visible = true;
                mouse = true;
            }
            else
            {
                muscleGroup_filter.Visible = false;
                target_filter.Visible = false;
                level_filter.Visible = false;
                muscle_Lbl.Visible = false;
                target_lbl.Visible = false;
                lvl_lbl.Visible = false;
                mouse = false;
            }
        }

        private void none_btn_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (none_btn.Checked && btn_state == true)
            {
                none_btn.Checked = false;
                btn_state = false;
                equip_txt.Text = "";
                equipWeight.Enabled = true;
                kg.Enabled = true;
                lbs.Enabled = true;
                equip_txt.Enabled = true;
            }
            else
            {
                none_btn.Checked = true;
                btn_state = true;
                equip_txt.Text = "N/A";
                equipWeight.Enabled = false;
                kg.Enabled = false;
                lbs.Enabled = false;
                equip_txt.Enabled = false;
            }
        }

        private void filterSearch(object sender, EventArgs e)
        {
            exer_name.Items.Clear(); 
            string queryMain="", group,lev,targ;
            group = muscleGroup_filter.Text;
            lev = level_filter.Text;
            targ = target_filter.Text;

            if (muscleGroup_filter.Text == "No Filter")
                muscle = false;
            else
                muscle = true;
            if (level_filter.Text == "No Filter")
                level = false;
            else
                level = true;
            if (target_filter.Text == "No Filter")
                target = false;
            else
                target = true;

            if (group == "No Filter" && lev == "No Filter" && targ == "No Filter") //Any
                queryMain = "Select Exercise from Exercise";
            else if (muscle == true && level == false && target == false)// Specific  Muscles
                queryMain = "Select Exercise from Exercise where MuscleGroup = '" + group + "'";
            else if (muscle == false && level == true && target == false)//Specific level
                queryMain = "Select Exercise from Exercise where Level = '" + lev + "'";
            else if (muscle == false && level == false && target == true)//Specific target
                queryMain = "Select Exercise from Exercise where Target = '" + targ + "'";
            else if (muscle == true && level == true && target == false)//Specific muscle and level
                queryMain = "Select Exercise from Exercise where MuscleGroup = '" + group + "' and Level = '" + lev + "'";
            else if (muscle == true && level == false && target == true)//Specific muscle and target
                queryMain = "Select Exercise from Exercise where MuscleGroup = '" + group + "' and Target = '" + targ + "'";
            else if (muscle == false && level == true && target == true)//Specific level and target
                queryMain = "Select Exercise from Exercise where Level = '" + lev + "' and Target = '" + targ + "'";
            else if (muscle == true && level == true && target == true) //True all
                queryMain = "Select Exercise from Exercise where MuscleGroup = '" + group + "' and Level = '" + lev + "' and Target ='" + targ + "'";
            
            using (con = new OleDbConnection(staticClass.connString))
            {
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = queryMain;
                OleDbDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    exer_name.Items.Add(reader["Exercise"].ToString()); //Lists all of the exercises in the comboBox
                }
            }
        }

        private void filter_load(object sender, EventArgs e)
        {
            muscleGroup_filter.Items.Add("No Filter");
            level_filter.Items.Add("No Filter");
            level_filter.Items.Add("Beginner");
            level_filter.Items.Add("Intermediate");
            level_filter.Items.Add("Advanced");
            target_filter.Items.Add("No Filter");
            target_filter.Items.Add("Upper");
            target_filter.Items.Add("Core");
            target_filter.Items.Add("Lower");
            using (con = new OleDbConnection(staticClass.connString))
            {
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "Select DISTINCT MuscleGroup from Exercise";
                cmd.CommandText = query;

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    muscleGroup_filter.Items.Add(reader["MuscleGroup"].ToString()); //Lists all of the users' name in the comboBox
                }
            }
        }
        private void AddExercise_Load(object sender, EventArgs e)
        {
            if (Form2.accType == "Member")
            {
                title_lbl.Location = new Point(95, 50);
                subtitle_lbl.Location = new Point(77, 86);
                user_lbl.Visible = false; userlist.Visible = false;
                exer_lbl.Location = new Point(14, 161); exer_name.Location = new Point(112, 161);
                set_lbl.Location = new Point(14, 192); set_value.Location = new Point(112, 192);
                reps_lbl.Location = new Point(14, 226); rep_text.Location = new Point(149, 226);
                equip_lbl.Location = new Point(14, 256); equip_txt.Location = new Point(112, 256); none_btn.Location = new Point(200, 258);
                add_btn.Location = new Point(128, 312);
            }

            using (con = new OleDbConnection(staticClass.connString))
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
                    reader.Close();
                    query = "Select Exercise from Exercise";
                    cmd.CommandText = query;

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exer_name.Items.Add(reader["Exercise"].ToString()); //Lists all of the users' name in the comboBox
                    }

                    if (Form2.accType == "Member")
                        userlist.Text = Form1.user;
                    else
                        userlist.SelectedItem = userlist.Items[Edit.index].ToString();
                }
                catch
                {
                    MessageBox.Show("An error has occured. You may try again or contact the developer." );
                }
            }
        }

        public AddExercise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (exer_name.SelectedItem.ToString() != null) 
                {
                    if ((equipWeight.Value == 0 || equip_txt.Text == "") && !none_btn.Checked)
                        MessageBox.Show("Add Exercise failed.Please input equipment details properly", "Add Exercise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (Form2.accType != "Member")
                            user = userlist.SelectedItem.ToString();
                        else
                            user = Form1.user;
                        exer = exer_name.SelectedItem.ToString();
                        sets = set_value.Value;
                        if (none_btn.Checked)
                            equip = equip_txt.Text;
                        else
                        {
                            string unit = "";
                            if (kg.Checked)
                                unit = " kg";
                            else
                                unit = " lbs";
                            equip = equip_txt.Text + " - " + equipWeight.Value.ToString() + unit;
                        }
                        if (rep.Checked)
                        {
                            times = "N/A";
                            reps = rep_text.Value.ToString();
                        }
                        else
                        {
                            reps = "N/A";
                            times = rep_text.Value.ToString() + " seconds";
                        }
                        Edit edit = (Edit)Application.OpenForms["Edit"];
                        edit.add_Click(sender, e, user);
                        Close();
                        edit.Routine();
                        MessageBox.Show("Exercise has been successfully added!");
                    }
                }
                else
                    MessageBox.Show("Add Exercise failed. Please try again!", "Add Exercise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("There has been an error in adding. Please ensure the fields are filled correctly.", "Add Exercise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}