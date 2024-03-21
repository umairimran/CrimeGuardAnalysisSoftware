using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crime_trend_project_winforms_latest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crime_trend_page c=new crime_trend_page();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            crime_input_page c = new crime_input_page();
            c.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_data_in_database g=new search_data_in_database();
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new crime_prediction().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            crime_trend_page frmFb = new crime_trend_page() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(frmFb);
            frmFb.Show();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new crime_prediction().Show();
        }
    }
}
