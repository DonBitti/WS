using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using MessageStrings = WeatherTracker.Data.WeatherTracker;
using WeatherTracker.Data;
using System.Diagnostics;


namespace WeatherTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chartButton.Enabled = false;
        }

        List<float> array1 = new List<float>();
        List<float> array2 = new List<float>();
        List<DateTime> array3 = new List< DateTime > ();
        Series tempSeries = new Series();
        Series humSeries = new Series();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;         
            updateChart();            
            updateDatagridview();
            DateTime start = startDate.Value.Date + startTime.Value.TimeOfDay;
            DateTime end = endDate.Value.Date + endTime.Value.TimeOfDay;
            
            string queryStart = start.ToString("yyyy-MM-dd HH:mm:ss");
            string queryEnd = end.ToString("yyyy-MM-dd HH:mm:ss");
            string connetionString = null;
            
            MySqlConnection myConn;
            connetionString = "server=" + ConstData.SERVER + ";database=" + ConstData.DATABASE + ";uid=" + ConstData.USERNAME + ";pwd=" + ConstData.PASSWORD + ";";
            myConn = new MySqlConnection(connetionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from saa_asema.SensorData WHERE reading_time BETWEEN " +
                "'"+ queryStart +"' and '"+ queryEnd + "'", myConn);

            try
            {
                myConn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SensorData");
                dataGridView1.DataSource = ds.Tables["SensorData"]; 
                myConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(MessageStrings.ConnectionFailure + "\n" + ex.Message.ToString());
            }

            int gridCount;
            gridCount = dataGridView1.RowCount;
            
            if (gridCount > 0)
            {
                chartButton.Enabled = true;                
            }
            else
            {
                chartButton.Enabled = false;
                MessageBox.Show(MessageStrings.NoRowsInTimeInterval);
                updateChart();
            }

        }
        
        private void chartButton_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            GetRegardsFromDgv(); 
                      
            //tempSeries.ChartType = SeriesChartType.Column;
            //humSeries.ChartType = SeriesChartType.Column;
            
            tempSeries.Name = MessageStrings.TemperatureSeriesLabel;
            humSeries.Name = MessageStrings.HumiditySeriesLabel;

            chart1.Series.Add(tempSeries);
            chart1.Series.Add(humSeries);
            
            chart1.ChartAreas[0].AxisX.Interval = 1; 
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{dd.MM.yyyy HH.mm}";
            chart1.ChartAreas[0].AxisY.Minimum = -20;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Interval = 20;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelFormat = "{0.0} C";
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[1].LabelFormat = "{0.0} %";
            chart1.ChartAreas[0].Position.Auto = true;
            



            for (int i = 0; i < dataGridView1.Rows.Count  ; i++) 
            {               
                chart1.Series[MessageStrings.TemperatureSeriesLabel].Points.AddXY(array3[i], array1[i]);
                chart1.Series[MessageStrings.HumiditySeriesLabel].Points.AddXY(array3[i], array2[i]);
            }

            updateChart();
            chart1.Series[0].ToolTip = "#VALY{0.0} Celsius\n #VALX{dd/MM/yyyy HH:mm}";
            chart1.Series[1].ToolTip = "#VALY{0.0} % \n #VALX{dd/MM/yyyy HH:mm}";
        }

        public void GetRegardsFromDgv()
        {   //Take data from gridview to arrays.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {                
                string t = (dataGridView1.Rows[i].Cells[3].Value.ToString());
                string h = (dataGridView1.Rows[i].Cells[4].Value.ToString());
                string d = (dataGridView1.Rows[i].Cells[6].Value.ToString());

                float temp = float.Parse(t, NumberStyles.Float, CultureInfo.InvariantCulture);
                float hum = float.Parse(h, NumberStyles.Float, CultureInfo.InvariantCulture);

                DateTime date = DateTime.Parse(d);
                
                array1.Add(temp);
                array2.Add(hum);
                array3.Add(date);
            }
        }

        public void updateChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                chart1.Series[MessageStrings.TemperatureSeriesLabel].Points.AddXY(array3[i], array1[i]);
                chart1.Series[MessageStrings.HumiditySeriesLabel].Points.AddXY(array3[i], array2[i]);
            }
        }

        public void updateDatagridview()
        {
            array1.Clear();
            array2.Clear();
            array3.Clear();
            GetRegardsFromDgv();
        }

        private void IntervalButton_Click(object sender, EventArgs e)
        {
            Setting p = new Setting();
            p.ShowDialog();
        }
    }
}
