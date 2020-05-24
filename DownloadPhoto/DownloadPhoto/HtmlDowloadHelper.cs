using System.Net;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace DownloadPhoto
{
    public class HtmlDowloadHelper
    {
        public static string Dowloadhtml(string uri)
        {
            //формировка запроса на сервер
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            //получение ответа от сервера 
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //получаем из response html
            StreamReader sr = new StreamReader( response.GetResponseStream());
            string html = sr.ReadToEnd();
            return html;
        }

        public static List<Image> DowloadImage(List<string> uri)
        {
            List<Image> ImageList = new List<Image>();
            foreach (var uri1 in uri)
            {
                WebRequest request = WebRequest.Create(uri1);
                WebResponse response = request.GetResponse();
                ImageList.Add(Image.FromStream(response.GetResponseStream()));
            }
            return ImageList;
        } 
    }
}
