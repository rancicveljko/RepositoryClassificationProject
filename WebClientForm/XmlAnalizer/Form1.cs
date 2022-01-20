using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlAnalizer
{
    public partial class frmXmlAnalizer : Form
    {
        string[] categories = { "Education", "Science", "Math" };//dopuni
        string[] xmlAttrNames = { "Category", "Tags", "Title", "Description" };
        
        string inputFileFullPath = @"E:\Rabote za fax\IV\TZPU\authorstreamXMLSample.xml";
        string outputBaseFolderPath = @"..\..\..\Resources\Categories\";
        string inputFolderPath= @"..\..\..\Resources\UnprocessedXMLs";
        public frmXmlAnalizer()
        {
            InitializeComponent();
        }

        // prodji kroz https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=net-6.0
        private void btnCategorize_Click(object sender, EventArgs e)
        {
            var currSearchedAttrName = xmlAttrNames[0];

            XmlDocument doc = new XmlDocument();
            doc.Load(inputFileFullPath);

            XmlNode root = doc.ChildNodes[1];//<Presentations>
            var currNode = root.FirstChild;//<Presentation>
            var children = currNode.ChildNodes;
            
            //MOZE DA SE OBRADJUJE KAO STABLO
            //A NE KAO MATRICA
            foreach (XmlNode child in children) // iterate through all childer in depth 2
            {
                foreach (var attrName in xmlAttrNames) // check if child contains any of searched for elements
                {
                    if (child.Name == attrName) // if it does
                    {
                        foreach (var item in categories) // check if its value contains any of searched words
                        {
                            if (child.InnerText.Contains(item)) // if it does, categorize it
                            {
                                // add presentation to category
                                
                                string fullFolderPath = outputBaseFolderPath + item;
                                Directory.CreateDirectory(fullFolderPath);

                                var filename = inputFileFullPath.Split('\\').Last();
                                var outputFileFullPath = fullFolderPath + "\\" + filename;
                                
                                File.Copy(inputFileFullPath, outputFileFullPath);
                            }
                        }
                    }
                }
                
            }


            
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFileFullPath = openFileDialog.SafeFileName;
                tbFilePath.Text = inputFileFullPath;
            }
        }
    }
}
