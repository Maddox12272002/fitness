namespace WindowsFormsApp1
{
    partial class Monitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monitor_table = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.weightUpdate = new System.Windows.Forms.Button();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.bmi_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.userlist = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(365, 70);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(423, 311);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Monitoring Chart";
            // 
            // monitor_table
            // 
            this.monitor_table.AllowUserToAddRows = false;
            this.monitor_table.AllowUserToDeleteRows = false;
            this.monitor_table.AllowUserToResizeColumns = false;
            this.monitor_table.AllowUserToResizeRows = false;
            this.monitor_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monitor_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.monitor_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitor_table.Location = new System.Drawing.Point(12, 70);
            this.monitor_table.Name = "monitor_table";
            this.monitor_table.ReadOnly = true;
            this.monitor_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.monitor_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monitor_table.Size = new System.Drawing.Size(344, 368);
            this.monitor_table.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(753, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.TabIndex = 27;
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
            this.pictureBox1.Location = new System.Drawing.Point(784, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.TabIndex = 26;
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
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 35);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // weightUpdate
            // 
            this.weightUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.weightUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.weightUpdate.Font = new System.Drawing.Font("Sui Generis Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUpdate.Location = new System.Drawing.Point(365, 387);
            this.weightUpdate.Name = "weightUpdate";
            this.weightUpdate.Size = new System.Drawing.Size(90, 23);
            this.weightUpdate.TabIndex = 28;
            this.weightUpdate.Text = "Update";
            this.weightUpdate.UseVisualStyleBackColor = false;
            this.weightUpdate.Click += new System.EventHandler(this.weightUpdate_Click);
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.BackColor = System.Drawing.Color.Transparent;
            this.weight_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.weight_lbl.Location = new System.Drawing.Point(12, 40);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(82, 23);
            this.weight_lbl.TabIndex = 41;
            this.weight_lbl.Text = "Weight";
            this.weight_lbl.Click += new System.EventHandler(this.weight_lbl_Click);
            this.weight_lbl.MouseEnter += new System.EventHandler(this.weight_lbl_MouseEnter);
            this.weight_lbl.MouseLeave += new System.EventHandler(this.leave);
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.BackColor = System.Drawing.Color.Transparent;
            this.height_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.height_lbl.Location = new System.Drawing.Point(102, 40);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(76, 23);
            this.height_lbl.TabIndex = 42;
            this.height_lbl.Text = "Height";
            this.height_lbl.Click += new System.EventHandler(this.height_lbl_Click);
            this.height_lbl.MouseEnter += new System.EventHandler(this.height_lbl_MouseEnter);
            this.height_lbl.MouseLeave += new System.EventHandler(this.leave);
            // 
            // bmi_lbl
            // 
            this.bmi_lbl.AutoSize = true;
            this.bmi_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bmi_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmi_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.bmi_lbl.Location = new System.Drawing.Point(187, 41);
            this.bmi_lbl.Name = "bmi_lbl";
            this.bmi_lbl.Size = new System.Drawing.Size(49, 23);
            this.bmi_lbl.TabIndex = 43;
            this.bmi_lbl.Text = "BMI";
            this.bmi_lbl.Click += new System.EventHandler(this.bmi_lbl_Click);
            this.bmi_lbl.MouseEnter += new System.EventHandler(this.bmi_lbl_MouseEnter);
            this.bmi_lbl.MouseLeave += new System.EventHandler(this.leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(534, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "DAY";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.BackColor = System.Drawing.Color.White;
            this.y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.y_label.Location = new System.Drawing.Point(365, 207);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(25, 16);
            this.y_label.TabIndex = 45;
            this.y_label.Text = "KG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.user_lbl.Font = new System.Drawing.Font("Sui Generis Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.user_lbl.Location = new System.Drawing.Point(596, 41);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(60, 23);
            this.user_lbl.TabIndex = 48;
            this.user_lbl.Text = "User";
            // 
            // userlist
            // 
            this.userlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userlist.FormattingEnabled = true;
            this.userlist.Location = new System.Drawing.Point(662, 43);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(92, 21);
            this.userlist.TabIndex = 49;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.refresh_btn_Click);
            this.userlist.TextUpdate += new System.EventHandler(this.refresh_btn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.form2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(231, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(338, 45);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sui Generis Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(316, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "MONITORING";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.set__2_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userlist);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmi_lbl);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.weight_lbl);
            this.Controls.Add(this.weightUpdate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.monitor_table);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView monitor_table;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button weightUpdate;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label bmi_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.ComboBox userlist;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}