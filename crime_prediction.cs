using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace crime_trend_project_winforms_latest
{
    public partial class crime_prediction : Form
    {
        public crime_prediction()
        {
            InitializeComponent();
        }
        public List<int> getTexts()
        {
            List<int> texts = new List<int>();
            string district = comboBox1.SelectedItem?.ToString();
            string division = comboBox2.SelectedItem?.ToString();
            string day_night = comboBox3.SelectedItem?.ToString();
            string gender = comboBox4.SelectedItem?.ToString();

            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\CrimeGuardAnalysisSoftware\\crimes_updated_db.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    // Execute queries to get the encoded values
                    if (!string.IsNullOrEmpty(district))
                    {
                        command.CommandText = $"SELECT DISTINCT District_Encoded FROM crime_data WHERE District = @district";
                        command.Parameters.AddWithValue("@district", district);
                        int districtEncoded = Convert.ToInt32(command.ExecuteScalar());
                        texts.Add(districtEncoded);
                    }

                    if (!string.IsNullOrEmpty(division))
                    {
                        command.CommandText = $"SELECT DISTINCT Division_Encoded FROM crime_data WHERE Division = @division";
                        command.Parameters.AddWithValue("@division", division);
                        int divisionEncoded = Convert.ToInt32(command.ExecuteScalar());
                        texts.Add(divisionEncoded);
                    }

                    if (!string.IsNullOrEmpty(gender))
                    {
                        command.CommandText = $"SELECT DISTINCT Victim_Sex_Encoded FROM crime_data WHERE Victim_Sex = @gender";
                        command.Parameters.AddWithValue("@gender", gender);
                        int genderEncoded = Convert.ToInt32(command.ExecuteScalar());
                        texts.Add(genderEncoded);
                    }

                    if (!string.IsNullOrEmpty(day_night))
                    {
                        command.CommandText = $"SELECT DISTINCT day_night_Encoded FROM crime_data WHERE day_night = @day_night";
                        command.Parameters.AddWithValue("@day_night", day_night);
                        int dayNightEncoded = Convert.ToInt32(command.ExecuteScalar());
                        texts.Add(dayNightEncoded);
                    }
                }
            }

            return texts;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<int> CallPythonModel(List<int> data)
        {
            // Serialize the list into a JSON string
            string jsonData = JsonConvert.SerializeObject(data);

            // Call the Python script with the serialized data as an argument
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python";
            startInfo.Arguments = $"predict_age_group.py \"{jsonData}\""; // Pass serialized data as argument
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    // Deserialize the JSON string into a list of integers
                    List<int> predictions = JsonConvert.DeserializeObject<List<int>>(result);
                    return predictions;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Usage example:
            List<int> data = getTexts(); // Assuming getTexts() returns a list of integers
            List<int> result = CallPythonModel(data);
            Console.WriteLine("Result from Python model: " + result);
            




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
