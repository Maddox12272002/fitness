namespace WindowsFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.regisUser = new System.Windows.Forms.TextBox();
            this.regisPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regisPassConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Regis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.member_btn = new System.Windows.Forms.RadioButton();
            this.trainer_btn = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // regisUser
            // 
            this.regisUser.Location = new System.Drawing.Point(83, 291);
            this.regisUser.Name = "regisUser";
            this.regisUser.Size = new System.Drawing.Size(154, 20);
            this.regisUser.TabIndex = 3;
            // 
            // regisPass
            // 
            this.regisPass.Location = new System.Drawing.Point(83, 324);
            this.regisPass.Name = "regisPass";
            this.regisPass.Size = new System.Drawing.Size(154, 20);
            this.regisPass.TabIndex = 4;
            this.regisPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // regisPassConfirm
            // 
            this.regisPassConfirm.Location = new System.Drawing.Point(83, 359);
            this.regisPassConfirm.Name = "regisPassConfirm";
            this.regisPassConfirm.ShortcutsEnabled = false;
            this.regisPassConfirm.Size = new System.Drawing.Size(154, 20);
            this.regisPassConfirm.TabIndex = 7;
            this.regisPassConfirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password";
            // 
            // Regis
            // 
            this.Regis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.Regis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regis.Location = new System.Drawing.Point(83, 401);
            this.Regis.Name = "Regis";
            this.Regis.Size = new System.Drawing.Size(154, 23);
            this.Regis.TabIndex = 9;
            this.Regis.Text = "Submit";
            this.Regis.UseVisualStyleBackColor = false;
            this.Regis.Click += new System.EventHandler(this.Regis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(448, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.state_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.PngItem_4856652;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(479, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.state_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aback__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 35);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Account Type:";
            // 
            // member_btn
            // 
            this.member_btn.AutoSize = true;
            this.member_btn.BackColor = System.Drawing.Color.Transparent;
            this.member_btn.ForeColor = System.Drawing.Color.White;
            this.member_btn.Location = new System.Drawing.Point(167, 261);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(63, 17);
            this.member_btn.TabIndex = 16;
            this.member_btn.TabStop = true;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = false;
            // 
            // trainer_btn
            // 
            this.trainer_btn.AutoSize = true;
            this.trainer_btn.BackColor = System.Drawing.Color.Transparent;
            this.trainer_btn.Checked = true;
            this.trainer_btn.ForeColor = System.Drawing.Color.White;
            this.trainer_btn.Location = new System.Drawing.Point(103, 260);
            this.trainer_btn.Name = "trainer_btn";
            this.trainer_btn.Size = new System.Drawing.Size(58, 17);
            this.trainer_btn.TabIndex = 15;
            this.trainer_btn.TabStop = true;
            this.trainer_btn.Text = "Trainer";
            this.trainer_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources._2_1166641;
            this.pictureBox4.Location = new System.Drawing.Point(218, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(306, 240);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(77, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "REGISTER";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.set__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.trainer_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Regis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regisPassConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regisPass);
            this.Controls.Add(this.regisUser);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Register_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regisUser;
        private System.Windows.Forms.TextBox regisPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regisPassConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Regis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton member_btn;
        private System.Windows.Forms.RadioButton trainer_btn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
    }
}