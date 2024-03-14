namespace crime_trend_project_winforms_latest
{
    partial class crime_trend_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.totalCrimeBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.murdersBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(25, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(616, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(370, 32);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Crime Trend Analysis ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.totalCrimeBox);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(25, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(105, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // totalCrimeBox
            // 
            this.totalCrimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.totalCrimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCrimeBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCrimeBox.ForeColor = System.Drawing.Color.White;
            this.totalCrimeBox.Location = new System.Drawing.Point(10, 42);
            this.totalCrimeBox.Name = "totalCrimeBox";
            this.totalCrimeBox.ReadOnly = true;
            this.totalCrimeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.totalCrimeBox.Size = new System.Drawing.Size(124, 34);
            this.totalCrimeBox.TabIndex = 1;
            this.totalCrimeBox.Text = "451";
            this.totalCrimeBox.TextChanged += new System.EventHandler(this.totalCrimeBox_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(131, 33);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "Total Crimes";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.murdersBox);
            this.panel3.Controls.Add(this.richTextBox3);
            this.panel3.Location = new System.Drawing.Point(25, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(105, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // murdersBox
            // 
            this.murdersBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.murdersBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.murdersBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.murdersBox.ForeColor = System.Drawing.Color.White;
            this.murdersBox.Location = new System.Drawing.Point(3, 42);
            this.murdersBox.Name = "murdersBox";
            this.murdersBox.ReadOnly = true;
            this.murdersBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.murdersBox.Size = new System.Drawing.Size(124, 34);
            this.murdersBox.TabIndex = 2;
            this.murdersBox.Text = "451";
            this.murdersBox.TextChanged += new System.EventHandler(this.murdersBox_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(3, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(131, 33);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "Total Murders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.richTextBox6);
            this.panel4.Controls.Add(this.richTextBox5);
            this.panel4.Location = new System.Drawing.Point(25, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 367);
            this.panel4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(105, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Details";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(10, 54);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox6.Size = new System.Drawing.Size(124, 34);
            this.richTextBox6.TabIndex = 3;
            this.richTextBox6.Text = "451";
            this.richTextBox6.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(3, 15);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(131, 33);
            this.richTextBox5.TabIndex = 3;
            this.richTextBox5.Text = "Total Burglary";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel5.Location = new System.Drawing.Point(231, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 206);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel6.Controls.Add(this.cartesianChart1);
            this.panel6.Location = new System.Drawing.Point(641, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(671, 327);
            this.panel6.TabIndex = 3;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(3, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(647, 313);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel7.Controls.Add(this.pieChart3);
            this.panel7.Controls.Add(this.pieChart2);
            this.panel7.Controls.Add(this.pieChart1);
            this.panel7.Location = new System.Drawing.Point(641, 390);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(671, 259);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pieChart3
            // 
            this.pieChart3.Location = new System.Drawing.Point(168, 109);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(213, 137);
            this.pieChart3.TabIndex = 2;
            this.pieChart3.Text = "pieChart3";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(355, 3);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(316, 243);
            this.pieChart2.TabIndex = 1;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(0, 3);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(234, 116);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // crime_trend_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "crime_trend_page";
            this.Text = "crime_trend_page";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel7;
        private LiveCharts.WinForms.PieChart pieChart3;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox totalCrimeBox;
        private System.Windows.Forms.RichTextBox murdersBox;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}