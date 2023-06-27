namespace WindowsFormsApp1
{
    partial class AddExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExercise));
            this.set_lbl = new System.Windows.Forms.Label();
            this.exer_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.subtitle_lbl = new System.Windows.Forms.Label();
            this.set_value = new System.Windows.Forms.NumericUpDown();
            this.reps_lbl = new System.Windows.Forms.Label();
            this.rep_text = new System.Windows.Forms.NumericUpDown();
            this.user_lbl = new System.Windows.Forms.Label();
            this.userlist = new System.Windows.Forms.ComboBox();
            this.equip_lbl = new System.Windows.Forms.Label();
            this.equip_txt = new System.Windows.Forms.TextBox();
            this.none_btn = new System.Windows.Forms.RadioButton();
            this.exer_name = new System.Windows.Forms.ComboBox();
            this.filter_btn = new System.Windows.Forms.PictureBox();
            this.muscleGroup_filter = new System.Windows.Forms.ComboBox();
            this.level_filter = new System.Windows.Forms.ComboBox();
            this.target_filter = new System.Windows.Forms.ComboBox();
            this.muscle_Lbl = new System.Windows.Forms.Label();
            this.lvl_lbl = new System.Windows.Forms.Label();
            this.target_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.RadioButton();
            this.rep = new System.Windows.Forms.RadioButton();
            this.equpWeight_lbl = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.RadioButton();
            this.kg = new System.Windows.Forms.RadioButton();
            this.weightval = new System.Windows.Forms.NumericUpDown();
            this.equipWeight = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.set_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_btn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipWeight)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // set_lbl
            // 
            this.set_lbl.BackColor = System.Drawing.Color.Transparent;
            this.set_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_lbl.ForeColor = System.Drawing.Color.White;
            this.set_lbl.Location = new System.Drawing.Point(14, 192);
            this.set_lbl.Name = "set_lbl";
            this.set_lbl.Size = new System.Drawing.Size(96, 19);
            this.set_lbl.TabIndex = 10;
            this.set_lbl.Text = "Number of Sets";
            // 
            // exer_lbl
            // 
            this.exer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.exer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exer_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exer_lbl.Location = new System.Drawing.Point(14, 161);
            this.exer_lbl.Name = "exer_lbl";
            this.exer_lbl.Size = new System.Drawing.Size(96, 19);
            this.exer_lbl.TabIndex = 9;
            this.exer_lbl.Text = "Exercise Name";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.title_lbl.Location = new System.Drawing.Point(103, 27);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(151, 23);
            this.title_lbl.TabIndex = 23;
            this.title_lbl.Text = "Add Exercise";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Location = new System.Drawing.Point(128, 312);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(88, 23);
            this.add_btn.TabIndex = 25;
            this.add_btn.Text = "Add Exercise";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtitle_lbl
            // 
            this.subtitle_lbl.AutoSize = true;
            this.subtitle_lbl.BackColor = System.Drawing.Color.Transparent;
            this.subtitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.subtitle_lbl.Location = new System.Drawing.Point(85, 63);
            this.subtitle_lbl.Name = "subtitle_lbl";
            this.subtitle_lbl.Size = new System.Drawing.Size(187, 13);
            this.subtitle_lbl.TabIndex = 27;
            this.subtitle_lbl.Text = "Select which exercise you wish to add";
            // 
            // set_value
            // 
            this.set_value.Location = new System.Drawing.Point(149, 192);
            this.set_value.Name = "set_value";
            this.set_value.Size = new System.Drawing.Size(49, 20);
            this.set_value.TabIndex = 28;
            this.set_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.set_value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reps_lbl
            // 
            this.reps_lbl.BackColor = System.Drawing.Color.Transparent;
            this.reps_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reps_lbl.ForeColor = System.Drawing.Color.White;
            this.reps_lbl.Location = new System.Drawing.Point(14, 226);
            this.reps_lbl.Name = "reps_lbl";
            this.reps_lbl.Size = new System.Drawing.Size(133, 19);
            this.reps_lbl.TabIndex = 29;
            this.reps_lbl.Text = "Number of Reps/Time";
            // 
            // rep_text
            // 
            this.rep_text.Location = new System.Drawing.Point(149, 226);
            this.rep_text.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.rep_text.Name = "rep_text";
            this.rep_text.Size = new System.Drawing.Size(49, 20);
            this.rep_text.TabIndex = 30;
            this.rep_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rep_text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // user_lbl
            // 
            this.user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.user_lbl.Location = new System.Drawing.Point(14, 94);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(96, 19);
            this.user_lbl.TabIndex = 31;
            this.user_lbl.Text = "User Recepient";
            // 
            // userlist
            // 
            this.userlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userlist.FormattingEnabled = true;
            this.userlist.Location = new System.Drawing.Point(112, 94);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(92, 21);
            this.userlist.TabIndex = 52;
            // 
            // equip_lbl
            // 
            this.equip_lbl.BackColor = System.Drawing.Color.Transparent;
            this.equip_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equip_lbl.ForeColor = System.Drawing.Color.White;
            this.equip_lbl.Location = new System.Drawing.Point(14, 256);
            this.equip_lbl.Name = "equip_lbl";
            this.equip_lbl.Size = new System.Drawing.Size(106, 19);
            this.equip_lbl.TabIndex = 53;
            this.equip_lbl.Text = "Equipment";
            // 
            // equip_txt
            // 
            this.equip_txt.Location = new System.Drawing.Point(149, 256);
            this.equip_txt.Name = "equip_txt";
            this.equip_txt.Size = new System.Drawing.Size(86, 20);
            this.equip_txt.TabIndex = 54;
            // 
            // none_btn
            // 
            this.none_btn.AutoSize = true;
            this.none_btn.BackColor = System.Drawing.Color.Transparent;
            this.none_btn.ForeColor = System.Drawing.Color.White;
            this.none_btn.Location = new System.Drawing.Point(237, 258);
            this.none_btn.Name = "none_btn";
            this.none_btn.Size = new System.Drawing.Size(51, 17);
            this.none_btn.TabIndex = 55;
            this.none_btn.Text = "None";
            this.none_btn.UseVisualStyleBackColor = false;
            this.none_btn.Click += new System.EventHandler(this.none_btn_MouseCaptureChanged);
            // 
            // exer_name
            // 
            this.exer_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.exer_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.exer_name.DropDownWidth = 150;
            this.exer_name.FormattingEnabled = true;
            this.exer_name.Location = new System.Drawing.Point(112, 158);
            this.exer_name.Name = "exer_name";
            this.exer_name.Size = new System.Drawing.Size(185, 21);
            this.exer_name.Sorted = true;
            this.exer_name.TabIndex = 56;
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.Transparent;
            this.filter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filter_btn.Image = global::WindowsFormsApp1.Properties.Resources.pngwing2;
            this.filter_btn.Location = new System.Drawing.Point(8, 130);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(27, 22);
            this.filter_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filter_btn.TabIndex = 57;
            this.filter_btn.TabStop = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // muscleGroup_filter
            // 
            this.muscleGroup_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.muscleGroup_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.muscleGroup_filter.DropDownWidth = 140;
            this.muscleGroup_filter.FormattingEnabled = true;
            this.muscleGroup_filter.Location = new System.Drawing.Point(44, 131);
            this.muscleGroup_filter.Name = "muscleGroup_filter";
            this.muscleGroup_filter.Size = new System.Drawing.Size(103, 21);
            this.muscleGroup_filter.TabIndex = 58;
            this.muscleGroup_filter.TabStop = false;
            this.muscleGroup_filter.Text = "No Filter";
            this.muscleGroup_filter.Visible = false;
            this.muscleGroup_filter.SelectedValueChanged += new System.EventHandler(this.filterSearch);
            this.muscleGroup_filter.VisibleChanged += new System.EventHandler(this.filter_load);
            // 
            // level_filter
            // 
            this.level_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.level_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.level_filter.FormattingEnabled = true;
            this.level_filter.Location = new System.Drawing.Point(153, 131);
            this.level_filter.Name = "level_filter";
            this.level_filter.Size = new System.Drawing.Size(92, 21);
            this.level_filter.TabIndex = 59;
            this.level_filter.TabStop = false;
            this.level_filter.Text = "No Filter";
            this.level_filter.Visible = false;
            this.level_filter.SelectedValueChanged += new System.EventHandler(this.filterSearch);
            // 
            // target_filter
            // 
            this.target_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.target_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.target_filter.FormattingEnabled = true;
            this.target_filter.Location = new System.Drawing.Point(251, 131);
            this.target_filter.Name = "target_filter";
            this.target_filter.Size = new System.Drawing.Size(70, 21);
            this.target_filter.TabIndex = 60;
            this.target_filter.TabStop = false;
            this.target_filter.Text = "No Filter";
            this.target_filter.Visible = false;
            this.target_filter.SelectedValueChanged += new System.EventHandler(this.filterSearch);
            // 
            // muscle_Lbl
            // 
            this.muscle_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.muscle_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muscle_Lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.muscle_Lbl.Location = new System.Drawing.Point(58, 117);
            this.muscle_Lbl.Name = "muscle_Lbl";
            this.muscle_Lbl.Size = new System.Drawing.Size(76, 19);
            this.muscle_Lbl.TabIndex = 61;
            this.muscle_Lbl.Text = "Muscle Group";
            this.muscle_Lbl.Visible = false;
            // 
            // lvl_lbl
            // 
            this.lvl_lbl.BackColor = System.Drawing.Color.Transparent;
            this.lvl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lvl_lbl.Location = new System.Drawing.Point(185, 117);
            this.lvl_lbl.Name = "lvl_lbl";
            this.lvl_lbl.Size = new System.Drawing.Size(41, 19);
            this.lvl_lbl.TabIndex = 62;
            this.lvl_lbl.Text = "Level";
            this.lvl_lbl.Visible = false;
            // 
            // target_lbl
            // 
            this.target_lbl.BackColor = System.Drawing.Color.Transparent;
            this.target_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.target_lbl.Location = new System.Drawing.Point(267, 117);
            this.target_lbl.Name = "target_lbl";
            this.target_lbl.Size = new System.Drawing.Size(41, 19);
            this.target_lbl.TabIndex = 63;
            this.target_lbl.Text = "Target";
            this.target_lbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.rep);
            this.panel1.Location = new System.Drawing.Point(204, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 20);
            this.panel1.TabIndex = 64;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(54, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 17);
            this.time.TabIndex = 1;
            this.time.Text = "time (secs)";
            this.time.UseVisualStyleBackColor = true;
            // 
            // rep
            // 
            this.rep.AutoSize = true;
            this.rep.Checked = true;
            this.rep.ForeColor = System.Drawing.Color.White;
            this.rep.Location = new System.Drawing.Point(3, 2);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(45, 17);
            this.rep.TabIndex = 0;
            this.rep.TabStop = true;
            this.rep.Text = "reps";
            this.rep.UseVisualStyleBackColor = true;
            // 
            // equpWeight_lbl
            // 
            this.equpWeight_lbl.BackColor = System.Drawing.Color.Transparent;
            this.equpWeight_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equpWeight_lbl.ForeColor = System.Drawing.Color.White;
            this.equpWeight_lbl.Location = new System.Drawing.Point(14, 286);
            this.equpWeight_lbl.Name = "equpWeight_lbl";
            this.equpWeight_lbl.Size = new System.Drawing.Size(120, 19);
            this.equpWeight_lbl.TabIndex = 65;
            this.equpWeight_lbl.Text = "Equipment Weight";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.BackColor = System.Drawing.Color.Transparent;
            this.lbs.ForeColor = System.Drawing.Color.White;
            this.lbs.Location = new System.Drawing.Point(45, 2);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(38, 17);
            this.lbs.TabIndex = 67;
            this.lbs.TabStop = true;
            this.lbs.Text = "lbs";
            this.lbs.UseVisualStyleBackColor = false;
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.BackColor = System.Drawing.Color.Transparent;
            this.kg.Checked = true;
            this.kg.ForeColor = System.Drawing.Color.White;
            this.kg.Location = new System.Drawing.Point(0, 1);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(37, 17);
            this.kg.TabIndex = 66;
            this.kg.TabStop = true;
            this.kg.Text = "kg";
            this.kg.UseVisualStyleBackColor = false;
            // 
            // weightval
            // 
            this.weightval.DecimalPlaces = 1;
            this.weightval.Location = new System.Drawing.Point(321, 644);
            this.weightval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightval.Name = "weightval";
            this.weightval.Size = new System.Drawing.Size(57, 20);
            this.weightval.TabIndex = 68;
            this.weightval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipWeight
            // 
            this.equipWeight.DecimalPlaces = 1;
            this.equipWeight.Location = new System.Drawing.Point(149, 286);
            this.equipWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.equipWeight.Name = "equipWeight";
            this.equipWeight.Size = new System.Drawing.Size(57, 20);
            this.equipWeight.TabIndex = 69;
            this.equipWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.kg);
            this.panel2.Controls.Add(this.lbs);
            this.panel2.Location = new System.Drawing.Point(213, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 20);
            this.panel2.TabIndex = 65;
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.set__2_1;
            this.ClientSize = new System.Drawing.Size(334, 348);
            this.Controls.Add(this.equipWeight);
            this.Controls.Add(this.weightval);
            this.Controls.Add(this.equpWeight_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.target_filter);
            this.Controls.Add(this.level_filter);
            this.Controls.Add(this.muscleGroup_filter);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.exer_name);
            this.Controls.Add(this.none_btn);
            this.Controls.Add(this.equip_txt);
            this.Controls.Add(this.equip_lbl);
            this.Controls.Add(this.userlist);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.rep_text);
            this.Controls.Add(this.reps_lbl);
            this.Controls.Add(this.set_value);
            this.Controls.Add(this.subtitle_lbl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.set_lbl);
            this.Controls.Add(this.exer_lbl);
            this.Controls.Add(this.muscle_Lbl);
            this.Controls.Add(this.lvl_lbl);
            this.Controls.Add(this.target_lbl);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddExercise";
            this.Text = "Add Exercise";
            this.Load += new System.EventHandler(this.AddExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.set_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipWeight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label set_lbl;
        private System.Windows.Forms.Label exer_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label subtitle_lbl;
        private System.Windows.Forms.NumericUpDown set_value;
        private System.Windows.Forms.Label reps_lbl;
        private System.Windows.Forms.NumericUpDown rep_text;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.ComboBox userlist;
        private System.Windows.Forms.Label equip_lbl;
        private System.Windows.Forms.TextBox equip_txt;
        private System.Windows.Forms.RadioButton none_btn;
        private System.Windows.Forms.ComboBox exer_name;
        private System.Windows.Forms.PictureBox filter_btn;
        private System.Windows.Forms.ComboBox muscleGroup_filter;
        private System.Windows.Forms.ComboBox level_filter;
        private System.Windows.Forms.ComboBox target_filter;
        private System.Windows.Forms.Label muscle_Lbl;
        private System.Windows.Forms.Label lvl_lbl;
        private System.Windows.Forms.Label target_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton time;
        private System.Windows.Forms.RadioButton rep;
        private System.Windows.Forms.Label equpWeight_lbl;
        private System.Windows.Forms.RadioButton lbs;
        private System.Windows.Forms.RadioButton kg;
        private System.Windows.Forms.NumericUpDown weightval;
        private System.Windows.Forms.NumericUpDown equipWeight;
        private System.Windows.Forms.Panel panel2;
    }
}