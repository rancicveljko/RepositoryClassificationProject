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

namespace WebClientForm
{
    public partial class Form1 : Form
    {
        static HttpClient client;
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
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                //string responseBody = await client.GetStringAsync(uri);

                MessageBox.Show(responseBody);// ovo se ne prikazuje sve ostalo radi
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
