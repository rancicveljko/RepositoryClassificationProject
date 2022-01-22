using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientForm
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        string responseBody = "";
        string outputXml = @"C:\Users\AleksandarKrstic\Desktop\17382veljkorancic-2021-la-1-klasifikacija-prezentacija-iz-javnih-repozitorijuma-b955e2b6f165\WebClientForm\Resources\UnprocessedXMLs";
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void btnSendCall_Click(object sender, EventArgs e)
        {

            //PRIMER
            // Objasnjeno na https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
               
                    HttpResponseMessage response = await client.GetAsync("http://api.authorstream.com/GetTagBasedPresentations.ashx?UserName=veljko.rancic@elfak.rs&Password=!Nesto123&DeveloperKey=qSsHNAgz/v0=&Tag=funny");
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
       
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                StreamWriter file = new StreamWriter(outputXml + @"\Motors.xml", append: true);
                await file.WriteLineAsync(responseBody);
                MessageBox.Show("Success", "WARNING");

            }
        }


    }
}
