using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class Post
    {
        private string text;

        public Post(string text)
        {
            this.text = Text;
        }

        public void ShowPost()
        {
            Console.WriteLine("New post");
            Console.WriteLine(text);
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
    }
}
