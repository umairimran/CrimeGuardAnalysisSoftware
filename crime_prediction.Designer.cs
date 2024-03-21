namespace crime_trend_project_winforms_latest
{
    partial class crime_prediction
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 43);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Select Division";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(118, 151);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 24);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Select DIstrict";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(118, 226);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 34);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "select day night";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(118, 303);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(100, 34);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "select gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bahawalpur",
            "Dera Ghazi Khan",
            "Faisalabad",
            "Gujranwala",
            "Lahore",
            "Multan",
            "Rawalpindi",
            "Sargodha",
            "Sahiwal"});
            this.comboBox1.Location = new System.Drawing.Point(97, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bahawalpur",
            "Bahawalnagar",
            "R.Y.Khan",
            "D.G.Khan",
            "Layyah",
            "Muzaffargarh",
            "Rajanpur",
            "Faisalabad",
            "Jhang",
            "T.T.Singh",
            "Gujranwala",
            "Gujrat",
            "Hafizabad",
            "Mandi Baha-ud-Din",
            "Narowal",
            "Sialkot",
            "Lahore",
            "Kasur",
            "Okara",
            "Sheikhupura",
            "Multan",
            "Khanewal",
            "Lodhran",
            "Vehari",
            "Sahiwal",
            "Pakpattan",
            "Rawalpindi",
            "Attock",
            "Chakwal",
            "Jhelum",
            "Sargodha",
            "Bhakkar",
            "Khushab",
            "Mianwali",
            "Nankana Sahib",
            "Chiniot"});
            this.comboBox2.Location = new System.Drawing.Point(97, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Night",
            "Day"});
            this.comboBox3.Location = new System.Drawing.Point(97, 268);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBox4.Location = new System.Drawing.Point(97, 343);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(412, 79);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(162, 54);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = " crime type output";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(412, 181);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(162, 54);
            this.richTextBox6.TabIndex = 9;
            this.richTextBox6.Text = "weapon type output";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(412, 268);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(162, 54);
            this.richTextBox7.TabIndex = 10;
            this.richTextBox7.Text = "age group type oyutput";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crime_prediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "crime_prediction";
            this.Text = "crime_prediction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Button button1;
    }
}