using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class ImagePost : Post
        {
        private DateTime dateTime;

        public string? Url { get; set; }

            public override string Html
            {
                get
                {
                    if (Url == null)
                    {
                        throw new ArgumentNullException("Url war NULL!");
                    }
                    else
                    {
                        return $"<h1>{Title}</h1><img src={Url} />";
                    }
                }
            }

            public ImagePost(string _title, string _html, string _url) : base(_title, _html)
            {
                Url = _url;
            }

        public ImagePost(string title) : base(title)
        {
        }

        public ImagePost(string title, DateTime dateTime) : this(title)
        {
            this.dateTime = dateTime;
        }
    }
}

