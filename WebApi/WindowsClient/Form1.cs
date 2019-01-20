using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/FirstWebApi/api");
                var response = await client.GetAsync("api/mtt");
                var result = await response.Content.ReadAsStringAsync();
                label1.Text = result;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/FirstWebApi/api");
                var response = await client.GetAsync("api/mtt/1");
                var result = await response.Content.ReadAsStringAsync();
                label1.Text = result;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/FirstWebApi/api");
                var response = await client.GetAsync("api/mtt/0");
                var result = await response.Content.ReadAsStringAsync();
                label1.Text = result;
            }
        }
    }
}
