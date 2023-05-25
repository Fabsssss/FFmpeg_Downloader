using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FFmpeg_Downloader
{
    internal class Download_from_Link
    {

        private string voe_link;
        private string voe_download_link;
        private string filename;
        private string path;
        public Download_from_Link(String link, bool alreday_a_Download_link, string filename, string path)
        {
            this.path = path;
            if (alreday_a_Download_link)
            {
                voe_download_link = link;
                this.filename = filename;
            }
            else
            {
                string html = getHtmlCode(link);
                voe_download_link = extract_Link_from_html(html);
                this.filename = getfilename(html);
            }
        }



        public bool download_start()
        {
            string argument = url_with_arguemnts(voe_download_link) + '"'.ToString() + path + "\\" + filename + ".mp4" + '"'.ToString();
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
            return true;
        }

        private string url_with_arguemnts(string url)
        {
            string befehl = " -i " + '"'.ToString() + url + '"'.ToString() + " -bsf:a aac_adtstoasc -vcodec copy -c copy -crf 50 ";
            return befehl;
        }

        private string extract_Link_from_html(string html)
        {
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


        private string getHtmlCode(string url)
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
            return html;
        }

        public string getfilename(string html)
        {
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


    }
}
