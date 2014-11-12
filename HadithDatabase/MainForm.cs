using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace HadithDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void uSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USCDataDownloadForm frm = new USCDataDownloadForm();

            frm.MdiParent = this;

            frm.Show();
        }

        private void WriteToFile(string HadithContent, string TargetFileName)
        {
            StreamWriter fs = File.CreateText(TargetFileName);

            fs.Write(HadithContent);

            fs.Close();
        }

        private void bukhariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DirectoryInfo directoryInfo = new DirectoryInfo("..//..//Data//Source//USC//Bukhari//");
            HtmlAgilityPack.HtmlDocument hadithFile = new HtmlAgilityPack.HtmlDocument();

            List<SourceHadithClass> HadithCollection = new List<SourceHadithClass>();

            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfo = directoryInfo.GetFiles();

                foreach (FileInfo file in fileInfo)
                {
                    hadithFile.Load(file.FullName);

                    if (hadithFile.DocumentNode.SelectNodes("//div[@class='content']") != null)
                    {
                        HtmlNode contentNode = hadithFile.DocumentNode.SelectNodes("//div[@class='content']").First();

                        HtmlNodeCollection referenceNodes = contentNode.SelectNodes("//a[@name]");
                        HtmlNodeCollection quoteNodes = contentNode.SelectNodes("//blockquote");

                        //SourceHadithClass[] HadithCollection = new SourceHadithClass[referenceNodes.Count];

                        for (int iCounter = 0; iCounter < referenceNodes.Count; iCounter++)
                        {
                            SourceHadithClass Hadith = new SourceHadithClass();

                            Hadith.index = HadithCollection.Count;
                            Hadith.source = "Bukari";
                            Hadith.reference = referenceNodes[iCounter].Attributes[0].Value;
                            Hadith.quote = quoteNodes[iCounter].InnerHtml;
                            HadithCollection.Add(Hadith);
                        }
                    }
                }
                
                string output = JsonConvert.SerializeObject(HadithCollection, Formatting.Indented);

                //WriteToFile(output, "..//..//Data//Clean//USC//Bukhari//" + file.Name.Substring(0, file.Name.Length - 4) + ".json");
                WriteToFile(output, "..//..//Data//Clean//USC//usc_bukhari.json");
            }

            this.Cursor = Cursors.Default;
        }



        private void muslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DirectoryInfo directoryInfo = new DirectoryInfo("..//..//Data//Source//USC//Muslim//");
            HtmlAgilityPack.HtmlDocument hadithFile = new HtmlAgilityPack.HtmlDocument();

            List<SourceHadithClass> HadithCollection = new List<SourceHadithClass>();

            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfo = directoryInfo.GetFiles();

                foreach (FileInfo file in fileInfo)
                {
                    hadithFile.Load(file.FullName);

                    if (hadithFile.DocumentNode.SelectNodes("//div[@class='content']") != null)
                    {
                        HtmlNode contentNode = hadithFile.DocumentNode.SelectNodes("//div[@class='content']").First();

                        HtmlNodeCollection referenceNodes = contentNode.SelectNodes("//a[@name]");
                        HtmlNodeCollection quoteNodes = contentNode.SelectNodes("//blockquote");

                        //SourceHadithClass[] HadithCollection = new SourceHadithClass[referenceNodes.Count];

                        for (int iCounter = 0; iCounter < referenceNodes.Count; iCounter++)
                        {
                            SourceHadithClass Hadith = new SourceHadithClass();

                            Hadith.index = HadithCollection.Count;
                            Hadith.source = "Muslim";
                            Hadith.reference = referenceNodes[iCounter].Attributes[0].Value;
                            Hadith.quote = quoteNodes[iCounter].InnerHtml;
                            HadithCollection.Add(Hadith);
                        }
                    }
                }

                string output = JsonConvert.SerializeObject(HadithCollection, Formatting.Indented);

                WriteToFile(output, "..//..//Data//Clean//USC//usc_muslim.json");
            }

            this.Cursor = Cursors.Default;
        }

        private void bukhariToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateSunnahJSONFile("..//..//Data//Source//Sunnah//Bukhari//", "..//..//Data//Clean//Sunnah//sunnah_bukhari.json", "Bukhari");
        }

        private void muslimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateSunnahJSONFile("..//..//Data//Source//Sunnah//Muslim//", "..//..//Data//Clean//Sunnah//sunnah_muslim.json", "Muslim");
        }

        private void GenerateSunnahJSONFile(string srcDirectory, string targetFileName, string source)
        {
            this.Cursor = Cursors.WaitCursor;

            DirectoryInfo directoryInfo = new DirectoryInfo(srcDirectory);
            HtmlAgilityPack.HtmlDocument hadithFile = new HtmlAgilityPack.HtmlDocument();

            List<SourceHadithClass> HadithCollection = new List<SourceHadithClass>();

            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfo = directoryInfo.GetFiles();

                foreach (FileInfo file in fileInfo)
                {
                    hadithFile.Load(file.FullName);

                    if (hadithFile.DocumentNode.SelectNodes("//div[@class='actualHadithContainer']") != null)
                    {
                        HtmlNodeCollection contentNodes = hadithFile.DocumentNode.SelectNodes("//div[@class='actualHadithContainer']");

                        foreach (HtmlNode contentNode in contentNodes)
                        {
                            String narrator = "";

                            if (contentNode.SelectNodes("div/div/div[@class='hadith_narrated']") != null)
                            {
                                HtmlNode narratorNode = contentNode.SelectNodes("div/div/div[@class='hadith_narrated']").First();

                                // Remove leading whitespaces & "Narrated " text
                                narrator = narratorNode.InnerText.Trim().Substring(9);

                                // Remove ":" from the end, if found
                                if (narrator.LastIndexOf(":") > -1)
                                    narrator = narrator.Substring(0, narrator.LastIndexOf(":"));
                            }

                            HtmlNode quoteNode = contentNode.SelectNodes("div/div/div[@class='text_details']").First();

                            SourceHadithClass Hadith = new SourceHadithClass();

                            Hadith.index = HadithCollection.Count;
                            Hadith.source = source;
                            Hadith.reference = contentNode.Attributes[1].Value;

                            Hadith.narrators = new String[] { narrator };

                            String quote = quoteNode.InnerHtml.Trim();
                            quote = quote.Replace("\n", "");
                            quote = quote.Replace("\r", "");

                            Hadith.quote = quote;

                            HadithCollection.Add(Hadith);
                        }
                    }
                }

                string output = JsonConvert.SerializeObject(HadithCollection, Formatting.Indented);

                WriteToFile(output, targetFileName);
            }

            this.Cursor = Cursors.Default;
        }
    }
}
