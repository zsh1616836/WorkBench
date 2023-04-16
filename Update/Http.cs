using System.IO;
using System.Net;

namespace Update
{
    public class Http
    {
        private static readonly WebClient Client = new WebClient();
        public static bool Get(string url, ref string result)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream != null)
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                result = reader.ReadToEnd();
                            }
                    }
                }
            }
            catch (WebException)
            {
                return false;
            }

            return true;
        }

        public static bool Post(string url, string data, ref string result)
        {
            try
            {
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = buffer.Length;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(buffer, 0, buffer.Length);
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException)
            {
                return false;
            }

            return true;
        }

        public static bool Download(string url, string savePath)
        {
            try
            {
                Client.DownloadFile(url, savePath);
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}