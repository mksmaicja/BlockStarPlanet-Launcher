using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BSP_Launcher
{
    public partial class Form1 : Form
    {

        private string rootFolder = "c:\\maicjadir\\MKSBSP\\Game\\";
        private string cheatFolder = "c:\\maicjadir\\MKSBSP\\maicjaloadfiles\\";
        WebClient webClient;
        string urlname = "mksteam.ovh";
        public void DownloadFile(string urlAddress, string location)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            checkBoxcheat.Enabled = false;
            checkBoxcheatreinstall.Enabled = false;
            checkBoxgamereinstall.Enabled = false;
            checkBoxnoupdate.Enabled = false;
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                
                Uri URL = new Uri(urlAddress);
                filename = URL.OriginalString;
                foreach (string fr in filename.Split('/'))
                {
                    filename = fr;
                }
                foreach (string fr in filename.Split('\\'))
                {
                    filename = fr;
                }
                filename = " " + filename;
                string directory = "";
                foreach (string fr in location.Split('\\'))
                {
                    directory = fr;
                }
                directory = location.Replace(directory, "");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                sw.Start();

                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    HandleError(ex.Message);
                }
            }
        }
        WebClient webClient34234234 = new WebClient();
        Stopwatch sw = new Stopwatch();
        string filename = "unknown";
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            labeldownload.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00")) + filename + string.Format("\r\n{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            progressBar1.Value = e.ProgressPercentage;
        }


        private async void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("DOWNLOAD CANCELLED");
            }
            sw.Reset();
            cheatdownloaded = true;
            labeldownload.Text = "";
            progressBar1.Value = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            checkBoxcheat.Enabled = true;
            checkBoxcheatreinstall.Enabled = true;
            checkBoxgamereinstall.Enabled = true;
            checkBoxnoupdate.Enabled = true;
        }
        public static string CalculateMD5(string fileName)
        {

            if (!File.Exists(fileName))
            {

                return "ERR";
            }
            try
            {
                using MD5 mD = MD5.Create();
                using FileStream inputStream = File.OpenRead(fileName);
                string text = BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLowerInvariant();

                return text;
            }
            catch (Exception ex)
            {
 
                return "ERR";
            }
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            try
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }
            if (!Directory.Exists(cheatFolder))
            {
                Directory.CreateDirectory(cheatFolder);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxgamereinstall.Checked)
                {
                    Directory.Delete(rootFolder, true);
                    await Task.Delay(1000);
                    Directory.CreateDirectory(rootFolder);
                }
                bool cheatinstall = false;

                if (!Directory.Exists(cheatFolder + "maicjaload"))
                {
                    cheatinstall = true;
                }
                if (!Directory.Exists(cheatFolder + "bibliotekiuzytkownikow"))
                {
                    cheatinstall = true;
                }
                if (!Directory.Exists(cheatFolder + "daneuzytkownikow"))
                {
                    cheatinstall = true;
                }
                if (!Directory.Exists(cheatFolder + "tenizszeodjajamidzwoniacych"))
                {
                    cheatinstall = true;
                }
                if (!File.Exists(cheatFolder + "dobby.dll"))
                {
                    cheatinstall = true;
                }
                if (!File.Exists(cheatFolder + "version.dll"))
                {
                    cheatinstall = true;
                }
                if (checkBoxcheatreinstall.Checked)
                {
                    cheatinstall = true;
                }

                if (cheatinstall && checkBoxcheat.Checked)
                {
                    bool flag = !Directory.Exists("c:\\maicjadir\\temp");
                    if (flag)
                    {
                        Directory.CreateDirectory("c:\\maicjadir\\temp");
                    }

                    bool flag2 = Directory.Exists(rootFolder + "MonoBleedingEdge");
                    if (flag2)
                    {
                        Directory.Delete(rootFolder + "MonoBleedingEdge", true);
                    }
                    if (Directory.Exists(cheatFolder + "maicjaload"))
                    {
                        Directory.Delete(cheatFolder + "maicjaload", true);
                    }
                    if (Directory.Exists(cheatFolder + "bibliotekiuzytkownikow"))
                    {
                        Directory.Delete(cheatFolder + "bibliotekiuzytkownikow", true);
                    }
                    if (Directory.Exists(cheatFolder + "daneuzytkownikow"))
                    {
                        Directory.Delete(cheatFolder + "daneuzytkownikow", true);
                    }
                    if (Directory.Exists(cheatFolder + "tenizszeodjajamidzwoniacych"))
                    {
                        Directory.Delete(cheatFolder + "tenizszeodjajamidzwoniacych", true);
                    }
                    if (File.Exists(cheatFolder + "dobby.dll"))
                    {
                        File.Delete(cheatFolder + "dobby.dll");
                    }
                    if (File.Exists(cheatFolder + "version.dll"))
                    {
                        File.Delete(cheatFolder + "version.dll");
                    }
                    Console.WriteLine("Downloading ZIP...");
                    cheatdownloaded = false;
                    DownloadFile("http://" + urlname + "/hujzdupybtw.zip", "c:\\maicjadir\\temp\\czid.zip");
                    while (!cheatdownloaded)
                    {
                        await Task.Delay(1000);
                    }
                    await Task.Delay(100);
                    Console.WriteLine("Installing...");
                    ZipFile.ExtractToDirectory("c:\\maicjadir\\temp\\czid.zip", cheatFolder);
                }
                if (checkBoxcheat.Checked)
                {
                    try
                    {
                        CopyFilesRecursively(cheatFolder, rootFolder);
                    }
                    catch (Exception) { }
                }
                else
                {
                    if (Directory.Exists(rootFolder + "maicjaload"))
                    {
                        Directory.Delete(rootFolder + "maicjaload", true);
                    }
                    if (Directory.Exists(rootFolder + "bibliotekiuzytkownikow"))
                    {
                        Directory.Delete(rootFolder + "bibliotekiuzytkownikow", true);
                    }
                    if (Directory.Exists(rootFolder + "daneuzytkownikow"))
                    {
                        Directory.Delete(rootFolder + "daneuzytkownikow", true);
                    }
                    if (Directory.Exists(rootFolder + "tenizszeodjajamidzwoniacych"))
                    {
                        Directory.Delete(rootFolder + "tenizszeodjajamidzwoniacych", true);
                    }
                    if (File.Exists(rootFolder + "dobby.dll"))
                    {
                        File.Delete(rootFolder + "dobby.dll");
                    }
                    if (File.Exists(rootFolder + "version.dll"))
                    {
                        File.Delete(rootFolder + "version.dll");
                    }
                }


                if (!checkBoxnoupdate.Checked)
                {
                    string updaterDomain = "https://blockstarplanet.com/";
                    string addresslaunchewr = updaterDomain + "launcher/v4/content.txt";
                    string zabijsie = webClient34234234.DownloadString(addresslaunchewr);
                    foreach (string line in zabijsie.Split('\n'))
                    {
                        cheatdownloaded = false;
                        string[] fr1 = line.Split('|');
                        string localmd5 = CalculateMD5(rootFolder + fr1[0]);
                        try
                        {
                            if (!line.Contains("BlockStarPlanet_Launcher.exe"))
                            {
                                if (localmd5 != fr1[1])
                                {
                                    DownloadFile(updaterDomain + fr1[2], rootFolder + fr1[0]);
                                    while (!cheatdownloaded)
                                    {
                                        await Task.Delay(50);
                                    }
                                }
                            }
                        }
                        catch (Exception ex) { }
                    }
                }
                if (Directory.Exists(rootFolder + "MonoBleedingEdge"))
                {
                    Directory.Delete(rootFolder + "MonoBleedingEdge", true);
                }
                string text9 = rootFolder + "BlockStarPlanet.exe";
                System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = text9,
                    WorkingDirectory = rootFolder,

                };
                Process fr = new Process();
                fr.StartInfo = startinfo;
                fr.Start();
                fr.Close();
                File.Delete(rootFolder + "BlockStarPlanet_Launcher.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }

        }
        public static void HandleError(string error)
        {
            errortext = error;
            var fr = new error();
            fr.Show();
        }
        public static string errortext = "";
        public static bool cheatdownloaded = false;
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            cheatdownloaded = false;
            DownloadFile("http://"+urlname+"/hwids/netcore.exe", "c:\\maicjadir\\netcore.exe");
            while (!cheatdownloaded)
            {
                await Task.Delay(1000);
            }
            await Task.Delay(100);
            Console.WriteLine("Installing...");
            Process.Start("c:\\maicjadir\\netcore.exe");
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpClient clienthttp = new HttpClient();
            try
            {
                clienthttp.Timeout = TimeSpan.FromSeconds(2);
                await clienthttp.GetAsync("http://" + urlname + "/index.html");
            }
            catch (Exception)
            {
                urlname = "dev.mksteam.ovh";
            }
        }
    }
}
