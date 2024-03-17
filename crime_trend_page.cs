using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Media;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Definitions.Charts;
using System.Windows.Markup;

namespace crime_trend_project_winforms_latest
{
    public partial class crime_trend_page : Form
    {

        public crime_trend_page()
        {
            InitializeComponent();
            load_pie_chart();
            //chart1.Size = new System.Drawing.Size(800, 600);
            //chart1.Location = new System.Drawing.Point(50, 50);
          
            LoadChartDataFromDatabase();
            Dictionary<int, int> data = GetCrimeCountsByTimeFromDatabase();

            // Load data into the chart
            LoadChartData(cartesianChart5, data);
            data = GetYearlyCrimeCountsFromDatabase();
            PlotCrimeTrend(data,cartesianChart1, System.Windows.Media.Colors.Blue,"Yearly Crime Trend");
            PlotCrimeTrendByWeapon();


        }

        public void PlotCrimeTrendByWeapon()
        {
            Dictionary<int, int> pistol = GetYearlyCrimeCountsByWeaponFromDatabase("Pistol");
            PlotCrimeTrend(pistol, cartesianChart2, System.Windows.Media.Colors.Blue,"Pistol Trend");
            Dictionary<int, int> sniper = GetYearlyCrimeCountsByWeaponFromDatabase("Sniper Rifle");
            PlotCrimeTrend(sniper, cartesianChart2, System.Windows.Media.Colors.Red,"Sniper Rifle Trend");
            Dictionary<int, int> knife = GetYearlyCrimeCountsByWeaponFromDatabase("Knife");
            PlotCrimeTrend(knife, cartesianChart2, System.Windows.Media.Colors.Green, "Knife Trend");

            Dictionary<int, int> shotgun = GetYearlyCrimeCountsByWeaponFromDatabase("Shotgun");
            PlotCrimeTrend(shotgun, cartesianChart2, System.Windows.Media.Colors.Orange, "Shotgun Trend");

            Dictionary<int, int> grenade = GetYearlyCrimeCountsByWeaponFromDatabase("Grenade");
            PlotCrimeTrend(grenade, cartesianChart2, System.Windows.Media.Colors.Yellow, "Grenade Trend");

            Dictionary<int, int> rifle = GetYearlyCrimeCountsByWeaponFromDatabase("Rifle");
            PlotCrimeTrend(rifle, cartesianChart2, System.Windows.Media.Colors.Purple, "Rifle Trend");




        }
        private Dictionary<int, int> GetYearlyCrimeCountsFromDatabase()
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\CrimeGuardAnalysisSoftware\\crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Year, SUM(CrimeCount) AS TotalCount FROM crime_data GROUP BY Year";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Year"] != DBNull.Value && reader["TotalCount"] != DBNull.Value)
                            {
                                int year = Convert.ToInt32(reader["Year"]);
                                int count = Convert.ToInt32(reader["TotalCount"]);
                                counts.Add(year, count);
                            }
                        }
                    }
                }
            }

            return counts;
        }

        private Dictionary<int, int> GetYearlyCrimeCountsByWeaponFromDatabase(string word)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\CrimeGuardAnalysisSoftware\\crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
               string query = $"SELECT Year, COUNT(*) AS count FROM crime_data WHERE Weapon = '{word}' GROUP BY Year";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Year"] != DBNull.Value && reader["count"] != DBNull.Value)
                            {
                                int year = Convert.ToInt32(reader["Year"]); Random random = new Random();

                                // Then you can use it to generate random numbers
                                int count = Convert.ToInt32(reader["count"]);// Add a random number between 1 and 10

                                counts.Add(year, count);
                            }
                        }
                    }
                }
            }

            return counts;
        }
        public void PlotCrimeTrend(Dictionary<int, int> yearlyCrimeCounts, LiveCharts.WinForms.CartesianChart chart, System.Windows.Media.Color lineColor,string title)
        {
         
            // Prepare data for plotting
            var years = yearlyCrimeCounts.Keys.OrderBy(year => year);
            var crimeCounts = years.Select(year => yearlyCrimeCounts[year]);

            // Create a LineSeries to plot the crime trend
            var lineSeries = new LiveCharts.Wpf.LineSeries
            {
                Title = title,
                Values = new LiveCharts.ChartValues<int>(crimeCounts),
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                Stroke = new System.Windows.Media.SolidColorBrush(lineColor) // Set line color
            };

            // Add the LineSeries to the chart
            chart.Series.Add(lineSeries);

            // Customize axis labels and formatting
            chart.AxisX.Clear();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Year",
                Labels = years.Select(year => year.ToString()).ToList()
            });

            chart.AxisY.Clear();
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Crime Count"
            });
            chart.DataTooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };
        }



        private void LoadChartData(LiveCharts.WinForms.CartesianChart   chart, Dictionary<int, int> data)
        {
            // Lists to store x-axis labels and y-axis values
            List<string> xAxisLabels = new List<string>();
            List<int> yAxisValues = new List<int>();

            // Mapping dictionary keys to x-axis labels and adding values to y-axis list
            foreach (var pair in data)
            {
                string label = GetXAxisLabel(pair.Key); // Function to get x-axis label based on dictionary key
                xAxisLabels.Add(label);
                yAxisValues.Add(pair.Value);
            }

            // Clear existing series from the chart
            chart.Series.Clear();

            // Add series to the chart
            chart.Series = new LiveCharts.SeriesCollection
    {
        new ColumnSeries
        {
            Title = "Crime Count",
            Values = new ChartValues<int>(yAxisValues)
        }
    };

            // Customize x-axis labels
            chart.AxisX.Clear();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time Interval",
                Labels = xAxisLabels.ToArray() // Convert xAxisLabels to an array if it's not already
            });

            // Customize other properties of the chart as needed
        }

        // Function to get x-axis label based on dictionary key (e.g., 0 -> "12am", 1 -> "3am", etc.)
        private string GetXAxisLabel(int key)
        {
            switch (key)
            {
                case 0: return "12am";
                case 1: return "3am";
                case 2: return "6am";
                case 3: return "9am";
                case 4: return "12pm";
                case 5: return "3pm";
                case 6: return "6pm";
                case 7: return "9pm";
                default: return ""; // Add more cases if needed
            }
        }

        private void LoadChartDataFromDatabase()
        {
            try
            {
                // Retrieve data from the database
                Dictionary<string, int> data = GetCountsFromDataBase("crimeType");
                string message = "Crime Types:\n";
                foreach (var pair in data)
                {
                    message += $"{pair.Key}: {pair.Value}\n";
                }
                MessageBox.Show(message, "Data from Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear existing series from the chart
                chart1.Series.Clear();

                // Add series to the chart
                foreach (var pair in data)
                {
                    // Create a new series for each pair
                    System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series(pair.Key);

                    // Add data points to the series
                    series.Points.AddXY(pair.Key, pair.Value);
                    series["PixelPointWidth"] = "200";


                    // Add the series to the chart's SeriesCollection
                    chart1.Series.Add(series);
                }

                // Customize other properties of the chart as needed
              
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //        public void load_pie_chart()
        //        {
        //            Dictionary<string, int> weaponCounts = GetWeaponCountsFromDataBase();


        //            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

        //   foreach (var kvp in weaponCounts)
        //{
        //    PieSeries pieSeries = new PieSeries
        //    {
        //        Title = kvp.Key,
        //        Values = new ChartValues<int> { kvp.Value },
        //        DataLabels = true
        //    };

        //    series.Add(pieSeries);
        //}

        //pieChart1.Series = series;
        //        }
        public void load_pie_chart()
        {
            Dictionary<string, int> weaponCounts = GetCountsFromDataBase("Weapon");

            // Define a color palette for the slices
            List<Color> colors = new List<Color>
    {
        Color.FromRgb(0, 122, 204),   // Blue
        Color.FromRgb(0, 158, 115),   // Green
        Color.FromRgb(255, 127, 14),  // Orange
        Color.FromRgb(255, 0, 0),     // Red
        Color.FromRgb(128, 0, 128)    // Purple
        // Add more colors as needed
    };

            // Create a series collection for the pie chart
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            // Add pie series for each weapon count
            int colorIndex = 0;
            foreach (var kvp in weaponCounts)
            {
                // Create a pie series for the current weapon
                PieSeries pieSeries = new PieSeries
                {
                    Title = kvp.Key,
                    Values = new ChartValues<int> { kvp.Value },
                    DataLabels = true,
                    Fill = new SolidColorBrush(colors[colorIndex % colors.Count]), // Set slice color
                    LabelPoint = chartPoint => string.Format("{0} ({1})", chartPoint.SeriesView.Title, chartPoint.Y) // Custom label format
                };

                series.Add(pieSeries);

                colorIndex++;
            }

            // Configure the pie chart
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Right; // Position legend to the right
            pieChart1.DefaultLegend.FontFamily = new System.Windows.Media.FontFamily("Segoe UI"); // Set legend font
            pieChart1.DefaultLegend.FontSize = 12; // Set legend font size
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string, int> GetCountsFromDataBase(string word)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // Establish connection to the SQLite database
            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\CrimeGuardAnalysisSoftware\\crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query dynamically based on the value of word
                string query = $"SELECT {word}, COUNT(*) AS count FROM crime_data GROUP BY {word}";

                // Create a command to execute SQL query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the command and read the results
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = reader[word].ToString(); // Use word as column name to retrieve value
                            int count = Convert.ToInt32(reader["count"]);
                            counts.Add(key, count);
                        }
                    }
                }
            }

            return counts;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<int, int> GetCrimeCountsByTimeFromDatabase()
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Establish connection to the SQLite database
            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\CrimeGuardAnalysisSoftware\\crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query to retrieve time ranges and crime counts
                string query = @"
            SELECT
                CASE
                    WHEN TIME(time) >= '00:00:00' AND TIME(time) < '03:00:00' THEN 1
                    WHEN TIME(time) >= '03:00:00' AND TIME(time) < '06:00:00' THEN 2
                    WHEN TIME(time) >= '06:00:00' AND TIME(time) < '09:00:00' THEN 3
                    WHEN TIME(time) >= '09:00:00' AND TIME(time) < '11:00:00' THEN 4
                    WHEN TIME(time) >= '11:00:00' AND TIME(time) < '12:00:00' THEN 5
                    WHEN TIME(time) >= '12:00:00' AND TIME(time) < '15:00:00' THEN 6
                    WHEN TIME(time) >= '15:00:00' AND TIME(time) < '18:00:00' THEN 7
                    WHEN TIME(time) >= '18:00:00' AND TIME(time) < '21:00:00' THEN 8
                    WHEN TIME(time) >= '21:00:00' AND TIME(time) < '00:00:00' THEN 9
                    ELSE 0  -- Default value when no range matches
                END AS time_range,
                SUM(CrimeCount) AS total_crime_count
            FROM
                crime_data
            GROUP BY
                time_range;";

                // Create a command to execute SQL query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the command and read the results
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int timeRange = Convert.ToInt32(reader["time_range"]);
                            int totalCrimeCount = Convert.ToInt32(reader["total_crime_count"]);
                            counts.Add(timeRange, totalCrimeCount);
                        }
                    }
                }
            }

            return counts;
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
        //LoadCartisianChart(cartesianChart1, data)
        //{

        //    cartesianChart1.AxisX.Add(new LiveCharts.Wpf.axis){
        //        Title='month',
        //            labels = new[] {"jan"}
        //    },

        //    cartisianchart1.axisy.add(new LiveCharts.Wpf.Axis
        //    {
        //        Title = 'revenue',
        //        lebalformatter=value=> value.ToString("C")
        //    });
        //cartisianHCart1.legendLocation=LiveCharts.LegendLocation.right


        //    cartesianChart1.Series.Clear();
        //    SeriesCollection series = new Seriescollectoin;
        //    var year = (from o in revenyebindingsource.sdatasourcs as List<revenue>
        //                select new { year = o.year }.distinct);
        //    foreach(var year in years)
        //    {
        //        List<double> values = new list<double>();
        //        for (int month =1; month<=12; month ++)
        //        {
        //            double value = 0;
        //            var data from o in revenuebindingsource dasoure as List<revenur>
        //                whre o.year.equalt(year.year) && o.month.equals(month)
        //                select new { o.value, o.month };

        //            if (data.singleordefault() != null)
        //                value = data.singleordefault().value;
        //            values.Add(calue);
        //            series.add(new LineSeries() { Title = year.year.tostring, Values = new chartvalues<double>(values) }];
        //        }
        //    }
        //    cartesianChart1.Series = series;
        //}