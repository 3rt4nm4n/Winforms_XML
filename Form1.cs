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

namespace Winforms_XML_HW
{
    public partial class Form1 : Form
    {
        public XmlWriter xmlw;
        public XmlWriterSettings xmlws;
        
        public XmlDocument xmldoc;
        public string xmlfile = "@xmlhwfile.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Kaydet_Click(object sender, EventArgs e)
        {
            
            
            xmlw = XmlWriter.Create(xmlfile);

            xmlws = new XmlWriterSettings();
            xmlws.ConformanceLevel = ConformanceLevel.Auto;
            xmlw.WriteStartDocument();
            //
            xmlw.WriteStartElement("Info");

            xmlw.WriteStartElement("İsim");
            xmlw.WriteString(TextBox_Isim.Text);
            xmlw.WriteEndElement();
            
            xmlw.WriteStartElement("Soyisim");
            xmlw.WriteString(TextBox_Soyisim.Text);
            xmlw.WriteEndElement();
            xmlw.WriteEndElement();
            
            TextBox_Isim.Text = TextBox_Soyisim.Text = String.Empty;


        }
        private void Form1_Closing(object sender, EventArgs e)
        {

            xmlw.WriteEndDocument();
            xmlw.Close();
        }
    }
}
