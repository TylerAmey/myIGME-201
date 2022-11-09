using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PE20DomReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            this.webBrowser1.Navigate("C:\\Users\\tyler\\source\\repos\\myIGME-201\\PE20DomReal\\example.html");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;


            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    htmlElementCollection[i].InnerText = "My UFO Info";
                }
                if (i == 1)
                {
                    htmlElementCollection[i].InnerText = "My UFO Pictures";
                }
                if (i == 2)
                {
                    htmlElementCollection[i].InnerText = "";
                }
            }

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #b50404;";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    htmlElementCollection[i].InnerHtml = "Report your UFO sightings here: " + "<a href='http://www.nuforc.org'>http://www.nuforc.org</a>";
                    htmlElementCollection[i].Style += "color: green;";
                    htmlElementCollection[i].Style += "font-weight: bold;";
                    htmlElementCollection[i].Style += "font-size: 2em;";
                    htmlElementCollection[i].Style += "text-transform: uppercase;";
                    htmlElementCollection[i].Style += "text-shadow: 3px 2px #A44;";
                }
                if (i == 1)
                {
                    htmlElementCollection[i].InnerText = "";
                }
                if (i == 2)
                {
                    htmlElementCollection[i].InnerHtml = "<img src='https://i.guim.co.uk/img/media/26b02e1ade06fad41b87e5ef02f65bafb719acda/0_274_4456_2673/master/4456.jpg?width=1200&quality=85&auto=format&fit=max&s=dda86fb77b07ff592c1f2766db30050d'>";
                }
            }

            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerText = "\u00a9 2022 Tyler Amey";
            webBrowser.Document.Body.AppendChild(htmlElement);
        }

    }
}
