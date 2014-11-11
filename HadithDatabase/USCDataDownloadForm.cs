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
    }
}
