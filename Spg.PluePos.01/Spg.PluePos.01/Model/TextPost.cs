using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
        public class TextPost : Post
        {
        private DateTime dateTime;

        public string? Content { get; set; }

            public int Laenge
            {
                get { return Content?.Length ?? 0; }
            }
            
            public TextPost(string _title, string _html, string _content) : base(_title, _html)
            {
                Content = _content;
            }

            public TextPost() : base()
            {

            }

        public TextPost(string title) : base(title)
        {
        }

        public TextPost(string title, DateTime dateTime) : this(title)
        {
            this.dateTime = dateTime;
        }

        public override string Html
            {
                get
                {
                    if (Content == null)
                    {
                        throw new ArgumentNullException("Content war NULL!");
                    }
                    else
                    {
                        return $"<h1>{Title}</h1><p>{Content}</p>";
                    }
                }
            }



        }
    
}
