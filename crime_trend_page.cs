using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crime_trend_project_winforms_latest
{
    public partial class crime_trend_page : Form
    {
        public crime_trend_page()
        {
            InitializeComponent();
            int count = getCount("select count(*) from crime_data");
            totalCrimeBox.Clear();
            totalCrimeBox.AppendText($"{count}");
            count = getCount("select count(*) from crime_data where crimeType='Murder'");
            murdersBox.Clear();
            murdersBox.AppendText($"{count}");

        }

        private int getCount(string query)
        {
            int count = 0;
            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\crime_trend_project_winforms_latest\\crime_db.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                count=Convert.ToInt32(command.ExecuteScalar());


            }
            return count;
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCrimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void murdersBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
