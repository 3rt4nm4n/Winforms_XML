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

namespace Winforms_XML_HW
{
    public partial class Form1 : Form
    {
        public XmlWriter xmlw;
        public XmlWriterSettings xmlws;
        
        public XmlDocument xmldoc;
        public string xmlfile = "@xmlhwfile.xml";
        public bool chk = false;
        public Form1()
        {
            InitializeComponent();
        }
        XDocument xmldo;
        private void Button_Kaydet_Click(object sender, EventArgs e)
        {

            if (chk == false)
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

                
                xmlw.WriteEndDocument();
                xmlw.Close();
                chk = true;
                EmptyTextBoxes();
            }
            else
            {
                string path = @xmlfile;
                xmldo = new XDocument();
                xmldo = XDocument.Load(path);
                xmldo.Root.Add(new XElement("Info",
                    new XElement("İsim", TextBox_Isim.Text),
                    new XElement("Soyisim", TextBox_Soyisim.Text)

                    ));
                xmldo.Save(path);
                EmptyTextBoxes();

            }
               

        }
        public void EmptyTextBoxes()
        {
            TextBox_Isim.Text = TextBox_Soyisim.Text = String.Empty;
        }
    }
}
