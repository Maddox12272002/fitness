namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.monitor_lbl = new System.Windows.Forms.Label();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.setting_lbl = new System.Windows.Forms.Label();
            this.edit_lbl = new System.Windows.Forms.Label();
            this.exercise_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.img_path = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.profile = new WindowsFormsApp1.CirclePictureBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmi_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.class_lbl = new System.Windows.Forms.Label();
            this.pfp = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.monitor_lbl);
            this.panel2.Controls.Add(this.logout_lbl);
            this.panel2.Controls.Add(this.setting_lbl);
            this.panel2.Controls.Add(this.edit_lbl);
            this.panel2.Controls.Add(this.exercise_lbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 333);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // monitor_lbl
            // 
            this.monitor_lbl.AutoSize = true;
            this.monitor_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitor_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.monitor_lbl.Location = new System.Drawing.Point(25, 125);
            this.monitor_lbl.Name = "monitor_lbl";
            this.monitor_lbl.Size = new System.Drawing.Size(124, 32);
            this.monitor_lbl.TabIndex = 5;
            this.monitor_lbl.Text = "Monitor";
            this.monitor_lbl.Click += new System.EventHandler(this.label12_Click);
            this.monitor_lbl.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.monitor_lbl.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_lbl.Location = new System.Drawing.Point(25, 211);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(119, 32);
            this.logout_lbl.TabIndex = 4;
            this.logout_lbl.Text = "Logout";
            this.logout_lbl.Click += new System.EventHandler(this.label8_Click);
            this.logout_lbl.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.logout_lbl.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // setting_lbl
            // 
            this.setting_lbl.AutoSize = true;
            this.setting_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setting_lbl.Location = new System.Drawing.Point(25, 168);
            this.setting_lbl.Name = "setting_lbl";
            this.setting_lbl.Size = new System.Drawing.Size(120, 32);
            this.setting_lbl.TabIndex = 3;
            this.setting_lbl.Text = "Setting";
            this.setting_lbl.Click += new System.EventHandler(this.label7_Click);
            this.setting_lbl.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.setting_lbl.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // edit_lbl
            // 
            this.edit_lbl.AutoSize = true;
            this.edit_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit_lbl.Location = new System.Drawing.Point(25, 83);
            this.edit_lbl.Name = "edit_lbl";
            this.edit_lbl.Size = new System.Drawing.Size(211, 32);
            this.edit_lbl.TabIndex = 2;
            this.edit_lbl.Text = "Edit Exercise";
            this.edit_lbl.Click += new System.EventHandler(this.label4_Click);
            this.edit_lbl.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.edit_lbl.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // exercise_lbl
            // 
            this.exercise_lbl.AutoSize = true;
            this.exercise_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exercise_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exercise_lbl.Location = new System.Drawing.Point(25, 43);
            this.exercise_lbl.Name = "exercise_lbl";
            this.exercise_lbl.Size = new System.Drawing.Size(146, 32);
            this.exercise_lbl.TabIndex = 1;
            this.exercise_lbl.Text = "Exercise";
            this.exercise_lbl.Click += new System.EventHandler(this.label5_Click);
            this.exercise_lbl.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.exercise_lbl.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sui Generis Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(-6, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "MAIN MENU";
            // 
            // img_path
            // 
            this.img_path.Location = new System.Drawing.Point(447, 411);
            this.img_path.Name = "img_path";
            this.img_path.ReadOnly = true;
            this.img_path.Size = new System.Drawing.Size(100, 20);
            this.img_path.TabIndex = 29;
            this.img_path.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.PngItem_4856652;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(532, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 18);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.state_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(501, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.state_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._2_1166641;
            this.pictureBox1.Location = new System.Drawing.Point(246, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.form2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(61, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(355, 57);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.DimGray;
            this.profile.Location = new System.Drawing.Point(31, 50);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(101, 103);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 32;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.pictureBox1_Click);
            this.profile.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.profile.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.BackColor = System.Drawing.Color.Transparent;
            this.age_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.ForeColor = System.Drawing.Color.White;
            this.age_lbl.Location = new System.Drawing.Point(226, 83);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(79, 24);
            this.age_lbl.TabIndex = 24;
            this.age_lbl.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(312, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "BMI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(159, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // bmi_lbl
            // 
            this.bmi_lbl.AutoSize = true;
            this.bmi_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bmi_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmi_lbl.ForeColor = System.Drawing.Color.White;
            this.bmi_lbl.Location = new System.Drawing.Point(364, 81);
            this.bmi_lbl.Name = "bmi_lbl";
            this.bmi_lbl.Size = new System.Drawing.Size(76, 24);
            this.bmi_lbl.TabIndex = 26;
            this.bmi_lbl.Text = "label11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(159, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGE:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(242, 50);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(109, 24);
            this.name_lbl.TabIndex = 23;
            this.name_lbl.Text = "name_lbl";
            // 
            // class_lbl
            // 
            this.class_lbl.AutoSize = true;
            this.class_lbl.BackColor = System.Drawing.Color.Transparent;
            this.class_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_lbl.ForeColor = System.Drawing.Color.White;
            this.class_lbl.Location = new System.Drawing.Point(364, 116);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(81, 23);
            this.class_lbl.TabIndex = 30;
            this.class_lbl.Text = "label13";
            // 
            // pfp
            // 
            this.pfp.AutoSize = true;
            this.pfp.LinkColor = System.Drawing.Color.White;
            this.pfp.Location = new System.Drawing.Point(28, 97);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(112, 13);
            this.pfp.TabIndex = 28;
            this.pfp.TabStop = true;
            this.pfp.Text = "Change Profile Picture";
            this.pfp.Visible = false;
            this.pfp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pfp_LinkClicked);
            this.pfp.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pfp.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sui Generis Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(159, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 24);
            this.label14.TabIndex = 31;
            this.label14.Text = "CLASSIFICATION:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pfp);
            this.panel1.Controls.Add(this.class_lbl);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.bmi_lbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.age_lbl);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 160);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.set__2_1;
            this.ClientSize = new System.Drawing.Size(554, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_path);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.Label setting_lbl;
        private System.Windows.Forms.Label edit_lbl;
        private System.Windows.Forms.Label exercise_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label monitor_lbl;
        private System.Windows.Forms.TextBox img_path;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CirclePictureBox profile;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bmi_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.LinkLabel pfp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
    }
}