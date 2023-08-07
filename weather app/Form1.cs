using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace weather_app
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "423c287c8d7997a2b4c50a473c3182e4"; // Replace with your OpenWeatherMap API key
        public Form1()
        {
            InitializeComponent();
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           guna2VProgressBar1.AutoRoundedCorners = true;

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            guna2TextBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox2.BackColor= Color.White;
        }

       

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string city = guna2TextBox1.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
                    string json = webClient.DownloadString(url);
                    dynamic result = JsonConvert.DeserializeObject(json);
                    string weatherDescription = result.weather[0].description;
                   double temperature = result.main.temp;
                    int visibility1 = result.visibility;
                    int humidity1 = result.main.humidity;
                    int sea_level1 = result.main.pressure;
                    double pressure1 = result.wind.speed;
                    string city1 = result.sys.name;
                    label1.Text = $"{city}";
                    label3.Text = $"{weatherDescription}";
                    guna2HtmlLabel4.Text = $" {visibility1}";
                    guna2HtmlLabel3.Text = $" {humidity1}%";
                    guna2HtmlLabel5.Text = $" {sea_level1}";
                    label2.Text = $"{temperature} °C";
                    guna2HtmlLabel2.Text = $"{pressure1} ";
                    guna2VProgressBar1.Value = Convert.ToInt32(temperature);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2VProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string city = textBox1.Text.Trim();
        //    if (string.IsNullOrEmpty(city))
        //    {
        //        MessageBox.Show("Please enter a city name.");
        //        return;
        //    }
        //    try
        //    {
        //        using(WebClient webClient = new WebClient())
        //        {
        //            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
        //            string json = webClient.DownloadString(url);
        //            dynamic result = JsonConvert.DeserializeObject(json);
        //            string weatherDescription = result.weather[0].description;
        //            double temperature = result.main.temp;
        //            int visibility1 = result.visibility;
        //            double pressure1 = result.wind.speed;
        //            label5.Text = $"{weatherDescription}";
        //            label6.Text = $" {visibility1}";
        //            label4.Text = $"{temperature} °C";
        //            label9.Text = $"{pressure1} ";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}
    }
}
