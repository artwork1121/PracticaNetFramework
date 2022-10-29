using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Framework.Utils
{
    public class Card
    {
        public Card(string img, string title, string body, string link)
        {
            Img = img;
            Title = title;
            Body = body;
            Link = link;
        }

        public string Img { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Link { get; set; }
    }
}