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
    public partial class Update : Form
    {
        OleDbDataAdapter bridge = new OleDbDataAdapter();
        OleDbConnection con;
        OleDbCommand cmd;
        Monitor monitor = (Monitor)Application.OpenForms["Monitor"];
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(day.Value!=0 && weight.Value < 30)
            {
                MessageBox.Show("Details were not filled properly!");
            }
            else
            {
                using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
                {
                    try
                    {
                        double weightKg=0, weightLbs=0,heightCm=0,heightFt=0,bmi=0;
                        string hold = "",temp="";
                        if (kg.Checked)
                        {
                            weightKg = Convert.ToDouble(weight.Value);
                            hold= (weightKg * 2.20462262).ToString("0.00");
                            weightLbs = Convert.ToDouble(hold);
                        }
                        else
                        {
                            weightLbs = Convert.ToDouble(weight.Value);
                            hold = (weightLbs * 0.45359237).ToString("0.00");
                            weightKg = Convert.ToDouble(hold);
                        }
                        if (cm.Checked)
                        {
                            heightCm = Convert.ToDouble(height.Value);
                            temp = (heightCm * 0.0328084).ToString("0.00");
                            heightFt = Convert.ToDouble(temp);
                        }
                        else
                        {
                            heightFt = Convert.ToDouble(height.Value);
                            temp = (heightFt * 30.48).ToString("0.00");
                            heightCm = Convert.ToDouble(temp);
                        }

                        hold = (weightKg / Math.Pow(heightCm * 0.01, 2.0)).ToString("0.00");
                        bmi = Convert.ToDouble(hold);

                        string query = "Select * from user_progress Where Username ='" + Form1.user + "' and Day = '" + day.Value.ToString() + "'"; //Traverses database and checks for info
                        bridge = new OleDbDataAdapter(query, con);
                        DataTable dtbl = new DataTable();
                        bridge.Fill(dtbl);
                        if (dtbl.Rows.Count > 0)
                        {
                            Console.Beep();
                            MessageBox.Show("Day number has already been recorded.");
                        }
                        else
                        {
                            query = "Insert into user_progress (Username, HeightCm,WeightKg,HeightFt,WeightLbs,[Day], BMI) values (@user,@cm,@kg,@ft,@lbs,@day,@bmi)";
                            cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@user", Form1.user);
                            cmd.Parameters.AddWithValue("@cm", heightCm);
                            cmd.Parameters.AddWithValue("@kg", weightKg);
                            cmd.Parameters.AddWithValue("@ft", heightFt);
                            cmd.Parameters.AddWithValue("@lbs", weightLbs);
                            cmd.Parameters.AddWithValue("@day", day.Value.ToString());
                            cmd.Parameters.AddWithValue("@bmi", bmi);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            query = "Update Account Set WeightKg = @kg, WeightLbs = @lbs, HeightCm = @cm, HeightFt=@ft where Username = @user";
                            cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@kg", weightKg);
                            cmd.Parameters.AddWithValue("@lbs", weightLbs);
                            cmd.Parameters.AddWithValue("@cm", heightCm);
                            cmd.Parameters.AddWithValue("@ft", heightFt);
                            cmd.Parameters.AddWithValue("@user", Form1.user);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Progress has been successfully recorded!");
                            monitor.refresh_btn_Click(sender, e);
                        }
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show("An error has occured. You may contact your developer or try again." + E, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Jet OLEDB:Database Password=project;"))
            {
                try
                {
                    string query = "Select * from user_progress Where Username ='" + Form1.user + "'"; //Traverses database and checks for info
                    bridge = new OleDbDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    bridge.Fill(dtbl);
                    day.Value = Convert.ToDecimal(dtbl.Rows[dtbl.Rows.Count - 1][5])+1;
                    if (kg.Checked)
                        weight.Value = Convert.ToDecimal(dtbl.Rows[dtbl.Rows.Count - 1][2]);
                    else
                        weight.Value = Convert.ToDecimal(dtbl.Rows[dtbl.Rows.Count - 1][4]);
                    if (cm.Checked)
                        height.Value = Convert.ToDecimal(dtbl.Rows[dtbl.Rows.Count - 1][1]);
                    else
                        height.Value = Convert.ToDecimal(dtbl.Rows[dtbl.Rows.Count - 1][3]);
                }
                catch (Exception E)
                {
                    MessageBox.Show("An error has occured. Please contact your developer."+E, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
