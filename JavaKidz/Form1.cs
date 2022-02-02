using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using static System.Environment;

namespace JavaKidz
{
    public partial class JavaKidz : Form
    {
        public JavaKidz()
        {
            InitializeComponent();

        }
        string mcFolder = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + @"AppData\Roaming\.minecraft";
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting new thread...");
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                downloadManager();
            }).Start();
        }

        private void downloadManager()
        {
            string modsFolder = mcFolder + @"\" + "mods";
            string resourceFolder = mcFolder + @"\" + "resourcepacks";
            //Get updated links
            Console.WriteLine("Grabbing updated download links...");
            string optifineLink = "";
            string portalLink = "";
            string optifabricLink = "";
            string packLink = "";
            string fabricAPILink = "";
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/GitZorua/JavaKidz/master/JavaKidz/DLinks/optifine.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                optifineLink = reader.ReadToEnd();
                Console.WriteLine("- Got up-to-date link for OptiFine.");
            }
            catch { Console.WriteLine("Cannot grab download link for OptiFine, please contact the JKInstaller developer..."); }
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/GitZorua/JavaKidz/master/JavaKidz/DLinks/portal.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                portalLink = reader.ReadToEnd();
                Console.WriteLine("- Got up-to-date link for JKPortal.");
            }
            catch { Console.WriteLine("Cannot grab download link for JKPortal, please contact the JKInstaller developer..."); }
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/GitZorua/JavaKidz/master/JavaKidz/DLinks/optifabric.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                optifabricLink = reader.ReadToEnd();
                Console.WriteLine("- Got up-to-date link for OptiFabric.");
            }
            catch { Console.WriteLine("Cannot grab download link for OptiFabric, please contact the JKInstaller developer..."); }
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/GitZorua/JavaKidz/master/JavaKidz/DLinks/pack.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                packLink = reader.ReadToEnd();
                Console.WriteLine("- Got up-to-date link for the resource pack.");
            }
            catch { Console.WriteLine("Cannot grab download link for JavaKidz resource pack, please contact the JKInstaller developer..."); Console.WriteLine("I blame Frow ^"); }
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/GitZorua/JavaKidz/master/JavaKidz/DLinks/fabricAPI.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                fabricAPILink = reader.ReadToEnd();
                Console.WriteLine("- Got up-to-date link for Fabric API.");
            }
            catch { Console.WriteLine("Cannot grab download link for FabricAPI, please contact the JKInstaller developer..."); }


            //OptiFine
            using (WebClient wc = new WebClient())
            {
                //wc.DownloadProgressChanged += ProgressChanged;
                Console.WriteLine("Downloading OptiFine...");
                //try
                //{
                //    wc.DownloadFile( //OptiFine Download
                //        // Param1 = Link of file
                //        new System.Uri(optifineLink),
                //        // Param2 = Path to save
                //        modsFolder + @"\OptiFine 1.17.1 HD U H1.jar"
                //   ); Console.WriteLine("Completed installation of OptiFine...");
                //}
                //catch { Console.WriteLine("> Could not install OptiFine..."); }
                DialogResult res = MessageBox.Show("OptiFine requires that you personally download the file from their site. Robots aren't allowed there... :,(", "Manual Installation Required", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(optifineLink);
                    Console.WriteLine("Completed installation of OptiFine...");
                } else
                {
                    Console.WriteLine("> Resuming without OptiFine");
                }
            }
            //JKPortal
            using (WebClient wc = new WebClient())
            {
                //wc.DownloadProgressChanged += ProgressChanged;
                Console.WriteLine("Downloading JKPortal...");
                try
                {
                    wc.DownloadFile( //JKPortal Download
                        new System.Uri(portalLink),
                        modsFolder + @"\JKPortal 1.0.7.jar"
                    ); Console.WriteLine("Completed installation of JKPortal...");
                }
                catch { Console.WriteLine("> Could not install JKPortal..."); }

            }
            //OptiFabric
            using (WebClient wc = new WebClient())
            {
                //wc.DownloadProgressChanged += ProgressChanged;
                Console.WriteLine("Downloading OptiFabric...");
                try
                {
                    wc.DownloadFile( //OptiFabric Download
                        new System.Uri(optifabricLink),
                        modsFolder + @"\OptiFabric 1.11.20.jar"
                    ); Console.WriteLine("Completed installation of OptiFabric");
                }
                catch
                {
                    Console.WriteLine("> Could not install OptiFabric...");
                    Console.WriteLine("CurseForge may have blocked the download since I am a 'bot', attempting to download from backup link...");
                    try
                    {
                        wc.DownloadFile( //OptiFabric Download
                            new System.Uri("https://download1585.mediafire.com/hgetjchkqwqg/xt4zso1ury8th15/optifabric-1.11.20.jar"), //this'll eventually change and not work anymore, f
                            modsFolder + @"\OptiFabric 1.11.20.jar"
                        ); Console.WriteLine("Completed installation of OptiFabric from backup MediaFire link!");
                    }
                    catch
                    {
                        Console.WriteLine("> Could not install OptiFabric from backup link.");
                        Console.WriteLine("You will have to download and install the file manually.");
                    }
                }
            }
            //Resource Pack
            using (WebClient wc = new WebClient())
            {
                //wc.DownloadProgressChanged += ProgressChanged;
                Console.WriteLine("Downloading JavaKidz Resource Pack...");
                try
                {
                    wc.DownloadFile( //Resource Pack Download
                    new System.Uri(packLink),
                    resourceFolder + @"\§6Java§8Kidz §7Resources.zip"
                ); Console.WriteLine("Completed installation of resource pack...");
                }
                catch { Console.WriteLine("> Could not install resource pack..."); }

            }

            //FabricAPI
            if (dOptions_fabricAPI.Checked)
            {
                using (WebClient wc = new WebClient())
                {
                    //wc.DownloadProgressChanged += ProgressChanged;
                    Console.WriteLine("Downloading Fabric API...");
                    try
                    {
                        wc.DownloadFile( //Fabric API Download
                        new System.Uri(fabricAPILink),
                        modsFolder + @"\Fabric API.jar"
                    ); Console.WriteLine("Completed installation of Fabric API...");
                    }
                    catch { Console.WriteLine("> Could not install Fabric API..."); }

                }
            }
            Console.WriteLine("Completed installations!");
        }


        //private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        //{
        //    Console.WriteLine(e.ProgressPercentage+"%");
        //}

        private void JavaKidz_Load(object sender, EventArgs e)
        {
            RichTextBoxWriter output = new RichTextBoxWriter(outputBox);
            Console.SetOut(output);
            Console.SetError(output);
            Console.WriteLine("> > Welcome to the JavaKidz Installer! < <");
            dirBox.Text = mcFolder;

        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            outputBox.SelectionStart = outputBox.Text.Length;
            outputBox.ScrollToCaret();
        }

        public delegate void StringArgReturningVoidDelegate(string text);
        public class RichTextBoxWriter : TextWriter
        {
            private readonly RichTextBox _richTextBox;
            public RichTextBoxWriter(RichTextBox richTexttbox)
            {
                _richTextBox = richTexttbox;
            }

            public override void Write(char value)
            {
                SetText(value.ToString());
            }

            public override void Write(string value)
            {
                SetText(value);
            }

            public override void WriteLine(char value)
            {
                SetText(value + Environment.NewLine);
            }

            public override void WriteLine(string value)
            {
                SetText(value + Environment.NewLine);
            }

            public override Encoding Encoding => Encoding.ASCII;

            //Write to your UI object in thread safe way:
            private void SetText(string text)
            {
                // InvokeRequired required compares the thread ID of the  
                // calling thread to the thread ID of the creating thread.  
                // If these threads are different, it returns true.  
                if (_richTextBox.InvokeRequired)
                {
                    var d = new StringArgReturningVoidDelegate(SetText);
                    _richTextBox.Invoke(d, text);
                }
                else
                {
                    _richTextBox.Text += text;
                }
            }
        }

        private void outputBox_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void dirButton_Click(object sender, EventArgs e)
        {
            folderBrowser.SelectedPath = mcFolder;
            DialogResult res = folderBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                Console.WriteLine("+ Selected new directory.");
                dirBox.Text = folderBrowser.SelectedPath;
            }
        }
    }
}