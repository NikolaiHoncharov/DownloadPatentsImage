using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;

namespace DownloadPhoto
{
    public class SearcherException: Exception
    {
        public SearcherException(string message)
            : base(message) { }
    }
   
    public class Searcher
    {
        public string _html { get; set; }
        public List<Image> _cover { get; set; }
        private readonly string BaseURi;
        List<string> result;
        List<string> Uri;

        public Searcher()
        {
            BaseURi = @"https://patents.google.com/patent/{0}";
            result = new List<string>();
            Uri = new List<string>();
        }

        public bool DowloadHtml(string SearchName)
        {
            _cover = null;
            try {
                _html = HtmlDowloadHelper.Dowloadhtml(string.Format(BaseURi, SearchName));
                return true;}
            catch{return false;} 
        }
        public bool FindCover()
        {
            if (String.IsNullOrEmpty(_html))
                throw new SearcherException("Code HTML do not download");
            string firstWordbp = "content=\"https://patentimages.storage.googleapis.com/";
            foreach (Match m in Regex.Matches(_html, firstWordbp)) {
                int lengthbp = _html.IndexOf('>') - Convert.ToInt32( m.Index);
                for (int i = m.Index; i < _html.Length; i++)
                {
                    if (_html[i] == '>')
                    {
                        lengthbp = i;
                        break;
                    }
                }
                if (!result.Contains(_html.Substring(Convert.ToInt32(m.Index), lengthbp)))
                result.Add(_html.Substring(Convert.ToInt32(m.Index+9), lengthbp));
            }

            string srere = "";
            foreach (var url in result)
            {            
                srere = url.Split('\"')[0];
                if (srere.Contains(".pdf") == false) Uri.Add(srere);
            }
            try
            {
                _cover = HtmlDowloadHelper.DowloadImage(Uri);
                return true;
            }
            catch { return false; }
        }

        public string Corect(string text)
        {
            text = text.Replace(' ', '&').Replace(':', '=').Replace("(", "").Replace(")", "").Replace("*", "");
            return text;
        }

        public List<Image> Cover {
            get {
                if (_cover == null)
                    throw new SearcherException("Image not uploaded");
                return _cover;
            }
        }
        //saving all photos to happen on disk D:
        public void ImgDnld()
        {
            int count = 1;
            string path;
            if (Uri != null)
            {
                foreach (var url in Uri)
                {
                    path = $"D:\\image{++count}.png";
                    using (WebClient client = new WebClient()) client.DownloadFileAsync(new Uri(url), path); 
                }
            }
        }
    }
}
