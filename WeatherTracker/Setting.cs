using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using WeatherTracker.Data;
using MessageStrings = WeatherTracker.Data.WeatherTracker;

namespace WeatherTracker
{
    public partial class Setting : Form
    {
       
        public Setting()
        {
            InitializeComponent();
            try
            {
                WebClient client = new WebClient();
                string response = client.DownloadString(ConstData.GETINTERVALURL);
                
                currentInterval.Text = parseValue(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MessageStrings.ConnectionFailure + "\n" + ex.Message.ToString());
                
            }
        }

        private void asetaUusi_Click(object sender, EventArgs e)
        {
            
            WebClient client = new WebClient();
            string input = inputBox.Text;                
            string response = client.DownloadString(ConstData.SETINTERVALURL+input);
            response = client.DownloadString(ConstData.GETINTERVALURL);
            currentInterval.Text = parseValue(response);
            

        }

        private string parseValue(string str)
        {
            string strIn = str;
            String searchString = "#";
            int startIndex = str.IndexOf(searchString)+1;
            int endIndex = str.LastIndexOf(searchString) - 1;
            String substring = str.Substring(startIndex, endIndex + searchString.Length - startIndex);

            return substring;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
