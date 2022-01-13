using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class Post
    {
        public int Lenght { get; set; }
        public string Text { get; set; }
        public List<string> Tags { get; set; }

        public Post(string text, List<string> tags)
        {
            Text = text;
            Tags = tags;
            Lenght = text.Length;

        }


        

    }
}
