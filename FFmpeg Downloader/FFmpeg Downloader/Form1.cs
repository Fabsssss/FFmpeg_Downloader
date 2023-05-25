using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;

namespace FFmpeg_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "https://aniworld.to/anime/stream/one-piece/staffel-1/episode-1";
            label14.Text = "C:\\Users\\fabs\\Desktop\\englisch";
            button6_Click(null, null);
            string value = "";
            value = Environment.GetEnvironmentVariable("PATH");
            if (value.Contains("ffmpeg"))
            {
                btn_variable.BackColor = Color.Green;
            }
            if (Directory.Exists("C:\\ffmpeg"))
            {
                btn_c.BackColor = Color.Green;
            }
        }

        public static string get_link(string url)
        {
            string befehl = " -i " + '"'.ToString() + url + '"'.ToString() + " -bsf:a aac_adtstoasc -vcodec copy -c copy -crf 50 ";
            return befehl;
        }



        public static string getSavedHtmlCode(string url)
        {
            string html = string.Empty;
            try
            {
                var request = System.Net.HttpWebRequest.Create(string.Format("{0}", url));
                request.Method = "GET";
                var response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                html = readStream.ReadToEnd();
                Console.WriteLine("Response stream received.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            string[] speicher;
            try
            {
                speicher = (html.Split("const sources = {")[1]).Split("'");
            }
            catch
            {
                try
                {
                    speicher = (html.Split("var sources = {")[1]).Split("'");
                }
                catch
                {
                    MessageBox.Show("Fehler aufgetreten 1");
                    return html;
                }
            }
            foreach (string s in speicher)
            {
                if (s.Contains("m3u8"))
                {
                    return s;
                }
            }
            MessageBox.Show("Fehler aufgetreten 2");
            return html;
        }


        private void download_start(string argument)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.CreateNoWindow = false;
            psi.UseShellExecute = false;
            psi.FileName = "ffmpeg.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Arguments = argument;
            using (Process ep = Process.Start(psi))
            {
                ep.WaitForExit();
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            //tb_generieter_link.Text = getfilename(tb_link.Text);
        }

        public static string getfilename(string url)
        {
            string html = string.Empty;
            try
            {
                var request = System.Net.HttpWebRequest.Create(string.Format("{0}", url));
                request.Method = "GET";
                var response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                html = readStream.ReadToEnd();
                Console.WriteLine("Response stream received.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            string[] speicher;
            try
            {
                speicher = html.Split("<title>");
                return speicher[1].Split("</title>")[0];
            }
            catch
            {
                MessageBox.Show("Fehler aufgetreten 3");
                return html;
            }

            return html;
        }













        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void btn_variable_Click(object sender, EventArgs e)
        {
            string value = "";
            value = Environment.GetEnvironmentVariable("PATH");
            if (!value.Contains("ffmpeg"))
            {
                Environment.SetEnvironmentVariable("PATH", value + ";C:\\ffmpeg\\bin", EnvironmentVariableTarget.User);
                value = Environment.GetEnvironmentVariable("PATH");
                if (value.Contains("ffmpeg"))
                {
                    btn_variable.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Irgendwas scheint schief gelaufen zu sein");
                }
            }
            else
            {
                btn_variable.BackColor = Color.Green;
                MessageBox.Show("FFMPEG ist bereits installiert");
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\ffmpeg"))
            {
                DirectoryInfo t = new DirectoryInfo("C:\\ffmpeg");
                DirectoryInfo s = new DirectoryInfo("ffmpeg");
                CopyAll(s, t);
                if (Directory.Exists("C:\\ffmpeg"))
                {
                    btn_c.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Irgendwas scheint schief gelaufen zu sein");
                }

            }
            else
            {
                MessageBox.Show("FFMEPG ist bereits im C Ordner Vorhanden");
                btn_c.BackColor = Color.Green;
            }
            //ffmpeg -i "https://delivery-node-kaliq.voe-network.net/engine/hls2/01/00491/8rg59ghj3vwf_n/master.m3u8?t=bTh4ZcA0XkG4Nkk9KwOEvsKmD9_SWUgPsIImvHCr-0w&s=1668333357&e=14400&f=2455631&node=delivery-node-kaliq.voe-network.net&i=89.1&sp=4500&asn=8422" -bsf:a aac_adtstoasc -vcodec copy -c copy -crf 50 C:\\Users\\Fabian\\Desktop\\gg.mp4

        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_link.Text = "";
                    lbl_path.Text = openFileDialog.FileName;
                    lbl_speicherpath.Text = Path.GetDirectoryName(openFileDialog.FileName);
                }
            }

            //foreach (string line in System.IO.File.ReadLines(@"c:\test.txt"))
            //{
            //    System.Console.WriteLine(line);
            //}
        }



        private void btn_speicherort_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lbl_speicherpath.Text = (fbd.SelectedPath).ToString();
                }
            }
        }

        private void tb_link_TextChanged(object sender, EventArgs e)
        {
            lbl_path.Text = "Path";
        }

        private void btn_command_generiren_Click(object sender, EventArgs e)
        {
            string argument = "";
            if ((tb_link.Text == "" && lbl_path.Text == "Path") || lbl_speicherpath.Text == "Path")
            {
                MessageBox.Show("Sie müssen alle Daten angeben");
                return;
            }
            if (tb_link.Text == "")
            {
                foreach (string line in System.IO.File.ReadLines(lbl_path.Text))
                {
                    string getet_link = get_link(getSavedHtmlCode(line));
                    if (!(getet_link.Contains('<') && getet_link.Contains('>')) && getet_link != "")
                    {
                        argument = get_link(getSavedHtmlCode(line)) + '"'.ToString() + lbl_speicherpath.Text + "\\" + getfilename(line).Replace("|", "") + ".mp4" + '"'.ToString();
                        download_start(argument);
                    }
                }

            }
            else
            {
                argument = get_link(getSavedHtmlCode(tb_link.Text)) + '"'.ToString() + lbl_speicherpath.Text + "\\" + getfilename(tb_link.Text).Replace("|", "") + ".mp4" + '"'.ToString();
                Debug.WriteLine(argument);
                download_start(argument);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                Console.WriteLine("Sie müssen alles angeben");
                return;
            }
            String argument = get_link(textBox1.Text) + '"'.ToString() + label1.Text + "\\" + textBox2.Text + ".mp4" + '"'.ToString();
            download_start(argument);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    label1.Text = (fbd.SelectedPath).ToString();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_speicherpath_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
















        private void button6_Click(object sender, EventArgs e)
        {





        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    label14.Text = (fbd.SelectedPath).ToString();
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }


















        private void button3_Click(object sender, EventArgs e)
        {


            int i = 1;
            List<Download_from_Link> dfl = new List<Download_from_Link>();
            if (label10.Text == "")
            {
                Console.WriteLine("Sie müssen alles angeben");
                return;
            }
            using (StreamReader reader = new StreamReader(label10.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    dfl.Add(new Download_from_Link(line, true, i.ToString(), Path.GetDirectoryName(label10.Text).ToString()));
                    i = i + 1;
                }
            }
            foreach (Download_from_Link d in dfl)
            {
                d.download_start();
            }



            //int i = 1;
            //using (StreamReader reader = new StreamReader(label10.Text))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        String argument = get_link(line) + '"'.ToString() + Path.GetDirectoryName(label10.Text) + "\\" + textBox3.Text + i.ToString() + ".mp4" + '"'.ToString();
            //        download_start(argument);
            //        i = i + 1;
            //    }
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_link.Text = "";
                    label10.Text = openFileDialog.FileName;
                    lbl_path.Text = Path.GetDirectoryName(openFileDialog.FileName);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_path_Click(object sender, EventArgs e)
        {

        }
    }
}