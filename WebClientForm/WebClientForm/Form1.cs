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
        string outputXml = @"..\..\..\Resources\UnprocessedXMLs";
        string apiUri = "";
        string outputFileName = "";
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void btnSendCall_Click(object sender, EventArgs e)
        {

            // Objasnjeno na https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {

                HttpResponseMessage response = await client.GetAsync(apiUri);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                File.WriteAllText(outputXml + '\\' + outputFileName + ".xml", responseBody);
                //StreamWriter file = new StreamWriter(outputXml + '\\' + outputFileName + ".xml", append: true);
                //await file.WriteAsync(responseBody);
                MessageBox.Show("Success", "WARNING");
            }
        }

        private void cbApiUri_SelectedIndexChanged(object sender, EventArgs e)
        {
            apiUri = cbApiUri.SelectedItem.ToString();
        }

        private void tbFileName_TextChanged(object sender, EventArgs e)
        {
            outputFileName = tbFileName.Text;
        }
    }
}
