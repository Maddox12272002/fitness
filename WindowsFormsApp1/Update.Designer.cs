namespace WindowsFormsApp1
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.RadioButton();
            this.kg = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.ft = new System.Windows.Forms.RadioButton();
            this.cm = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // weight
            // 
            this.weight.DecimalPlaces = 2;
            this.weight.Location = new System.Drawing.Point(157, 110);
            this.weight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(58, 20);
            this.weight.TabIndex = 40;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "Weight";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(157, 70);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(49, 20);
            this.day.TabIndex = 38;
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sui Generis Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sui Generis Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(97, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Update ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 33;
            this.label2.Text = "Day Number";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.BackColor = System.Drawing.Color.Transparent;
            this.lbs.ForeColor = System.Drawing.Color.White;
            this.lbs.Location = new System.Drawing.Point(260, 111);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(38, 17);
            this.lbs.TabIndex = 42;
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
            this.kg.Location = new System.Drawing.Point(218, 111);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(37, 17);
            this.kg.TabIndex = 41;
            this.kg.TabStop = true;
            this.kg.Text = "kg";
            this.kg.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Height";
            // 
            // height
            // 
            this.height.DecimalPlaces = 2;
            this.height.Location = new System.Drawing.Point(157, 150);
            this.height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(58, 20);
            this.height.TabIndex = 44;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.BackColor = System.Drawing.Color.Transparent;
            this.ft.ForeColor = System.Drawing.Color.White;
            this.ft.Location = new System.Drawing.Point(260, 153);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(31, 17);
            this.ft.TabIndex = 46;
            this.ft.TabStop = true;
            this.ft.Text = "ft";
            this.ft.UseVisualStyleBackColor = false;
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.BackColor = System.Drawing.Color.Transparent;
            this.cm.Checked = true;
            this.cm.ForeColor = System.Drawing.Color.White;
            this.cm.Location = new System.Drawing.Point(219, 152);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(39, 17);
            this.cm.TabIndex = 45;
            this.cm.TabStop = true;
            this.cm.Text = "cm";
            this.cm.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(217, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 32);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(216, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 20);
            this.panel2.TabIndex = 48;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.set__2_1;
            this.ClientSize = new System.Drawing.Size(310, 235);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbs);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton lbs;
        private System.Windows.Forms.RadioButton kg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.RadioButton ft;
        private System.Windows.Forms.RadioButton cm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}