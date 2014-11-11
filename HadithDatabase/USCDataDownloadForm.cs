using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HadithDatabase
{
    public partial class USCDataDownloadForm : Form
    {
        public USCDataDownloadForm()
        {
            InitializeComponent();
        }

        private void btnBukhari_Click(object sender, EventArgs e)
        {
            string url = "http://www.usc.edu/org/cmje/religious-texts/hadith/bukhari/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            String strText = "";

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='content']").First();

            foreach ( HtmlNode linkNode in contentNode.SelectNodes("ol/li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");
                strText += linkNode.InnerHtml;

                if (pageLink.Contains("/"))
                    pageLink = pageLink.Substring(pageLink.LastIndexOf("/")+1);

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url+pageLink);

                chapterdoc.Save("..//..//Data//USC//Bukhari//"+ pageLink);
            }
        }

        private void btnMuslim_Click(object sender, EventArgs e)
        {
            string url = "http://www.usc.edu/org/cmje/religious-texts/hadith/muslim/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            String strText = "";

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='content']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("ol/li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");
                strText += linkNode.InnerHtml;

                if (pageLink.Contains("/"))
                    pageLink = pageLink.Substring(pageLink.LastIndexOf("/") + 1);

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + pageLink);

                chapterdoc.Save("..//..//Data//USC//Muslim//" + pageLink);
            }
        }

        private void btnDawud_Click(object sender, EventArgs e)
        {
            string url = "http://www.usc.edu/org/cmje/religious-texts/hadith/abudawud/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            String strText = "";

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='content']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("ol/li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");
                strText += linkNode.InnerHtml;

                if (pageLink.Contains("/"))
                    pageLink = pageLink.Substring(pageLink.LastIndexOf("/") + 1);

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + pageLink);

                chapterdoc.Save("..//..//Data//USC//Dawud//" + pageLink);
            }
        }

        private void btnMuwatta_Click(object sender, EventArgs e)
        {
            string url = "http://www.usc.edu/org/cmje/religious-texts/hadith/muwatta/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            String strText = "";

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='content']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("ul/li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");
                strText += linkNode.InnerHtml;

                if (pageLink.Contains("/"))
                    pageLink = pageLink.Substring(pageLink.LastIndexOf("/") + 1);

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + pageLink);

                chapterdoc.Save("..//..//Data//USC//Muwatta//" + pageLink);
            }
        }

        private void btnIIUMBukhari_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url ="http://www.iium.edu.my/deed/hadith/bukhari";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url+"/index.html");
            
            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//ol").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                 HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//IIUM//Bukhari//" + pageLink);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnIIUMMuslim_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://www.iium.edu.my/deed/hadith/muslim";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load("..//..//Data//Source//iium_muslim.html");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//li").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("ol/li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//IIUM//Muslim//" + pageLink);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnIIUMMuwatta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://www.iium.edu.my/deed/hadith/malik/";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url + "/index.html");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//ol").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("li/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//IIUM//Muwatta//" + pageLink);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSunnahBukhari_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://sunnah.com";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url + "/bukhari");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='book_titles']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("div/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//Sunnah//bukhari//" + pageLink.Substring(pageLink.LastIndexOf("/") + 1) + ".html");
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSunnahMuslim_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://sunnah.com";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url + "/muslim");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='book_titles']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("div/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//Sunnah//Muslim//" + pageLink.Substring(pageLink.LastIndexOf("/") + 1) + ".html");
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSunnahDawud_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://sunnah.com";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url + "/abudawud");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='book_titles']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("div/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//Sunnah//Dawud//" + pageLink.Substring(pageLink.LastIndexOf("/") + 1) + ".html");
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSunnahMuwatta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string url = "http://sunnah.com";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url + "/malik");

            HtmlNode contentNode = doc.DocumentNode.SelectNodes("//div[@class='book_titles']").First();

            foreach (HtmlNode linkNode in contentNode.SelectNodes("div/a"))
            {
                string pageLink = linkNode.GetAttributeValue("href", "");

                HtmlAgilityPack.HtmlDocument chapterdoc = web.Load(url + "/" + pageLink);

                chapterdoc.Save("..//..//Data//Source//Sunnah//Muwatta//" + pageLink.Substring(pageLink.LastIndexOf("/") + 1) + ".html");
            }

            this.Cursor = Cursors.Default;
        }
    }
}
