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

namespace JavaKidz
{
    public partial class JavaKidz : Form
    {
        public JavaKidz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get updated links
            outputBox.Items.Add("Grabbing updated download links...");
            string optifineLink = "";
            string portalLink = "";
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/RoNubThe3rd/JavaKidz/master/JavaKidz/DLinks/optifine.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                optifineLink = reader.ReadToEnd();
            }
            catch { outputBox.Items.Add("Cannot grab download link for OptiFine, please contact the JKInstaller developer..."); }
            try
            {

                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/RoNubThe3rd/JavaKidz/master/JavaKidz/DLinks/portal.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                portalLink = reader.ReadToEnd();
            }
            catch { outputBox.Items.Add("Cannot grab download link for JKPortal, please contact the JKInstaller developer..."); }
            string modsFolder = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + @"AppData\Roaming\.minecraft\mods";
            string resourceFolder = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + @"AppData\Roaming\.minecraft\resourcepacks";
            //OptiFine
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += ProgressChanged;
                try
                {
                    wc.DownloadFile( //OptiFine Download
                                     // Param1 = Link of file
                        new System.Uri(optifineLink),
                        // Param2 = Path to save
                        modsFolder + @"\OptiFine 1.17.1 HD U H1.jar"
                    ); outputBox.Items.Add("Completed installation of OptiFine...");
                }
                catch { outputBox.Items.Add("Could not install OptiFine..."); }
            }
            //JKPortal
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += ProgressChanged;
                try
                {
                    wc.DownloadFile( //JKPortal Download
                        new System.Uri(portalLink),
                        modsFolder + @"\JKPortal 1.0.7.jar"
                    ); outputBox.Items.Add("Completed installation of JKPortal...");
                }
                catch { outputBox.Items.Add("Could not install JKPortal..."); }

            }
            //OptiFabric
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += ProgressChanged;
                try
                {
                    wc.DownloadFile( //OptiFabric Download
                        new System.Uri("https://www.curseforge.com/minecraft/mc-mods/optifabric/download/3422922/file"),
                        modsFolder + @"\OptiFabric 1.11.20.jar"
                    ); outputBox.Items.Add("Completed installation of OptiFabric");
                }
                catch
                {
                    outputBox.Items.Add("Could not install OptiFabric...");
                    outputBox.Items.Add("CurseForge may have blocked the download since I am a 'bot', attempting to download from backup link...");
                    try
                    {
                        wc.DownloadFile( //OptiFabric Download
                            new System.Uri("https://download1585.mediafire.com/hgetjchkqwqg/xt4zso1ury8th15/optifabric-1.11.20.jar"),
                            modsFolder + @"\OptiFabric 1.11.20.jar"
                        ); outputBox.Items.Add("Completed installation of OptiFabric from backup MediaFire link!");
                    }
                    catch
                    {
                        outputBox.Items.Add("Could not install OptiFabric from backup link.");
                        outputBox.Items.Add("You will have to download and install the file manually.");
                    }
                }
            }
            //Resource Pack
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += ProgressChanged;
                try
                {
                    wc.DownloadFileAsync( //Resource Pack Download
                    new System.Uri("https://github.com/RoNubThe3rd/jk/raw/ResourcePack/Javakidz_Test_1.0.5.zip"),
                    resourceFolder + @"\§6Java§8Kidz §7Resources.zip"
                ); outputBox.Items.Add("Completed installation of resource pack...");
                }
                catch { outputBox.Items.Add("Could not install resource pack..."); }

            }
            outputBox.Items.Add("Completed installations!");
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void JavaKidz_Load(object sender, EventArgs e)
        {

        }
    }
}