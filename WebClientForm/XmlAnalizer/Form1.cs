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
using System.Xml.Linq;

namespace XmlAnalizer
{
    public partial class frmXmlAnalizer : Form
    {
        string[] categoriesString = { "Education", "Science", "Math" };//dopuni
        string[] xmlAttrNames = { "Category", "Tags", "Title", "Description" };
        List<string> categories;
        
        string inputFileFullPath = "";
        string outputBaseFolderPath = @"..\..\..\Resources\Categories\";
        string inputFolderPath= @"..\..\..\Resources\UnprocessedXMLs";
        public frmXmlAnalizer()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = inputFolderPath;
            categories = categoriesString.ToList();
        }

        // prodji kroz https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=net-6.0
        private void btnCategorize_Click(object sender, EventArgs e)
        {
            try
            {
                XElement fullXmlFile = XElement.Load(inputFileFullPath);

                IEnumerable<XElement> presentations = from pres in fullXmlFile.Descendants()
                                                      select pres;

                foreach (var pres in presentations)
                {
                    bool categorized = false;
                    foreach (var attr in xmlAttrNames)
                    {
                        if (pres.Element(attr) == null)
                            continue;
                        foreach (var category in categories)
                        {
                            if (pres.Element(attr).Value.Contains(category))
                            {
                                // add presentation to category
                                // which means
                                // take XElement and make it into a separate xml file

                                Categorize(pres, category);

                                //string fileName = pres.Element("Title").Value;
                                //string outputFolderPath = Path.Combine(outputBaseFolderPath, category);
                                //string outputFilePathFull = Path.Combine(outputFolderPath, fileName);

                                //Directory.CreateDirectory(outputFolderPath);

                                //pres.Save(outputFilePathFull);

                                categorized = true;
                            }
                        }
                    }

                    if (categorized == false && pres.Element("Category") != null)
                    {
                        categories.Add(pres.Element("Category").Value);
                        Categorize(pres, pres.Element("Category").Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFileFullPath = openFileDialog.FileName;
                tbFilePath.Text = inputFileFullPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XElement fullXmlFile = XElement.Load(inputFileFullPath);

                IEnumerable<XElement> presentations = from pres in fullXmlFile.Descendants()
                                                      select pres;
                
                foreach (var pres in presentations)
                {
                    bool categorized = false;
                    foreach (var attr in xmlAttrNames)
                    {
                        if (pres.Element(attr) == null)
                            continue;
                        foreach (var category in categories)
                        {
                            if(pres.Element(attr).Value.Contains(category))
                            {
                                // add presentation to category
                                // which means
                                // take XElement and make it into a separate xml file

                                Categorize(pres, category);

                                //string fileName = pres.Element("Title").Value;
                                //string outputFolderPath = Path.Combine(outputBaseFolderPath, category);
                                //string outputFilePathFull = Path.Combine(outputFolderPath, fileName);

                                //Directory.CreateDirectory(outputFolderPath);

                                //pres.Save(outputFilePathFull);
                                
                                categorized = true;
                            }
                        }
                    }

                    if (categorized == false && pres.Element("Category") != null)
                    {
                        categories.Add(pres.Element("Category").Value);
                        Categorize(pres, pres.Element("Category").Value);
                    }
                }

                MessageBox.Show("Kategorizacija gotova! Pogledajte Categories folder.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Categorize(XElement elem, string category)
        {
            string fileName = elem.Element("Title").Value;
            fileName = ValidateFileName(fileName);
            fileName += ".xml";

            string outputFolderPath = Path.Combine(outputBaseFolderPath, category);
            string outputFilePathFull = Path.Combine(outputFolderPath, fileName); // NE MOZE | u filename nadji zamenu

            Directory.CreateDirectory(outputFolderPath);

            elem.Save(outputFilePathFull);
        }

        private string ValidateFileName(string filename)
        {
            char[] illegalChars = { '|', '<', '>', ':', '"', '/', '\\', '?', '*' };
            foreach (var illChar in illegalChars)
            {
                if(filename.Contains(illChar))
                {
                    filename = filename.Replace(illChar, '_');
                }
            }
            return filename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "File name | nesto drugo";
            fileName = ValidateFileName(fileName);
            MessageBox.Show(fileName);
        }
    }
}
